using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.Mvc;
using System.Web.UI.WebControls;
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

        public ActionResult Index(StudentModel model, string order)
        {
            ServiceReference.StudentWebServiceClient sc = new ServiceReference.StudentWebServiceClient();
            enumCommand command =(enumCommand)Enum.Parse(typeof(enumCommand), order);
            if (command == enumCommand.Add)
            {
                ServiceReference.Student newStudent;
                ServiceReference.Student student = new ServiceReference.Student
                {
                    StudentId = model.StudentID,
                    Name = model.Name,
                    Surname = model.Surname,
                    Age = model.Age
                };
               newStudent= sc.Add(student);
                if(newStudent != null)
                {
                    model.Resutl = WebConfigurationManager.AppSettings["Add"];
                }
                else
                {
                    model.Resutl = WebConfigurationManager.AppSettings["Error"];
                }

            }

            if (command == enumCommand.Update)
            {
                ServiceReference.Student newStudent;
                SkySales.Presentation.Web.ServiceReference.Student student = new ServiceReference.Student
                {
                    StudentId = model.StudentID,
                    Name = model.Name,
                    Surname = model.Surname,
                    Age = model.Age
                };
              newStudent=  sc.Update(student);
                if (newStudent != null)
                {
                    model.Resutl = WebConfigurationManager.AppSettings["Update"];
                }
                else
                {
                    model.Resutl = WebConfigurationManager.AppSettings["Error"];
                }

            }

            if (command == enumCommand.Delete)
            {
                ServiceReference.Student student;
             student=  sc.Delete(model.StudentID);
                if (student != null)
                {
                    model.Resutl = WebConfigurationManager.AppSettings["Delete"];
                }
                else
                {
                    model.Resutl= WebConfigurationManager.AppSettings["Error"];
                }

            }

            if (command == enumCommand.GetById)
            {

              SkySales.Presentation.Web.ServiceReference.Student student=  sc.GetById(model.StudentID);
                if (student != null)
                {
                    model.Resutl = WebConfigurationManager.AppSettings["GetById"];
                    model = student;
                }
                else
                {
                    model.Resutl = WebConfigurationManager.AppSettings["Error"];
                }
            }

            if (command == enumCommand.GetAll)
            {
                ServiceReference.Student[] students;
                students = sc.GetAll();
                ListBox listBox = new ListBox();
                
            }

            return View(model);

        }
    }
}