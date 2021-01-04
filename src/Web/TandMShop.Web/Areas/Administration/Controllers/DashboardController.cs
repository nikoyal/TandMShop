namespace TandMShop.Web.Areas.Administration.Controllers
{
    using TandMShop.Services.Data;
    using TandMShop.Web.ViewModels.Administration.Dashboard;

    using Microsoft.AspNetCore.Mvc;
    using TandMShop.Web.ViewModels.BedSet;
    using Microsoft.AspNetCore.Authorization;
    using System.Threading.Tasks;

    public class DashboardController : AdministrationController
    {
        private readonly IAddItemService addItemService;
        public DashboardController(IAddItemService addItemService)
        {
            this.addItemService = addItemService;
        }
        [Authorize]
        public IActionResult Index()
        {
            return this.View();
        }
        [Authorize]
        public IActionResult AddBedSet()
        {
            var viewModel = new AddBedSetViewModel();
            return this.View(viewModel);
        }
        [HttpPost]
        [Authorize]
        public async Task<IActionResult> AddBedSet(AddBedSetViewModel input)
        {
            if (!this.ModelState.IsValid)
            {
                return this.View(input);
            }
            var postId = await this.addItemService.AddNewBedSet(input.Name, input.Description, input.Matter, input.OriginalPrice, input.CurrentPrice,
                input.Picture1, input.Picture2, input.Picture3, input.Review);
            return this.RedirectToAction("ById", "Bedsets", new { id = postId, are = string.Empty });
        }
    }
}
