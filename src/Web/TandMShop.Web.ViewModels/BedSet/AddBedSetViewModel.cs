using System;
using System.Collections.Generic;
using System.Text;

namespace TandMShop.Web.ViewModels.BedSet
{
    public class AddBedSetViewModel
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Matter { get; set; }
        public double OriginalPrice { get; set; }
        public double CurrentPrice { get; set; }
        public string Picture1 { get; set; }
        public string Picture2 { get; set; }
        public string Picture3 { get; set; }
        public int Orders { get; set; }
        public int Review { get; set; }
    }
}
