using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
        public IEnumerable<T> GetAll<T>()
        {
            IQueryable<BedSet> beds = this.bedsetRepository.All();
            return beds.To<T>().ToList();
        }

        public T GetById<T>(int id)
        {
            var bedSet = this.bedsetRepository.All().Where(x => x.Id == id)
                .To<T>().FirstOrDefault();
            return bedSet;
        }
    }
}
