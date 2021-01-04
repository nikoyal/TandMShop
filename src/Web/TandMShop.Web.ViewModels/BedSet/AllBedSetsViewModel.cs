using System;
using System.Collections.Generic;
using System.Text;

namespace TandMShop.Web.ViewModels.BedSet
{
    public class AllBedSetsViewModel
    {
        public IEnumerable<BedSetByIdViewModel> Beds { get; set; }
    }
}
