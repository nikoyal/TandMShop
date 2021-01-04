using System;
using System.Collections.Generic;
using System.Text;

namespace TandMShop.Web.ViewModels.Comments
{
    public class AllCommentsViewModel
    {
        public IEnumerable<ShowCommentViewModel> Comments { get; set; }
    }
}
