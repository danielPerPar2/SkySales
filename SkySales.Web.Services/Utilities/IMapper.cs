using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkySales.Web.Services.Utilities
{
   public interface IMapper<T,W>
   {
        W Map(T t);
        List<W> Map(List<T> t);
        T Map(W w);
        List<T> Map(List<W> w);        
    }
}
