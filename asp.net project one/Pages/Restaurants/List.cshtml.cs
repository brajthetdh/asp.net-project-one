using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using aspnet_project_one.core;
using aspnet_project_one.data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;

namespace asp.net_project_one.Pages.Restaurants
{
    public class ListModel : PageModel
    {
        private readonly IConfiguration config;
        private readonly IRestaurantData restaurantData;

        public string Message { get; set; }
        public IEnumerable<Restaurant>  Restaurants { get; set; }
        [BindProperty(SupportsGet =true)]
        public string SearchTerm { get; set; }

        public ListModel(IConfiguration config, IRestaurantData restaurantData)
        {
            this.config = config;
            this.restaurantData = restaurantData;
        }
        public void OnGet(string SearchTerm)
        {
            Message = config["Message"];
            Restaurants = restaurantData.GetByName(SearchTerm);
        }
    }
}
