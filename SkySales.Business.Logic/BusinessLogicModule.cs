using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac;
using SkySales.Common.Models;
using SkySales.Infrastructure.Repository;

namespace SkySales.Business.Logic
{
    public class BusinessLogicModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<StudentRepository>().As<IRepository<Student>>();
        }
    }
}
