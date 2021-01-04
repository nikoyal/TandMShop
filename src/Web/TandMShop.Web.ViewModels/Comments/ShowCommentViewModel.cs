using System;
using System.Collections.Generic;
using System.Text;
using TandMShop.Data.Models;
using TandMShop.Services.Mapping;

namespace TandMShop.Web.ViewModels.Comments
{
    public class ShowCommentViewModel : IMapFrom<Comment>
    {
        public int BedSetId { get; set; }
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Content { get; set; }
    }
}
