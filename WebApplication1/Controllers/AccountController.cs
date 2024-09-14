
using Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class AccountController : Controller
    {
        public AuctionDBContext context = new();
        public IActionResult SellCar()
        {

            return View();
        }

        public IActionResult MyCars()
        {
            var venichles = context.Venichles.Include(x =>x.Brand).Include(x => x.Model).Where(x => x.OwnerId == 1).ToList();

            return View(venichles);
        }

    }
}
