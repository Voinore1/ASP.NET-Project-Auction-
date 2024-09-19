using Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public AuctionDBContext context = new();
        public IActionResult Index()
        {
            var aucs = context.Auctions.Include(x => x.Venichle).ToList();

            return View(aucs);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Auction()
        {
            return View();
        }

    }
}