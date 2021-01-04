using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace TandMShop.Services.Data
{
    public interface ICommentService
    {
        Task Create(int bedSetId, string userName, string content);

        IEnumerable<T> GetAll<T>(int bedSetId);
    }
}
