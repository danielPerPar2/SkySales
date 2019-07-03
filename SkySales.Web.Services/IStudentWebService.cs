using SkySales.Common.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace SkySales.Web.Services
{
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
}
