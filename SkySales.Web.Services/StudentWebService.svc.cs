using SkySales.Business.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;


namespace SkySales.Web.Services
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class StudentWebService : IStudentWebService
    {
        //Business object del student
        //private IStudentBO studentBO = new StudentBO();
        public Student Add(Student student)
        {
            StudentLogic studentLogic = new StudentLogic();
            SkySales.Common.Models.Student insertedStudent = new Common.Models.Student()
            {
                StudentId = student.StudentId,
                Name = student.Name,
                Surname = student.Surname,
                Age = student.Age
            };
            insertedStudent = studentLogic.Add(insertedStudent);

            student.StudentId = insertedStudent.StudentId;
            student.Name = insertedStudent.Name;
            student.Surname = insertedStudent.Surname;
            student.Age = insertedStudent.Age;
            return student;
        }

        public Student Delete(int id)
        {
            StudentLogic studentLogic = new StudentLogic();
            Student student = new Student();
          //  student = studentLogic.Delete(id);
            return student;
        }

        public List<Student> GetAll()
        {
            StudentLogic studentLogic = new StudentLogic();
            List<Student> students = new List<Student>();
            List<SkySales.Common.Models.Student> studentsList = new List<SkySales.Common.Models.Student>();
            studentsList = studentLogic.GetAll();
            foreach (SkySales.Common.Models.Student student in studentsList)
            {
                Student newStudent = new Student();
                newStudent.StudentId = student.StudentId;
                newStudent.Name = student.Name;
                newStudent.Surname = student.Surname;
                newStudent.Age = student.Age;
                students.Add(newStudent);
            }
            return students;
        }

        public Student GetById(int id)
        {
            StudentLogic studentLogic = new StudentLogic();
           
            SkySales.Common.Models.Student student = new Common.Models.Student();
            student = studentLogic.GetById(id);
            Student newStudent = new Student
            {
                StudentId = student.StudentId,
                Name = student.Name,
                Surname = student.Surname,
                Age = student.Age
            };
            return newStudent;
        }

        public Student Update(Student student)
        {
            StudentLogic studentLogic = new StudentLogic();
            SkySales.Common.Models.Student insertedStudent = new Common.Models.Student()
            {
                StudentId = student.StudentId,
                Name = student.Name,
                Surname = student.Surname,
                Age = student.Age
            };
            insertedStudent = studentLogic.Update(insertedStudent);

            student.StudentId = insertedStudent.StudentId;
            student.Name = insertedStudent.Name;
            student.Surname = insertedStudent.Surname;
            student.Age = insertedStudent.Age;
           
            return student;
        }
    }
}
