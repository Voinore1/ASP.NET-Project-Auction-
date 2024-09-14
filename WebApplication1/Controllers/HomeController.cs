using Data;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public AuctionDBContext context = new();
        public IActionResult Index()
        {
            var venichles = context.Venichles.ToList();

            return View(venichles);
        }

        public IActionResult Privacy()
        {
            return View();
        }

    }
}