using System;
using System.Collections.Generic;
using System.Web;
using System.Web.Mvc;
using TestIocDi.Service;



namespace TestIocDi.Controllers
{
    public class PersonController : Controller
    {
        private readonly PersonService _personService;

        public PersonController(PersonService bookService)
        {
            _personService = bookService;
        }

        public ActionResult Index()
        {
            var people = _personService.GetAllPerson();
            ViewBag.PeopleFromFile = TempData["PeopleFromFile"] as List<PersonViewModel>;
            if (TempData["Error"] != null)
            {
                ViewBag.ErrorMessage = TempData["Error"]; // Отображает сообщение об ошибке в представлении
            }
            return View(people);
        }

        [HttpPost]
        public ActionResult ParseFile(HttpPostedFileBase file)
        {
            string filePath = Server.MapPath("~/App_Data/" + file.FileName);
            file.SaveAs(filePath);
            try
            {
                List<PersonViewModel> peopleFromFiles = _personService.GetPersonsFromTextFile(filePath);
                TempData["PeopleFromFile"] = peopleFromFiles;
            }
            catch (Exception ex)
            {
                TempData["Error"] = "Ошибка при обработке файла";
            }
            return RedirectToAction("Index");
        }
    }
}