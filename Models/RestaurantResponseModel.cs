using System.Text.Json.Serialization;

namespace RestaurantApp.Models
{
    public record RestaurantResponseModel
    {


        [JsonPropertyName("BusinessName")]
        public string BusinessName { get; init; } = string.Empty;
        [JsonPropertyName("AddressLine2")]
        public string AddressLine2 { get; init; } = string.Empty;
        [JsonPropertyName("PostCode")]
        public string PostCode { get; init; } = string.Empty;

    }
}
