
using Refit;
using RestaurantApp.Models;

namespace RestaurantApp.Services
{
    public interface IRestaurantServices
    {

        Task<List<RestaurantResponseModel>> GetRestaurantLists(RestaurantRequestModel request);
    }
}
