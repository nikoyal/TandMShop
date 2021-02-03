using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace TandMShop.Services.Data
{
    public interface IBedSetService
    {
        IEnumerable<T> GetAll<T>(string orderBy, int? take, int skip);

        int AllCount();

        T GetById<T>(int id);

        Task OutOfStockSwtich(int id);
    }
}
