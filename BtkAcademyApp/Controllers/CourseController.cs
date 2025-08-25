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
      
       public IActionResult Apply()
        {

            return View();

        }



        [HttpPost]

        public IActionResult Apply([FromForm] Candidate model)
        {

            Repository.Add(model);

            return View("Feedback",model);
            

        }
      


    }




}