
using Data;
using Data.Entities.VenichleInfo;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class AccountController : Controller
    {
        public AuctionDBContext context = new();

        private void LoadBrands()
        {
            ViewBag.Brands = new SelectList(context.Brands.ToList(), "Id", "Name");
        }
        private void LoadTransmissions()
        {
            ViewBag.Transmissions = new SelectList(context.Transmissions.ToList(), "Id", "Name");
        }

        [HttpGet]
        public IActionResult SellCar()
        {
            LoadBrands();
            LoadTransmissions();

            return View();
        }


        [HttpPost]
        public IActionResult SellCar(Venichle venichle)
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
