using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TandMShop.Data.Common.Repositories;
using TandMShop.Data.Models;
using TandMShop.Services.Mapping;

namespace TandMShop.Services.Data
{
    public class BedSetService : IBedSetService
    {
        private readonly IDeletableEntityRepository<BedSet> bedsetRepository;
        public BedSetService(IDeletableEntityRepository<BedSet> bedsetRepository)
        {
            this.bedsetRepository = bedsetRepository;
        }
        public IEnumerable<T> GetAll<T>(string orderBy,int? take = null, int skip = 0)
        {
            IQueryable<BedSet> beds = this.bedsetRepository.All();
            if (orderBy == "Name")
            {
                beds = beds.OrderBy(x => x.Name);
            }
            if (orderBy == "PriceUp")
            {
                beds = beds.OrderByDescending(x => x.CurrentPrice);
            }
            if (orderBy == "")
            {
                beds = beds.OrderBy(x => x.CurrentPrice);
            }
            beds = beds.Skip(skip);
            if (take.HasValue)
            {
                beds = beds.Take(take.Value);
            }
            return beds.To<T>().ToList();
        }

        public int AllCount()
        {
            return this.bedsetRepository.All().Count();
        }

        public T GetById<T>(int id)
        {
            var bedSet = this.bedsetRepository.All().Where(x => x.Id == id)
                .To<T>().FirstOrDefault();
            return bedSet;
        }

        public async Task OutOfStockSwtich(int id)
        {
            var bedset = this.bedsetRepository.All().Where(x => x.Id == id).FirstOrDefault();
            if(bedset.OutOfStock == false)
            {
                this.bedsetRepository.All().Where(x => x.Id == id).FirstOrDefault().OutOfStock = true;
            }
            else
            {
                this.bedsetRepository.All().Where(x => x.Id == id).FirstOrDefault().OutOfStock = false;
            }
            await this.bedsetRepository.SaveChangesAsync();
        }
    }
}
