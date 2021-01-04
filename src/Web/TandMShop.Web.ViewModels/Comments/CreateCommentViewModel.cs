using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace TandMShop.Web.ViewModels.Comments
{
    public class CreateCommentViewModel
    {
        public int BedSetId { get; set; }
        public string UserName { get; set; }
        [Required]
        [StringLength(150)]
        public string Content { get; set; }
    }
}
