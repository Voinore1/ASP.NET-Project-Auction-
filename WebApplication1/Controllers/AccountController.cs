
using Data;
using Data.Entities;
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
        private void LoadBodyStyles()
        {
            ViewBag.BodyStyles = new SelectList(context.BodyStyles.ToList(), "Id", "Style");
        }
        private void LoadFuelTypes()
        {
            ViewBag.FuelTypes = new SelectList(context.FuelTypes.ToList(), "Id", "Name");
        }
        private void LoadAll() 
        {
            ViewBag.Colors = new SelectList(new string[] { "Red", "Blue", "Green", "Black", "White", "Yellow", "Orange", "Purple", "Pink", "Brown", "Grey", "Silver", "Gold", "Beige", "Other" });
            LoadBrands();
            LoadTransmissions();
            LoadBodyStyles();
            LoadFuelTypes();
        }
        [HttpGet]
        public IActionResult SellCar()
        {
            LoadAll();

            return View();
        }


        [HttpPost]
        public IActionResult SellCar(Auction model)
        {
            if (!ModelState.IsValid)
            {
                LoadAll();
                return View(model);
            }

            context.Auctions.Add(model);
            context.SaveChanges();

            return RedirectToAction("Index", "Home");
        }

        [HttpGet]
        public IActionResult AddCar()
        {
            LoadAll();

            return View();
        }


        [HttpPost]
        public IActionResult AddCar(Auction model)
        {
            if (!ModelState.IsValid)
            {
                LoadAll();
                return View(model);
            }

            context.Auctions.Add(model);
            context.SaveChanges();

            return RedirectToAction("Index", "Home");
        }

        public IActionResult MyVenichles()
        {
            var ven = context.Venichles.Include(v => v.Brand)
                                       .Include(v => v.Model)
                                       .Include(v => v.BodyStyle)
                                       .Include(v => v.FuelType)
                                       .Include(v => v.Transmission)
                                       .Include(v => v.Owner)
                                       .Include(v => v.Auction)
                                       .Where(v => v.OwnerId == 1).ToList();

            return View(ven);
        }

        public IActionResult Delete(int id)
        {
            var ven = context.Venichles.Find(id);
            if (ven != null)
            {
                context.Venichles.Remove(ven);
                context.SaveChanges();
            }
            else return NotFound();


            return RedirectToAction("MyVenichles");
        }

    }
}
