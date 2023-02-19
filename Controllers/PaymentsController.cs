using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PetinyAPI.Commons;
using PetinyAPI.Models;
using PetinyAPI.Requests;
using PetinyAPI.Responses;
using System.Net.Http;
using System.Text.Json;
using System.Text;
using Azure.Core;

namespace PetinyAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaymentsController : ControllerBase
    {
        private readonly PetinyDbContext _context;

        public PaymentsController(PetinyDbContext context)
        {
            _context = context;
        }

        // GET: api/Payments
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Payment>>> GetPayments()
        {
            return await _context.Payments.ToListAsync();
        }

        // GET: api/Payments/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Payment>> GetPayment(int id)
        {
            var payment = await _context.Payments.FindAsync(id);

            if (payment == null)
            {
                return NotFound();
            }

            return payment;
        }

        // PUT: api/Payments/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPayment(int id, Payment payment)
        {
            if (id != payment.Id)
            {
                return BadRequest();
            }

            _context.Entry(payment).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PaymentExists(id))
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

        // POST: api/Payments
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Payment>> PostPayment(Payment payment)
        {
            _context.Payments.Add(payment);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPayment", new { id = payment.Id }, payment);
        }

        //POST : api/Payments/PayWithMomo
        //[HttpPost("PayWithMomo")]
        //public async Task<ActionResult<String>> PayWithMomo(MomoClientRequest request)
        //{
        //    string MOMO_URI = "https://test-payment.momo.vn/v2/gateway/api/create";
        //    string ACCESS_KEY = "WehkypIRwPP14mHb";
        //    string IPN_URL_MOMO = "https://localhost:7224/api/Payments/MomoConfirm";
        //    string PARTNER_CODE = "MOMODJMX20220717";
        //    string REDIRECT_URL_MOMO = "https://localhost:7224/api/Payments/MomoConfirm";
        //    string SECRET_KEY = "3fq8h4CqAAPZcTTb3nCDpFKwEkQDsZzz";

        //    // request url
        //    String url = MOMO_URI;

        //    // create a post object

        //    // build the request
           

        //    List<string> oList = request.OrderId;

        //    String orderId = string
        //        .Concat("-", oList);

        //    string amount = string.Format("10000000000");

        //    String sign = "accessKey=" + ACCESS_KEY + "&amount=" + amount + "&extraData="
        //            + "&ipnUrl=" + IPN_URL_MOMO + "&orderId=" + orderId + "&orderInfo="
        //            + "Thanh toan momo"
        //            + "&partnerCode=" + PARTNER_CODE + "&redirectUrl=" + REDIRECT_URL_MOMO
        //            + "&requestId=" + orderId + "&requestType=captureWallet";

        //    // accessKey=$accessKey&amount=$amount&extraData=$extraData
        //    // &ipnUrl=$ipnUrl&orderId=$orderId&orderInfo=$orderInfo
        //    // &partnerCode=$partnerCode&redirectUrl=$redirectUrl
        //    // &requestId=$requestId&requestType=$requestType

        //    String signatureHmac = "";
        //    try
        //    {
        //        signatureHmac = Common.calculateHmac(sign, SECRET_KEY);
        //        Console.WriteLine("Hmac = " + signatureHmac);
        //    }

        //    catch (Exception)
        //    {

        //    }
        //    HttpClient client = new HttpClient();
          
        //    using StringContent jsonContent = new(
        //        JsonSerializer.Serialize(new
        //    {
        //         PartnerCode = PARTNER_CODE ,
        //        Signature = signatureHmac ,
        //        Amount= amount ,
        //        ExtraData= "" ,
        //         IpnUrl = IPN_URL_MOMO ,
        //         Lang = "vi" ,
        //         OrderId = orderId ,
        //         OrderInfo = "Thanh toan momo" ,
        //         RedirectUrl = REDIRECT_URL_MOMO ,
        //         RequestId = orderId ,
        //         RequestType = "captureWallet" 
        //}),
        //        //Thuoc tinh trong json bi sai -> 400
        //        Encoding.UTF8,
        //        "application/json");

        //    using HttpResponseMessage response = await client.PostAsync(
        //            url,
        //                jsonContent);

        //    //var response = await client.PostAsync(url, content);

        //    var responseString = await response.Content.ReadAsStringAsync();

        //    Console.WriteLine("ResponseString = " + responseString);

        //    return response.Content.ToString();
        //}

        ////[HttpGet("MomoConfirm")]
        ////public async Task<IActionResult<MomoResponse>> confirmResult()
        ////{
        ////    return null;
        ////}


        // DELETE: api/Payments/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePayment(int id)
        {
            var payment = await _context.Payments.FindAsync(id);
            if (payment == null)
            {
                return NotFound();
            }

            _context.Payments.Remove(payment);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool PaymentExists(int id)
        {
            return _context.Payments.Any(e => e.Id == id);
        }
    }

}

