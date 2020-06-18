using AramexApplicationTest.Models;
using AramexApplicationTest.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AramexApplicationTest.Services
{
    public static class PetService
    {
        public static List<Pet> GetPets()
        {
            return PetRepository.Pets;
        }

        public static Pet GetPet(int id)
        {
            return PetRepository.Pets.FirstOrDefault(pet => pet.Id == id);
        }
    }
}