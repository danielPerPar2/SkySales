using SkySales.Common.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SkySales.Web.Services.Utilities
{
    public class StudentMapper : IMapper<Student, StudentWS>
    {         
        public StudentWS Map(Student student)
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

        public List<StudentWS> Map(List<Student> students)
        {
            List<StudentWS> listStudentWS = new List<StudentWS>(students.Count);
            foreach(var student in students)
            {
                listStudentWS.Add(new StudentWS(student.StudentId, student.Name, student.Surname, student.Age));
            }
            return listStudentWS;
        }

        public Student Map(StudentWS student)
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

        public List<Student> Map(List<StudentWS> students)
        {
            List<Student> listStudent = new List<Student>(students.Count);
            foreach(var student in students)
            {
                listStudent.Add(new Student(student.StudentId, student.Name, student.Surname, student.Age));
            }
            return listStudent;
        }
    }
}