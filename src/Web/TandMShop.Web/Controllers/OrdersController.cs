using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;
using TandMShop.Services.Data;
using TandMShop.Web.ViewModels.BedSet;
using TandMShop.Web.ViewModels.Orders;

namespace TandMShop.Web.Controllers
{
    public class OrdersController : Controller
    {
        private readonly IBedSetService bedSetService;

        public OrdersController(IBedSetService bedSetService)
        {
            this.bedSetService = bedSetService;
        }

        public IActionResult OneClickOrder()
        {
            return this.View();
        }
        [HttpPost]
        public IActionResult OneClickOrder(CreateOrderViewModel input)
        {
            var receiverEmail = new MailAddress("tnmmarket@gmail.com", "Receiver");
            var senderEmail = new MailAddress("tnmmarket@gmail.com", "Sender");
            var password = "vUCAMrHcXvqnA6r";
            var sub = "Поръчка: " + input.Name;
            var body = "Имена: " + input.Name + " Адрес: " + input.Adress + " Телефон: " + input.Telephone + " Имейл: " + input.Email;
            var smtp = new SmtpClient
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(senderEmail.Address, password),
            };
            using (var mess = new MailMessage("tnmmarket@gmail.com", "tnmmarket@gmail.com")
            {
                Subject = sub,
                Body = body,
            })
            {
                
               smtp.Send(mess);
            }
            return this.RedirectToAction("ById", "BedSets", new { id = input.ProductId });
        }
    }
}
