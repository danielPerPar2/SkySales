using Autofac;
using SkySales.Business.Logic;
using SkySales.Common.Models;
using SkySales.Web.Services.WebServiceImp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace SkySales.Web.Services
{
    public static class AutofacContainerBuilder
    {
        public static IContainer BuildContainer()
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<StudentWebService>().As<IStudentWebService>();
            builder.RegisterType<StudentLogic>().As<IBusinessLogic<Student>>();
            builder.RegisterModule<BusinessLogicModule>();

            return builder.Build();
        }
    }
}