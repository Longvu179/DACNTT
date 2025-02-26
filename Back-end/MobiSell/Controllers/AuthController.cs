using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using MobiSell.Data;
using MobiSell.Models;
using MobiSell.Services.EmailService;
using NuGet.Common;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace MobiSell.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;
        private readonly IConfiguration _configuration;
        private readonly IEmailService _emailService;
        private readonly MobiSellContext _context;

        public AuthController(UserManager<User> userManager, SignInManager<User> signInManager, IConfiguration configuration, IEmailService emailService, MobiSellContext context)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _configuration = configuration;
            _emailService = emailService;
            _context = context;
        }

        [HttpPost]
        [Route("register")]
        public async Task<IActionResult> Register([FromBody] RegisterModel model)
        {
            var userExists = await _userManager.FindByNameAsync(model.Username);
            if (userExists != null)
                return StatusCode(StatusCodes.Status500InternalServerError, new { Status = "Error", Message = "User already exists!" });
            var emailExists = await _userManager.FindByEmailAsync(model.Email);
            if (emailExists != null)
                return StatusCode(StatusCodes.Status500InternalServerError, new { Status = "Error", Message = "Email already exists!" });

            var user = new User()
            {
                Email = model.Email,
                SecurityStamp = Guid.NewGuid().ToString(),
                UserName = model.Username,
                EmailConfirmed = false
            };

            var result = await _userManager.CreateAsync(user, model.Password);
            if (!result.Succeeded)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, new { Status = "Error", Message = "User creation failed! Please check user details and try again." });                
            }

            await _userManager.AddToRoleAsync(user, "User");

            var token = await _userManager.GenerateEmailConfirmationTokenAsync(user);
            var confirmationLink = $"https://localhost:7011/api/Auth/confirm-email?userId={user.Id}&token={Uri.EscapeDataString(token)}";
            var emailDTO = new EmailDTO()
            {
                To = user.Email,
                Subject = "Verify Your Email",
                Body = "<p> Verify your email address to complete the signup and login into your account.</p> " +
                        $"<a href='{confirmationLink}'>Click here to confirm your email</a>"
            };
            _emailService.SendEmail(emailDTO);

            var cart = new Cart()
            {
                UserId = user.Id,
                Total = 0,
                UpdateAt = DateTime.UtcNow,
            };
            _context.Carts.Add(cart);
            await _context.SaveChangesAsync();
            
            return Ok();
        }

        [HttpPost]
        [Route("login")]
        public async Task<IActionResult> Login([FromBody] LoginModel model)
        {
            var user = await _userManager.FindByNameAsync(model.Username);
            if (user == null)
            {
                return Unauthorized("Invalid username or password.");
            }

            // Kiểm tra xem email đã được xác nhận chưa
            if (!user.EmailConfirmed)
            {
                return Unauthorized("Please confirm your email before logging in.");
            }

            if (await _userManager.CheckPasswordAsync(user, model.Password))
            {
                var userRoles = await _userManager.GetRolesAsync(user);

                var claim = new List<Claim>
                {
                    new Claim(ClaimTypes.Name, user.UserName),
                    new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                };

                foreach (var userRole in userRoles)
                {
                    claim.Add(new Claim(ClaimTypes.Role, userRole));
                }

                
                var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["Jwt:Key"]));
                
                var token = new JwtSecurityToken(
                    issuer: _configuration["Jwt:Issuer"],
                    audience: _configuration["Jwt:Audience"],
                    claims: claim,
                    expires: DateTime.Now.AddDays(3),
                    signingCredentials: new SigningCredentials(key, SecurityAlgorithms.HmacSha256)
                );

                var cart = await _context.Carts.FirstOrDefaultAsync(c => c.UserId == user.Id);
                if (cart == null)
                {
                    var newCart = new Cart()
                    {
                        UserId = user.Id,
                        Total = 0,
                        UpdateAt = DateTime.UtcNow,
                    };
                    _context.Carts.Add(newCart);
                    await _context.SaveChangesAsync();
                    cart = newCart;
                }

                Response.Cookies.Append("token", new JwtSecurityTokenHandler().WriteToken(token), new CookieOptions
                {
                    HttpOnly = true,
                    SameSite = SameSiteMode.None,
                    Secure = true,
                    Expires = DateTime.Now.AddDays(3)
                });
                

                return Ok(new 
                { 
                    token = new JwtSecurityTokenHandler().WriteToken(token),
                    expiration = token.ValidTo,
                    userId = user.Id,
                    username = user.UserName,
                    role = userRoles[0],
                    cartId = cart.Id
                });
            }
            return Unauthorized();
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<User>>> GetUsers()
        {
            return await _context.Users.ToListAsync();
        }

        [HttpGet]
        [Route("profile")]
        public async Task<IActionResult> Profile(string userId)
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            //var user = await _userManager.FindByIdAsync(userId);
            if (user != null)
            {
                return Ok(user);
            }
            return Unauthorized();
        }

        [HttpPut("{userId}")]
        public async Task<IActionResult> UpdateProfile(string userId, [FromBody] UserDTO user)
        {
            var currentUser = await _userManager.FindByIdAsync(userId);
            if (currentUser == null)
            {
                return NotFound("User not found.");
            }

            currentUser.PhoneNumber = user.PhoneNumber;
            currentUser.FullName = user.FullName;
            currentUser.Address = user.Address;

            var result = await _userManager.UpdateAsync(currentUser);
            if (result.Succeeded)
            {
                return Ok("Update profile success.");
            }

            return BadRequest("Update profile failed.");
        }

        [HttpPut("change-password")]
        public async Task<IActionResult> ChangePassword([FromBody] ChangePasswordModel model)
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            if (user == null)
            {
                return NotFound("User not found.");
            }

            var result = await _userManager.ChangePasswordAsync(user, model.CurrentPassword, model.NewPassword);
            if (result.Succeeded)
            {
                return Ok("Change password success.");
            }

            return BadRequest("Change password failed.");
        }

        [HttpGet("confirm-email")]
        public async Task<IActionResult> ConfirmEmail(string userId, string token)
        {
            if (userId == null || token == null)
            {
                return BadRequest("Thiếu thông tin xác thực.");
            }

            var user = await _userManager.FindByIdAsync(userId);
            if (user == null)
            {
                return NotFound("Người dùng không tồn tại.");
            }

            var result = await _userManager.ConfirmEmailAsync(user, token);
            if (result.Succeeded)
            {
                return Ok("Email đã được xác thực thành công.");
            }

            return BadRequest("Xác thực email thất bại.");
        }

    }
}
