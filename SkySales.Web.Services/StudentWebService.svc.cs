using SkySales.Business.Logic;
using SkySales.Common.Models;
using SkySales.Web.Services.Utilities;
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

        private IMapper<Student, StudentWS> mapper = new StudentMapper();

        public StudentWS Add(StudentWS student)
        {
            StudentLogic studentLogic = new StudentLogic();
            Student studentCommonModels = mapper.Map(student);           
            Student insertedStudent = studentLogic.Add(studentCommonModels);
            StudentWS studentWS = mapper.Map(insertedStudent);   
            return studentWS;
        }

        public StudentWS Delete(int id)
        {
            StudentLogic studentLogic = new StudentLogic();
            Student studentCommonModels = studentLogic.Delete(id);
            StudentWS studentWS = mapper.Map(studentCommonModels);         
            return studentWS;
        }

        public List<StudentWS> GetAll()
        {
            StudentLogic studentLogic = new StudentLogic();         
            List<Student> studentsList = studentLogic.GetAll();
            List<StudentWS> studentsWS = mapper.Map(studentsList);
            return studentsWS;
        }

        public StudentWS GetById(int id)
        {
            StudentLogic studentLogic = new StudentLogic();                     
            Student student = studentLogic.GetById(id);
            StudentWS studentWS = mapper.Map(student);
            return studentWS;
        }

        public StudentWS Update(StudentWS student)
        {
            StudentLogic studentLogic = new StudentLogic();
            Student studentToInsert = mapper.Map(student);
            Student insertedStudent = studentLogic.Update(studentToInsert);
            StudentWS insertedStudentWS = mapper.Map(insertedStudent);                
            return insertedStudentWS;
        }
    }
}
