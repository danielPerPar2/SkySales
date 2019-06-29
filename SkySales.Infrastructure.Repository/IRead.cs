using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkySales.Infrastructure.Repository
{
    public interface IRead<T>
    {
        T GetById(T t);
        List<T> GetAll();
    }
}
