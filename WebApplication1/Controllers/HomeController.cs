using Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController(AuctionDBContext context) : Controller
    {

        public IActionResult Index()
        {
            var aucs = context.Auctions.Include(x => x.Venichle).ToList();

            return View(aucs);
        }

        public void LoadEndingAuctions()
        {
            ViewBag.Auctions = context.Auctions.Include(x => x.Venichle).OrderBy(x => x.TimeEnd).Take(10).ToList();
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
                    .ThenInclude(b => b.User)
                .Include(x => x.Comments)
                .FirstOrDefault(x => x.Id == id);

            LoadEndingAuctions();

            return View(auc);
        }


    }
}