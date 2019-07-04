using Autofac;
using SkySales.Business.Logic;
using SkySales.Common.Models;
using SkySales.Infrastructure.Repository;
using SkySales.Web.Services;
using SkySales.Web.Services.WebServiceImp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkysalesIntegrationTests.Modules
{
    public class TestModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<StudentLogic>().As<IBusinessLogic<Student>>();
            builder.RegisterType<StudentRepository>().As<IRepository<Student>>();
            
            //Ojo!! el service no se registra como tipo de interfaz, vamos a usar namespace.clase
            builder.RegisterType<StudentsServiceReference.StudentWebServiceClient>();
        }
    }
}
