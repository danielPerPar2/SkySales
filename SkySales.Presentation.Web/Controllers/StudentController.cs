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
            ServiceReference.StudentWebServiceClient sc = new ServiceReference.StudentWebServiceClient();
            if (Operacion == "Add")
            {
                SkySales.Presentation.Web.ServiceReference.Student student = new SkySales.Presentation.Web.ServiceReference.Student
                {
                    StudentId = model.StudentID,
                    Name = model.Name,
                    Surname = model.Surname,
                    Age = model.Age
                };
                sc.Add(student);

            }

            if (Operacion == "Update")
            {

                SkySales.Presentation.Web.ServiceReference.Student student = new SkySales.Presentation.Web.ServiceReference.Student
                {
                    StudentId = model.StudentID,
                    Name = model.Name,
                    Surname = model.Surname,
                    Age = model.Age
                };
                sc.Update(student);

            }

            if (Operacion == "Delete")
            {

               sc.Delete(model.StudentID);

            }

            if (Operacion == "GetByID")
            {

              SkySales.Presentation.Web.ServiceReference.Student student=  sc.GetById(model.StudentID);
                
            }

            if (Operacion == "GetAll")
            {

            }

            return View(model);

        }
    }
}