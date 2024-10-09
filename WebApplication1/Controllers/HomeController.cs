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

        public IActionResult Auction(int id)
        {
            var auc = context.Auctions
                .Include(x => x.Venichle)
                    .ThenInclude(v => v.BodyStyle)
                .Include(x => x.Venichle)
                    .ThenInclude(v => v.FuelType)
                .Include(x => x.Venichle)
                    .ThenInclude(v => v.Transmission)
                .Include(x => x.Venichle)
                    .ThenInclude(v => v.Brand)
                .Include(x => x.Venichle)
                    .ThenInclude(v => v.Model)
                .Include(x => x.Venichle)
                    .ThenInclude(v => v.Auction)
                .Include(x => x.Venichle)
                    .ThenInclude(v => v.Owner)
                .Include(x => x.Bids)
                .Include(x => x.Comments)
                .FirstOrDefault(x => x.Id == id);

            return View(auc);
        }


    }
}