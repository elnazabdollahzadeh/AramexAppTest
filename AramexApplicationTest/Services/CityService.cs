using AramexApplicationTest.Models;
using AramexApplicationTest.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AramexApplicationTest.Services
{
    public static class CityService
    {
        public static List<City> GetCities()
        {
            return CityRepository.Cities;
        }

        public static City GetCity(int id)
        {
            return CityRepository.Cities.FirstOrDefault(city => city.Id == id);
        }
    }
}