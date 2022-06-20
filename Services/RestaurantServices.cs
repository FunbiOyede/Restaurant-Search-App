using Refit;
using RestaurantApp.Api;
using RestaurantApp.Models;

namespace RestaurantApp.Services
{
    public class RestaurantServices : IRestaurantServices
    {
        IRestaurantApi _restaurantApi;
        public RestaurantServices(IRestaurantApi restaurantApi)
        {
            _restaurantApi = restaurantApi;

        }
        public async Task<List<RestaurantResponseModel>> GetRestaurantLists(RestaurantRequestModel request)
        {
            try
            {
                var response = await _restaurantApi.GetRestaurantLists(request.Location);

                return response.Content;
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
                throw;
            }



        }
    }
}
