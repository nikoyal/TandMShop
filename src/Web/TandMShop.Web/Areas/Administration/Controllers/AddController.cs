using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TandMShop.Web.Areas.Administration.Controllers
{
    public class AddController : Controller
    {
        public IActionResult AddItem()
        {
            return this.View();
        }
    }
}
