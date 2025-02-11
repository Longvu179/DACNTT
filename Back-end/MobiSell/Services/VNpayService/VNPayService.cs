using System;
using System.Collections.Generic;
using System.Globalization;
using System.Security.Cryptography;
using System.Text;
using Microsoft.Extensions.Configuration;
using MobiSell.Services.VNpayService;
namespace MobiSell.Services
{
    public class VNPayService
    {
        private readonly string _vnp_TmnCode = "U41VENDN";
        private readonly string _vnp_HashSecret = "3UC6UQ5KP174YE1J3XP9MLD0KLH0X6GP";
        private readonly string _vnp_Url = "https://sandbox.vnpayment.vn/paymentv2/vpcpay.html";

        public string CreatePaymentUrl(VNPayRequestDto request, string returnUrl)
        {
            var vnpay = new VNPayLibrary();
            vnpay.AddRequestData("vnp_Version", "2.1.0");
            vnpay.AddRequestData("vnp_Command", "pay");
            vnpay.AddRequestData("vnp_TmnCode", _vnp_TmnCode);
            vnpay.AddRequestData("vnp_Amount", (request.Amount * 100).ToString()); // Amount in VND
            vnpay.AddRequestData("vnp_CreateDate", request.CreateDate.ToString("yyyyMMddHHmmss"));
            vnpay.AddRequestData("vnp_CurrCode", "VND");
            vnpay.AddRequestData("vnp_IpAddr", request.IpAddress);
            vnpay.AddRequestData("vnp_Locale", "vn");
            vnpay.AddRequestData("vnp_OrderInfo", request.OrderInfo);
            vnpay.AddRequestData("vnp_OrderType", "other");
            vnpay.AddRequestData("vnp_ReturnUrl", returnUrl);
            vnpay.AddRequestData("vnp_TxnRef", request.OrderId);

            string paymentUrl = vnpay.CreateRequestUrl(_vnp_Url, _vnp_HashSecret);
            return paymentUrl;
        }

        public bool ValidatePayment(IQueryCollection collections, out string orderId)
        {
            var vnpay = new VNPayLibrary();
            foreach (var (key, value) in collections)
            {
                if (!string.IsNullOrEmpty(key) && key.StartsWith("vnp_"))
                {
                    vnpay.AddResponseData(key, value);
                }
            }

            orderId = vnpay.GetResponseData("vnp_TxnRef");
            var vnp_SecureHash = collections["vnp_SecureHash"];
            var vnp_ResponseCode = vnpay.GetResponseData("vnp_ResponseCode");

            return vnpay.ValidateSignature(vnp_SecureHash, _vnp_HashSecret) && vnp_ResponseCode == "00";
        }
    }
}
