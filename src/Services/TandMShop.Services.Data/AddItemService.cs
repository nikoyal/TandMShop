using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TandMShop.Data.Common.Repositories;
using TandMShop.Data.Models;

namespace TandMShop.Services.Data
{
    public class AddItemService : IAddItemService
    {
        private readonly IDeletableEntityRepository<BedSet> bedsetRepository;
        public AddItemService(IDeletableEntityRepository<BedSet> bedsetRepository)
        {
            this.bedsetRepository = bedsetRepository;
        }
        public async Task<int> AddNewBedSet(string name, string description, string matter, double originalPrice,
            double currentPrice, string picture1, string picture2, string picture3, int review)
        {
            var bedSet = new BedSet
            {
                Name = name,
                Description = description,
                Matter = matter,
                OriginalPrice = originalPrice,
                CurrentPrice = currentPrice,
                Picture1 = picture1,
                Picture2 = picture2,
                Picture3 = picture3,
                Review = review,
            };
            await this.bedsetRepository.AddAsync(bedSet);
            await this.bedsetRepository.SaveChangesAsync();
            return bedSet.Id;
        }
    }
}
