using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace TandMShop.Services.Data
{
    public interface IAddItemService
    {
        Task<int> AddNewBedSet(string name, string description, string matter, double originalPrice,
            double currentPrice, string picture1, string picture2, string picture3, int review);
    }
}
