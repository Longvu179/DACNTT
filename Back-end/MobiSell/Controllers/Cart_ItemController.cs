﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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

        // GET: api/Cart_Item
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Cart_Item>>> GetCart_Items(int cartId)
        {
            return await _context.Cart_Items.Where(i => i.CartId == cartId).ToListAsync();
        }
        [HttpGet("getSelected")]
        public async Task<ActionResult<IEnumerable<Cart_Item>>> GetCart_Item_Selected(int cartId)
        {
            return await _context.Cart_Items.Where(i => i.CartId == cartId & i.IsSelected == true).ToListAsync();
        }

        // GET: api/Cart_Item/5
        [HttpGet("{id}")]
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
        public async Task<IActionResult> PutCart_Item(int id, int amount)
        {
            var cart_Item = await _context.Cart_Items.FindAsync(id);
            if (cart_Item == null)
            {
                return BadRequest();
            }

            if (amount < 1 && cart_Item.Quantity > 1)
            {
                cart_Item.Quantity -= 1;
            }
            else
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
        public async Task<IActionResult> PurchaseCart(string userId, int cartId, string name, string phoneNumber, string address, PaymentMethod pm)
        {
            var cartItems = await _context.Cart_Items.Where(i => i.CartId == cartId & i.IsSelected == true).ToListAsync();
            var order = new Order
            {
                UserId = userId,
                ReceiverName = name,
                ReceiverNumber = phoneNumber,
                OrderDate = DateTime.Now,
                payment = pm,
                IsPaid = false,
                ShippingAddress = address,
            };

            foreach (var item in cartItems)
            {
                var product = await _context.Product_SKUs.FindAsync(item.Product_SKUId);
                order.OrderTotal += product.FinalPrice * item.Quantity;
            }

            _context.Orders.Add(order);
            await _context.SaveChangesAsync();

            foreach (var item in cartItems)
            {
                var product = await _context.Product_SKUs.FindAsync(item.Product_SKUId);
                var orderItem = new Order_Item
                {
                    OrderId = order.Id,
                    Product_SKUId = item.Product_SKUId,
                    Quantity = item.Quantity,
                    Price = product.FinalPrice
                };

                _context.Order_Items.Add(orderItem);
                _context.Cart_Items.Remove(item);
            }

            await _context.SaveChangesAsync();

            if (pm == PaymentMethod.VNpay)
            {
                var request = new VNPayRequestDTO
                {
                    OrderType = "billpayment",
                    OrderDescription = "Thanh toán đơn hàng",
                    Amount = order.OrderTotal,
                    Name = name
                };

                var url = _vnPayService.CreatePaymentUrl(request, HttpContext);
                return Ok(url);
            }
            return Ok();
        }
    }
}
