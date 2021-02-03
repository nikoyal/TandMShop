using System;
using System.Collections.Generic;
using System.Text;

namespace TandMShop.Web.ViewModels.BedSet
{
    public class AllBedSetsViewModel
    {
        public IEnumerable<BedSetByIdViewModel> Beds { get; set; }

        public int PagesCount { get; set; }

        public int CurrentPage { get; set; }
    }
}
