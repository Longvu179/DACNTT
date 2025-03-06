using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MobiSell.Data;
using MobiSell.Models;
using MobiSell.Services;
using MobiSell.Services.VNpayService;

namespace MobiSell.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Cart_ItemController : ControllerBase
    {
        private readonly MobiSellContext _context;
        private readonly IVNPayService _vnPayService;

        public Cart_ItemController(MobiSellContext context, IVNPayService vnPayService)
        {
            _context = context;
            _vnPayService = vnPayService;
        }

        [HttpGet]
        [Authorize]
        public async Task<ActionResult<IEnumerable<Cart_Item>>> GetCart_Items(int cartId)
        {
            return await _context.Cart_Items.Where(i => i.CartId == cartId).ToListAsync();
        }

        [HttpGet("getSelected")]
        [Authorize]
        public async Task<ActionResult<IEnumerable<Cart_Item>>> GetCart_Item_Selected(int cartId)
        {
            return await _context.Cart_Items.Where(i => i.CartId == cartId & i.IsSelected == true).ToListAsync();
        }

        // GET: api/Cart_Item/5
        [HttpGet("{id}")]
        [Authorize]
        public async Task<ActionResult<Cart_Item>> GetCart_Item(int id)
        {
            var cart_Item = await _context.Cart_Items.FindAsync(id);

            if (cart_Item == null)
            {
                return NotFound();
            }

            return cart_Item;
        }

        [HttpPut("{id}")]
        [Authorize]
        public async Task<IActionResult> PutCart_Item(int id, int amount)
        {
            var cart_Item = await _context.Cart_Items.FindAsync(id);
            var product = await _context.Product_SKUs.FindAsync(cart_Item.Product_SKUId);

            if (cart_Item == null)
            {
                return BadRequest();
            }

            if (amount < 1 && cart_Item.Quantity > 1 )
            {
                cart_Item.Quantity -= 1;
            }
            else if (amount > 0 && cart_Item.Quantity < product.Quantity)
            {
                cart_Item.Quantity += 1;
            }

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Cart_ItemExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        [HttpPut("select/{id}")]
        [Authorize]
        public async Task<IActionResult> UpdateSelect(int id, bool select)
        {
            var cart_Item = await _context.Cart_Items.FindAsync(id);
            if (cart_Item == null)
            {
                return NotFound();
            }

            cart_Item.IsSelected = select;
            await _context.SaveChangesAsync();

            return NoContent();
        }

        [HttpDelete("{id}")]
        [Authorize]
        public async Task<IActionResult> DeleteCart_Item(int id)
        {
            var cart_Item = await _context.Cart_Items.FindAsync(id);
            if (cart_Item == null)
            {
                return NotFound();
            }

            _context.Cart_Items.Remove(cart_Item);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool Cart_ItemExists(int id)
        {
            return _context.Cart_Items.Any(e => e.Id == id);
        }

        [HttpPost("Purchase")]
        [Authorize]
        public async Task<IActionResult> PurchaseCart(string userId, int cartId, string name, string phoneNumber, string address, PaymentMethod pm, int product_SKUId, int quantity, string returnUrl)
        {   
            var order = new Order
            {
                UserId = userId,
                ReceiverName = name,
                ReceiverNumber = phoneNumber,
                OrderDate = DateTime.Now,
                Payment = pm,
                IsPaid = false,
                IsRate = false,
                ShippingAddress = address,
                Status = OrderStatus.Processing,
                OrderTotal = 0,
            };

            _context.Orders.Add(order);
            await _context.SaveChangesAsync();

            if (await _context.Product_SKUs.FindAsync(product_SKUId) != null)
            {
                var product = await _context.Product_SKUs.FindAsync(product_SKUId);
                order.OrderTotal = product.FinalPrice * quantity;

                var orderItem = new Order_Item
                {
                    OrderId = order.Id,
                    Product_SKUId = product_SKUId,
                    Quantity = quantity,
                    Price = product.FinalPrice,
                };
                _context.Order_Items.Add(orderItem);
                await _context.SaveChangesAsync();
            }
            else
            {
                var cartItems = await _context.Cart_Items.Where(i => i.CartId == cartId & i.IsSelected == true).ToListAsync();

                foreach (var item in cartItems)
                {
                    var product = await _context.Product_SKUs.FindAsync(item.Product_SKUId);
                    order.OrderTotal += product.FinalPrice * item.Quantity;

                    var orderItem = new Order_Item
                    {
                        OrderId = order.Id,
                        Product_SKUId = item.Product_SKUId,
                        Quantity = item.Quantity,
                        Price = product.FinalPrice,
                    };

                    product.Quantity -= item.Quantity;
                    product.Sold += item.Quantity;
                    _context.Order_Items.Add(orderItem);
                    _context.Cart_Items.Remove(item);
                }

                await _context.SaveChangesAsync();
            }


            if (pm == PaymentMethod.VNpay)
            {
                var request = new VNPayRequestDTO
                {
                    OrderId = order.Id.ToString(),
                    OrderType = "billpayment",
                    OrderDescription = "Thanh toán đơn hàng",
                    Amount = order.OrderTotal,
                    Name = name,
                    ReturnUrl = returnUrl
                };

                var url = _vnPayService.CreatePaymentUrl(request, HttpContext);
                return Ok(url);
            }
            return Ok();
        }
    }
}
