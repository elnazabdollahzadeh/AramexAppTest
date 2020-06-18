using AramexApplicationTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// YOU SHOULD NOT NEED TO EDIT THIS FILE
/// </summary>
namespace AramexApplicationTest.Repositories
{
    public static class CityRepository
    {
        public static List<City> Cities = new List<City>() {
                new City(1, "Sydney"),
                new City(2, "Melbourne"),
                new City(3, "Brisbane"),
                new City(4, "Perth"),
                new City(5, "Adelaide"),
                new City(6, "Darwin"),
                new City(7, "Hobart"),
                new City(8, "Canberra")
            };
    }
}