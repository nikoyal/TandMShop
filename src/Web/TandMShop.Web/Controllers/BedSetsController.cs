using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TandMShop.Services.Data;
using TandMShop.Web.ViewModels.BedSet;
using TandMShop.Web.ViewModels.Comments;

namespace TandMShop.Web.Controllers
{
    public class BedSetsController : BaseController
    {
        private readonly IBedSetService bedSetService;
        private readonly IAddItemService addItemService;
        private readonly ICommentService commentService;
        public BedSetsController(IBedSetService bedSetService, IAddItemService addItemService, ICommentService commentService)
        {
            this.commentService = commentService;
            this.bedSetService = bedSetService;
            this.addItemService = addItemService;
        }
        public IActionResult ViewAll()
        {
            var viewModel = new AllBedSetsViewModel();
            var bedSets = this.bedSetService.GetAll<BedSetByIdViewModel>();
            viewModel.Beds = bedSets;
            return this.View(viewModel);
        }
        public ActionResult ViewallPartial(string orderBy)
        {
            var viewModel = new AllBedSetsViewModel();
            var bedSets = this.bedSetService.GetAll<BedSetByIdViewModel>();
            if (orderBy == "Name")
            {
                bedSets = bedSets.OrderBy(x => x.Name);
            }
            if (orderBy == "PriceUp")
            {
                bedSets = bedSets.OrderByDescending(x => x.CurrentPrice);
            }
            if (orderBy == "PriceDown")
            {
                bedSets = bedSets.OrderBy(x => x.CurrentPrice);
            }
            viewModel.Beds = bedSets;
            return this.PartialView(viewModel);
        }

        public IActionResult ById(int id)
        {
            var viewModel = this.bedSetService.GetById<BedSetByIdViewModel>(id);

            return this.View(viewModel);
        }

        public IActionResult ShowComments(int bedSetId)
        {
            var viewModel = new AllCommentsViewModel();
            viewModel.Comments = this.commentService.GetAll<ShowCommentViewModel>(bedSetId);
            return this.PartialView(viewModel);
        }
    }
}
