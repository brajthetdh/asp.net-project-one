using aspnet_project_one.core;
using System.Collections.Generic;

namespace aspnet_project_one.data
{
    public interface IRestaurantData
    {
        IEnumerable<Restaurant> GetAll();
        IEnumerable<Restaurant> GetByName(string name);
        Restaurant GetById(int id);
        Restaurant Add(Restaurant newRestaurant);
        Restaurant Update(Restaurant updateRestaurant);
        int Commit();
    }
}
