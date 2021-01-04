using System;
using System.Collections.Generic;
using System.Text;
using TandMShop.Data.Common.Models;

namespace TandMShop.Data.Models
{
    public class Comment : BaseDeletableModel<int>
    {
        public int BedSetId { get; set; }

        public virtual BedSet BedSet { get; set; }

        public string Content { get; set; }

        public string UserName { get; set; }
    }
}
