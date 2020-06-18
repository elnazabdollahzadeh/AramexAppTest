using AramexApplicationTest.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AramexApplicationTest.Controllers
{
    public class FormController : Controller
    {
        /// <summary>
        /// YOU SHOULD NOT NEED TO CHANGE THIS ACTION METHOD TO COMPLETE THIS TEST
        /// CREATE ONE NEW ACTION METHOD TO PROCESS THE FORM WHEN IT IS POSTED TO THE CONTROLLER
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public ActionResult Index()
        {
            return View(new FormViewModel());
        }
        public ActionResult Completed(FormViewModel form)
        {
            if (ModelState.IsValid)
            {
                return View(new FormCompletedViewModel()
                {
                    City = form.Cities.Where(c => c.Id == form.CityId.GetValueOrDefault()).FirstOrDefault(),
                    Email = form.Email,
                    FirstName = form.FirstName,
                    LastName = form.LastName,
                    Pet = form.Pets.Where(p => p.Id == form.PetId.GetValueOrDefault()).FirstOrDefault()
                });

            }
            return View(new FormViewModel());
        }
    }
}