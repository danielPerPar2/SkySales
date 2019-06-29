using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkySales.Infrastructure.Repository
{
    public interface IRead<T>
    {
        T GetById(int id);
        List<T> GetAll();
    }
}
