using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SkySales.Common.Models;
using SkySales.Infrastructure.Repository;

namespace SkySales.Business.Logic
{
    public class StudentLogic : IBusinessLogic<Student>
    {
        private static readonly log4net.ILog log =
            log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        private IRepository<Student> studentRepository;

        public StudentLogic(IRepository<Student> studentRepository)
        {
            log.Debug("Dentro de StudentLogic");
            if(studentRepository == null)
            {
                string message = "studentRepository is null";
                log.Error(message);
                throw new NullReferenceException(message);
            }
            this.studentRepository = studentRepository;
        }

        public Student Add(Student student)
        {
           Student newStudent = studentRepository.Add(student);
            return newStudent;
        }

        public Student Delete(int id)
        {
            Student student = new Student();
            student = studentRepository.Delete(id);
            return student;
        }

        public List<Student> GetAll()
        {
            List<Student> studentsList = new List<Student>();
            studentsList = studentRepository.GetAll();
            return studentsList;
        }

        public Student GetById(int id)
        {
            Student student = new Student();
            student = studentRepository.GetById(id);
            return student;
        }

        public Student Update(Student student)
        {
            student = studentRepository.Update(student);
            return student;
        }
    }
}
