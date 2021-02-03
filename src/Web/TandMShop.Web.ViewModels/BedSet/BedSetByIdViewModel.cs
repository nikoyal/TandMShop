using System;
using System.Collections.Generic;
using System.Text;
using TandMShop.Services.Mapping;
using TandMShop.Data.Models;
using TandMShop.Web.ViewModels.Comments;

namespace TandMShop.Web.ViewModels.BedSet
{
    public class BedSetByIdViewModel : IMapFrom<TandMShop.Data.Models.BedSet>, IMapTo<TandMShop.Data.Models.BedSet>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Matter { get; set; }
        public double OriginalPrice { get; set; }
        public double CurrentPrice { get; set; }
        public string Picture1 { get; set; }
        public string Picture2 { get; set; }
        public string Picture3 { get; set; }
        public int Review { get; set; }
        public bool OutOfStock { get; set; }
        public IEnumerable<ShowCommentViewModel> Comments { get; set; }
    }
}
