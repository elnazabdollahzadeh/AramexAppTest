using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AramexApplicationTest.Models
{
    public class City
    {
        public int Id { get; }
        public string Name { get; }

        public City(int id, string name)
        {
            Id = id;
            Name = name;
        }

        
    }
}