using SkySales.Business.Logic;
using SkySales.Common.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SkySales.Web.Services.WebServiceImp
{
    public class StudentWebService : IStudentWebService
    {
        private static readonly log4net.ILog log =
            log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        private IBusinessLogic<Student> studentBusinessObject;

        public StudentWebService(IBusinessLogic<Student> studentBusinesObject)
        {
            log.Debug("dentro del StudentWebService");

            if(studentBusinesObject == null)
            {
                string message = "businessObject is null";
                log.Error(message);
                throw new NullReferenceException(message);
            }
            this.studentBusinessObject = studentBusinesObject;
        }
      
        public Student Add(Student student)
        {                      
            Student insertedStudent = studentBusinessObject.Add(student);           
            return insertedStudent;
        }

        public Student Delete(int id)
        {          
            Student deletedStudent = studentBusinessObject.Delete(id);           
            return deletedStudent;
        }

        public List<Student> GetAll()
        {           
            List<Student> studentsList = studentBusinessObject.GetAll();           
            return studentsList;
        }

        public Student GetById(int id)
        {       
            Student student = studentBusinessObject.GetById(id);           
            return student;
        }

        public Student Update(Student student)
        {            
            Student insertedStudent = studentBusinessObject.Update(student);            
            return insertedStudent;
        }
    }
}