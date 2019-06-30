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
        public StudentWS Add(StudentWS student)
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

        public StudentWS Delete(int id)
        {
            StudentLogic studentLogic = new StudentLogic();
            StudentWS student = new StudentWS();
          //  student = studentLogic.Delete(id);
            return student;
        }

        public List<StudentWS> GetAll()
        {
            StudentLogic studentLogic = new StudentLogic();
            List<StudentWS> students = new List<StudentWS>();
            List<SkySales.Common.Models.Student> studentsList = new List<SkySales.Common.Models.Student>();
            studentsList = studentLogic.GetAll();
            foreach (SkySales.Common.Models.Student student in studentsList)
            {
                StudentWS newStudent = new StudentWS();
                newStudent.StudentId = student.StudentId;
                newStudent.Name = student.Name;
                newStudent.Surname = student.Surname;
                newStudent.Age = student.Age;
                students.Add(newStudent);
            }
            return students;
        }

        public StudentWS GetById(int id)
        {
            StudentLogic studentLogic = new StudentLogic();
           
            SkySales.Common.Models.Student student = new Common.Models.Student();
            student = studentLogic.GetById(id);
            StudentWS newStudent = new StudentWS
            {
                StudentId = student.StudentId,
                Name = student.Name,
                Surname = student.Surname,
                Age = student.Age
            };
            return newStudent;
        }

        public StudentWS Update(StudentWS student)
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
