using RestaurantApp.Models;

namespace RestaurantApp.Data
{
    public static class MockData
    {

        //Mock Data for unit testing in mvc apps using moq

        public static List<RestaurantResponseModel> GetRestaurantLocations()
        {
            var restaurants = new List<RestaurantResponseModel>()
            {
                new RestaurantResponseModel()
                {
                   BusinessName = "Otto's",
                   AddressLine2 = "Gray's Inn Road",
                   PostCode = "TE3847"
                },
                new RestaurantResponseModel()
                {
                   BusinessName = "Harry's Bar",
                   AddressLine2 = "Hyde Park",
                   PostCode = "TJ3847"
                }
            };



            return restaurants;



        }
    }
}
