using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace SkySales.Web.Services
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IStudentWebService
    {
        [OperationContract]
        Student Add(Student student);

        [OperationContract]
        Student GetById(int id);

        [OperationContract]
        List<Student> GetAll();

        [OperationContract]
        Student Update(Student student);

        [OperationContract]
        Student Delete(int id);      
    }

    [DataContract]
    public class Student
    {
        public Student() { }
        public Student(int id, string name, string surname, int age)
        {
            StudentId = id;
            Name = name;
            Surname = surname;
            Age = age;
        }

        [DataMember]
        public int StudentId{ get; set; }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public string Surname { get; set; }

        [DataMember]
        public int Age { get; set; }
    }
}
