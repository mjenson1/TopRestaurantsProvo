using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using TopRestaurantsProvo.Models;

namespace TopRestaurantsProvo.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        
        public IActionResult Index() // add this in after changing original index page
        {
            return View();
        }

        [HttpGet("List")] //can change the path with the parameter passed
        public IActionResult RestaurantList()
        {
            List<string> restaurantList = new List<string>(); //declaring and instantiating variable
            foreach(Restaurant r in Restaurant.GetRestaurants()) //going to the band object and returning list
            {
                restaurantList.Add(string.Format("#{0}: {1} ({2}), {3}, {4}, {5} ", r.RestaurantRanking, r.RestaurantName, r.FavoriteDish, r.RestaurantAddress, r.RestaurantPhone, r.RestaurantWebsite)); // there are several ways to do this
            }
            return View(restaurantList);//pass in the restaurantList array along with the index view
        }

        [HttpGet]
        public IActionResult AddSuggestions()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddSuggestions(SuggestionResponse suggestionResponse)
        {
            SuggestionStorage.AddSuggestion(suggestionResponse);
            return View("SuggestionConfirmation", suggestionResponse); // pass in the object with the model
        }

        //public IActionResult SuggestionList()
        //{
        //  return View(SuggestionStorage.Suggestions.Where(suggestion =>  suggestion.FavoriteDish))
        //}
        [HttpGet]
        public IActionResult SuggestionList() 
        {
            return View(SuggestionStorage.Suggestions); // pass in the suggestions so that there is a model that can be used 
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
