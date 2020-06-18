using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AramexApplicationTest.Models
{
    public class Pet
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Pet(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}