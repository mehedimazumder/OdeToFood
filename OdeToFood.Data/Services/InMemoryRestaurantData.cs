using OdeToFood.Data.Models;
using System.Collections.Generic;
using System.Linq;

namespace OdeToFood.Data.Services
{
    public class InMemoryRestaurantData : IRestaurant
    {
        List<Restaurant> restaurents;
        public InMemoryRestaurantData()
        {
            restaurents = new List<Restaurant>
            {
                new Restaurant {Id=1, Name="Bacha Baba", Cuisine= CuisineType.None},
                new Restaurant {Id=1, Name="North Canteen", Cuisine= CuisineType.Indian},
                new Restaurant {Id=1, Name="Kashem Rupali", Cuisine= CuisineType.French}
            };
        }
        public IEnumerable<Restaurant> GetAll()
        {
            return restaurents.OrderBy(r => r.Name);
        }
    }
}
