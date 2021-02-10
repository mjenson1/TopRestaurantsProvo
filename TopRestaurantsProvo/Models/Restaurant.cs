using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace TopRestaurantsProvo.Models
{
    public class Restaurant
    {
        //[Required]
        public Restaurant(int rank)
        {
           RestaurantRanking = rank;//making it a read only property 
        }
        [Required]
        public int? RestaurantRanking { get;  } // setting as default value, property initializer, can't be changed
        [Required]
        public string RestaurantName { get; set; }
        [Required]
        public string RestaurantAddress { get; set; }
        #nullable enable
        public string? FavoriteDish { get; set; } = "It's all tasty!"; // if left null this is added
        
        [RegularExpression(@"\(?\d{3}\)?-? *\d{3}-? *-?\d{4}",
         ErrorMessage = "Phone number must be in valid format.")] //validation for the phone
        public string? RestaurantPhone { get; set; }
        public string? RestaurantWebsite { get; set; } = "Coming soon."; //if left blank this is added
      

        public static Restaurant[] GetRestaurants()
        {
            Restaurant r1 = new Restaurant(1)
            {
                //RestaurantRanking = 1,
                RestaurantName = "Cafe Rio",
                FavoriteDish = "Sweet Pork Salad",
                RestaurantAddress = "1122 S University Ave",
                RestaurantPhone = "(801) 882-7995",
                RestaurantWebsite = "caferio.com"
            };

            Restaurant r2 = new Restaurant(2)
            {
                //RestaurantRanking = 2,
                RestaurantName = "Costa Vida",
                FavoriteDish = "Sweet Pork Salad",
                RestaurantAddress = "1200 N University Ave",
                RestaurantPhone = "(801) 373-1876",
                RestaurantWebsite = "costavida.com"
            };

            Restaurant r3 = new Restaurant(3)
            {
                //RestaurantRanking = 3,
                RestaurantName = "Cafe Zupas",
                FavoriteDish = "Chicken Avocado Sandwich",
                RestaurantAddress = "408 W 2230 N",
                RestaurantPhone = "(801) 377-7687",
                RestaurantWebsite = "cafezupas.com"
            };

            Restaurant r4 = new Restaurant(4)
            {
                //RestaurantRanking = 4,
                RestaurantName = "In-N-Out Burger",
                FavoriteDish = "Double-Double",
                RestaurantAddress = "350 E University Pkwy",
                RestaurantPhone = "(801) 786-1000",
                RestaurantWebsite = "in-n-out.com"
            };
            
            Restaurant r5 = new Restaurant(5)
            {
                //RestaurantRanking = 5,
                RestaurantName = "Guru's Cafe",
                //FavoriteDish = "Sweet Potato Fries",
                RestaurantAddress = "350 E University Pkwy",
                RestaurantPhone = "(801) 786-1000",
                //RestaurantWebsite = "guruscafe.com"
            };

            return new Restaurant[] { r1, r2, r3, r4, r5 }; //be sure to add the array each time
        }
    }
}
