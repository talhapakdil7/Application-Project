using BtkAcademyApp.Models;
using Microsoft.AspNetCore.Mvc;
namespace BtkAcademyApp.Controllers
{

    public class CourseController : Controller
    {

        public IActionResult Index()
        {
            var model = Repository.Applications;

            return View("Index",model);

        }
      [HttpGet]
       public IActionResult Apply()
        {

            return View();

        }



        [HttpPost]
        public IActionResult Apply([FromForm] Candidate model)
        {
            if (Repository.Applications.Any(c => c.Email.Equals(model.Email)))
            {
                ModelState.AddModelError("", "there is already application");
            }

               if (ModelState.IsValid)
                {
                    Repository.Add(model);

                    return View("Feedback", model);

                }
                else
                {
                    return View();
                }
        }
    }
}