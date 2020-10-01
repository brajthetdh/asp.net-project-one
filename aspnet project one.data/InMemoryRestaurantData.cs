using aspnet_project_one.core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace aspnet_project_one.data
{
    public class InMemoryRestaurantData : IRestaurantData
    {
        List<Restaurant> restaurants;
        public InMemoryRestaurantData()
        {
            restaurants = new List<Restaurant>()
            {
                new Restaurant {Id=1, Name = "Scott's Pizza", Location="Italy", Cuisine=CuisineType.Italian},
                new Restaurant {Id=2, Name = "Pitt's Pizza", Location="Mexico", Cuisine=CuisineType.Maxican},
                new Restaurant {Id=3, Name = "Bahadur Pizza", Location="India", Cuisine=CuisineType.Indian},

            };
        }

        //public IEnumerable<Restaurant> GetAll()
        //{
        //    return restaurants.OrderBy(r => r.Name);
                   
        //}

        public IEnumerable<Restaurant> GetByName(string name = null)
        {
            return from r in restaurants
                   where string.IsNullOrEmpty(name) || r.Name.StartsWith(name)
                   orderby r.Name
                   select r;
        }
    }
}
