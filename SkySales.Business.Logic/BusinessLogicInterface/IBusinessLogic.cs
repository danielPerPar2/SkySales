using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkySales.Business.Logic
{
    public interface IBusinessLogic<T>
    {
        T Add(T t);
        T Delete(int id);
        List<T> GetAll();
        T GetById(int id);
        T Update(T t);      
    }
}
