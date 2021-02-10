using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TopRestaurantsProvo.Models
{
    public static class SuggestionStorage
    {
        private static List<SuggestionResponse> suggestions = new List<SuggestionResponse>(); //This sets up the list to store the suggestions

        public static IEnumerable<SuggestionResponse> Suggestions => suggestions;

        public static void AddSuggestion(SuggestionResponse suggestion) //adds an instance of a suggestion
        {
            suggestions.Add(suggestion);
        }
    }
}
