using Refit;
using RestaurantApp.Models;

namespace RestaurantApp.Api
{
    public interface IRestaurantApi
    {


        [Headers("X-RapidAPI-Key: 752decb39dmsh4c8542c19a61511p12b8c4jsnf4fd2a27d64b", "X-RapidAPI-Host: wyre-data.p.rapidapi.com")]

        [Get("/{location}")]

        Task<ApiResponse<List<RestaurantResponseModel>>> GetRestaurantLists(string location);
    }
}
