using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SkySales.Presentation.Web.Models;

namespace SkySales.Presentation.Web.Controllers
{
    public class StudentController : Controller
    {
        [HttpGet]
        // GET: Student
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]

        public ActionResult Index(StudentModel model, string Operacion)
        {
            ReferenciaWeb.Service1Client sc = new ReferenciaWeb.Service1Client();
            if (Operacion == "Suma")
            {

                model.result = sc.Suma(model.num1, model.num2);

            }

            if (Operacion == "Resta")
            {

                model.result = sc.Rest(model.num1, model.num2);

            }

            if (Operacion == "Multiplicacion")
            {

                model.result = sc.Multiplicacion(model.num1, model.num2);

            }

            if (Operacion == "Division")
            {

                model.result = sc.Divison(model.num1, model.num2);

            }

            return View(model);

        }
    }
}