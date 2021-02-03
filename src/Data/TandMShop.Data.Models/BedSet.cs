using System;
using System.Collections.Generic;
using System.Text;
using TandMShop.Data.Common.Models;

namespace TandMShop.Data.Models
{
    public class BedSet : BaseDeletableModel<int>
    {
        public BedSet()
        {
            this.Comments = new HashSet<Comment>();
        }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Matter { get; set; }
        public double OriginalPrice { get; set; }
        public double CurrentPrice { get; set; }
        public string Picture1 { get; set; }
        public string Picture2 { get; set; }
        public string Picture3 { get; set; }
        public bool OutOfStock { get; set; }
        public int Orders { get; set; }
        public int Review { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }
    }
}
