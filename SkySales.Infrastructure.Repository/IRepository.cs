﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkySales.Infrastructure.Repository
{
    public interface IRepository<T>
    {
        T Add(T model);
        List<T> GetAll();
    }
}
