﻿using aspnet_project_one.core;
using System.Collections.Generic;

namespace aspnet_project_one.data
{
    public interface IRestaurantData
    {
        IEnumerable<Restaurant> GetAll();
    }
}
