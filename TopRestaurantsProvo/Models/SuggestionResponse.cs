using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace TopRestaurantsProvo.Models
{
    public class SuggestionResponse
    {
        public string CustName { get; set; }
        public string RestName { get; set; }
        public string FaveDish { get; set; }
        public string Suggestion { get; set; }
        
        [RegularExpression(@"\(?\d{3}\)?-? *\d{3}-? *-?\d{4}",
         ErrorMessage = "Phone number must be in valid format.")] //I don't think this works actually but there is code in the view that does
        public string RestPhone { get; set; }
        

    }
}
