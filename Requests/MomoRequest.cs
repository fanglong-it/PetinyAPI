using System;

namespace PetinyAPI.Requests
{
    public class MomoRequest
    {
        public string PartnerCode { get; set; }

        public string PartnerName { get; set; }// option

        public string StoreId { get; set; }  // option

        public string RequestId { get; set; }// == orderId

        public string RequestType { get; set; }

        public string IpnUrl { get; set; }

        public string RedirectUrl { get; set; }

        public string OrderId { get; set; }

        public string OrderInfo { get; set; }

        public string ExtraData { get; set; }// codebase64 - or ""

        public bool AutoCapture { get; set; }// default is true. if false transaction is not auto capture

        public string Lang { get; set; }// vi - en

        public string Signature { get; set; }

        public string Amount { get; set; }

        //public Customer userInfo;
    }
}
