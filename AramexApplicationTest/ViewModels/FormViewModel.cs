using AramexApplicationTest.Models;
using AramexApplicationTest.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AramexApplicationTest.ViewModels
{
    /// <summary>
    /// IT'S OK TO EDIT THIS FILE
    /// </summary>
    public class FormViewModel
    {
        [Required (ErrorMessage ="You must enter your first Name")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "You must enter your last Name")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "You must enter your email address")]
        public string Email { get; set; }
        [Required(ErrorMessage = "You must select your favourite pet")]
        public int? PetId { get; set; }
        [Required(ErrorMessage = "You must enter your favourite city")]
        public int? CityId { get; set; }
        public List<Pet> Pets => PetService.GetPets();
        public List<City> Cities => CityService.GetCities();
    }
}