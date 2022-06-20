using Microsoft.AspNetCore.Mvc;
using RestaurantApp.Models;
using RestaurantApp.Services;
using System.Diagnostics;
using System.Text.Json;
using System.Linq;
namespace RestaurantApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IRestaurantServices _restaurantServices;

        public HomeController(IRestaurantServices restaurantServices)
        {

            _restaurantServices = restaurantServices;
        }

        public IActionResult Index()
        {
            return View();
        }


        public IActionResult Restaurants(RestaurantRequestModel _requestModel)
        {

            if (!ModelState.IsValid) return BadRequest(ModelState);
            ViewData["location"] = _requestModel.Location;

            var result = _restaurantServices.GetRestaurantLists(_requestModel);
            var data = result.Result.ToList().Take(20);
            //var responseText = JsonSerializer.Serialize(result.Result, new JsonSerializerOptions { WriteIndented = true });
            return View(data);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}