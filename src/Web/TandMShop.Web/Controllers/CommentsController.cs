using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TandMShop.Services.Data;
using TandMShop.Web.ViewModels.Comments;

namespace TandMShop.Web.Controllers
{
    public class CommentsController : Controller
    {
        private readonly ICommentService commentService;
        public CommentsController(ICommentService commentService)
        {
            this.commentService = commentService;
        }
        public async Task<IActionResult> AddComment(CreateCommentViewModel input)
        {
            if (!this.ModelState.IsValid)
            {
                return this.View();
            }
            await this.commentService.Create(input.BedSetId, input.UserName, input.Content);
            return this.RedirectToAction("ShowComments", "BedSets");
        }
    }
}
