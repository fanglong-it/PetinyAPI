namespace PetinyAPI.Responses
{
    public class MomoResponse
    {
        private string? PartnerCode { get; set; }

        private string? OrderId { get; set; }

        private string? RequestId { get; set; }

        private long Amount { get; set; }

        private string? ResponseTime { get; set; }

        private string? Message { get; set; }

        private int ResultCode { get; set; }

        private string? PayUrl { get; set; }

        private string? Deeplink { get; set; }

        private string? QrCodeUrl { get; set; }

        private string? DeeplinkMiniApp { get; set; }
    }
}
