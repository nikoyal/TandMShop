using System;
using System.Collections.Generic;
using System.Text;

namespace TandMShop.Services.Data
{
    public interface IBedSetService
    {
        IEnumerable<T> GetAll<T>();

        T GetById<T>(int id);
    }
}
