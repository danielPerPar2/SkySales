using SkySales.Common.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SkySales.Web.Services.Utilities
{
    public class StudentMapper
    {
        static StudentWS Map(Student student)
        {
            StudentWS studentWS = new StudentWS()
            {
                StudentId = student.StudentId,
                Name = student.Name,
                Surname = student.Surname,
                Age = student.Age
            };

            return studentWS;
            
        }

        static Student Map(StudentWS student)
        {
            Student studentCommonModels = new Student()
            {
                StudentId = student.StudentId,
                Name = student.Name,
                Surname = student.Surname,
                Age = student.Age
            };

            return studentCommonModels;
        }
    }
}