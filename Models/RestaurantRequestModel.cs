using System.ComponentModel.DataAnnotations;

namespace RestaurantApp.Models
{
    public class RestaurantRequestModel
    {

        [Required]
        public string Location { get; init; } = string.Empty;
    }
}
