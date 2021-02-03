using System;
using System.Collections.Generic;
using System.Text;

namespace TandMShop.Web.ViewModels.Orders
{
    public class CreateOrderViewModel
    {
        public int ProductId { get; set; }

        public string Adress { get; set; }

        public string Name { get; set; }

        public string Telephone { get; set; }

        public string Email { get; set; }
    }
}
