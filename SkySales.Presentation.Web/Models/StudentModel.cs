using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SkySales.Presentation.Web.ServiceReference;

namespace SkySales.Presentation.Web.Models
{
    public class StudentModel
    {
        public int StudentID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public String Resutl { get; set; }

        public static implicit operator StudentModel(Student v)
        {
            StudentModel model = new StudentModel();
            model.StudentID = v.StudentId;
            model.Name = v.Name;
            model.Surname = v.Surname;
            model.Age = v.Age;

            return model;
        }
    }
}