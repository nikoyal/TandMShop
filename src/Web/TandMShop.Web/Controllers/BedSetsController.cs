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
        private const int itemsPerPage = 18;
        private readonly IBedSetService bedSetService;
        private readonly IAddItemService addItemService;
        private readonly ICommentService commentService;
        public BedSetsController(IBedSetService bedSetService, IAddItemService addItemService, ICommentService commentService)
        {
            this.commentService = commentService;
            this.bedSetService = bedSetService;
            this.addItemService = addItemService;
        }
        public IActionResult ViewAll(string orderBy = "" ,int page = 1)
        {
            var viewModel = new AllBedSetsViewModel();
            var bedSets = this.bedSetService.GetAll<BedSetByIdViewModel>(orderBy,itemsPerPage, (page - 1) * itemsPerPage);
            viewModel.PagesCount = (int)Math.Ceiling((double)this.bedSetService.AllCount() / itemsPerPage);
            viewModel.CurrentPage = page;
            viewModel.Beds = bedSets;
            return this.View(viewModel);
        }
        public ActionResult ViewallPartial(string orderBy, int page = 1)
        {
            var viewModel = new AllBedSetsViewModel();
            var bedSets = this.bedSetService.GetAll<BedSetByIdViewModel>(orderBy,itemsPerPage, (page - 1) * itemsPerPage);
            viewModel.PagesCount = (int)Math.Ceiling((double)this.bedSetService.AllCount() / itemsPerPage);
            viewModel.CurrentPage = page;
            viewModel.Beds = bedSets;
            return this.PartialView(viewModel);
        }

        public IActionResult ById(int id)
        {
            var viewModel = this.bedSetService.GetById<BedSetByIdViewModel>(id);

            return this.View(viewModel);
        }

        public async Task<IActionResult> OutOfStock(int id)
        {

            await   this.bedSetService.OutOfStockSwtich(id);
            return this.RedirectToAction("ById", "BedSets", new { id = id });
        }

    }
}
