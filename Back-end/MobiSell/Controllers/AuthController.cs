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
        public async Task<IActionResult> Register([FromBody] RegisterModel model, string url)
        {
            var userExists = await _userManager.FindByNameAsync(model.Username);
            if (userExists != null)
                return BadRequest( new { Status = "Error", message = "User already exists!" });
            var emailExists = await _userManager.FindByEmailAsync(model.Email);
            if (emailExists != null)
                return BadRequest( new { Status = "Error", message = "Email already exists!" });

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
                return BadRequest( new { Status = "Error", message = "User creation failed! Please check user details and try again." });                
            }

            await _userManager.AddToRoleAsync(user, "User");

            var token = await _userManager.GenerateEmailConfirmationTokenAsync(user);
            var confirmationLink = $"{url}?userId={user.Id}&token={Uri.EscapeDataString(token)}";
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
                return Unauthorized( new { message = "Invalid username or password." });
            }

            // Kiểm tra xem email đã được xác nhận chưa
            if (!user.EmailConfirmed)
            {
                return Unauthorized(new { message = "Please confirm your email before logging in." });
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
        [Authorize]
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
        [Authorize]
        public async Task<IActionResult> UpdateProfile(string userId, [FromBody] UserDTO user)
        {
            var currentUser = await _userManager.FindByIdAsync(userId);
            if (currentUser == null)
            {
                return NotFound(new { message = "User not found." });
            }

            currentUser.PhoneNumber = user.PhoneNumber;
            currentUser.FullName = user.FullName;
            currentUser.Address = user.Address;

            var result = await _userManager.UpdateAsync(currentUser);
            if (result.Succeeded)
            {
                return Ok(new { success = "Update profile success." });
            }

            return BadRequest(new { message = "Update profile failed." });
        }
        
        [HttpPut("change-password")]
        [Authorize]
        public async Task<IActionResult> ChangePassword([FromBody] ChangePasswordModel model)
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            if (user == null)
            {
                return NotFound(new { message = "User not found." });
            }

            var result = await _userManager.ChangePasswordAsync(user, model.CurrentPassword, model.NewPassword);
            if (result.Succeeded)
            {
                return Ok(new { success = "Change password success." });
            }

            return BadRequest(new { message = "Change password failed." });
        }

        [HttpPost("forgot-password")]
        public async Task<IActionResult> ForgotPassword(string email, string url)
        {
            var user = await _userManager.FindByEmailAsync(email);
            if (user == null)
            {
                return NotFound(new { message = "User not found." });
            }

            var token = await _userManager.GeneratePasswordResetTokenAsync(user);
            Console.WriteLine(token);
            var confirmationLink = $"{url}?userId={user.Id}&token={Uri.EscapeDataString(token)}";
            var emailDTO = new EmailDTO()
            {
                To = user.Email,
                Subject = "Reset Your Password",
                Body = "<p>Reset your password by clicking the link below.</p> " +
                        $"<a href='{confirmationLink}'>Click here to reset your password</a>"
            };

            try
            {
                _emailService.SendEmail(emailDTO);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Error sending email: " + ex.Message);
            }

            return Ok(new { success = "Please check your email to reset password." });
        }

        [HttpGet("reset-password")]
        public async Task<IActionResult> ResetPassword(string userId, string token, string newPassword)
        {
            var user = await _userManager.FindByIdAsync(userId);
            if (user == null)
            {
                return NotFound( new { message = "User not found." });
            }

            var decodedToken = Uri.UnescapeDataString(token);
            Console.WriteLine(decodedToken);
            var result = await _userManager.ResetPasswordAsync(user, decodedToken, newPassword);

            if (result.Succeeded)
            {
                return Ok( new { success = "Reset password success." });
            }

            return BadRequest(new { message = result.Errors.Select(e => e.Description) });
        }


        [HttpGet("confirm-email")]
        public async Task<IActionResult> ConfirmEmail(string userId, string token)
        {
            if (userId == null || token == null)
            {
                return BadRequest(new { message = "Thiếu thông tin xác thực." });
            }

            var user = await _userManager.FindByIdAsync(userId);
            if (user == null)
            {
                return NotFound(new { message = "Người dùng không tồn tại." });
            }

            var result = await _userManager.ConfirmEmailAsync(user, token);
            if (result.Succeeded)
            {
                return Ok(new { success = "Email đã được xác thực thành công." });
            }

            return BadRequest(new { message = "Xác thực email thất bại." });
        }

    }
}
