using System.Text.Json.Serialization;

namespace active_directory_b2c_dotnet_uwp
{
    public class InstallRegistration
    {
        [JsonPropertyName("vid")]
        public string VendorId { get; set; }

        [JsonPropertyName("iid")]
        public string InstallId { get; set; }

        [JsonPropertyName("cid")]
        public string CryptographicId { get; set; }

        [JsonPropertyName("aid")]
        public string AdvertisingId { get; set; } = string.Empty;

        [JsonPropertyName("oid")]
        public string ObjectId { get; set; }
    }
}
