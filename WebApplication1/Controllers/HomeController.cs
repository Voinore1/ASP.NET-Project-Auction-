using Core.Models;
using Data;
using Data.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;

namespace WebApplication1.Controllers
{
    public class HomeController(AuctionDBContext context) : Controller
    {
        public int CurrentUserId => int.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier));


        public IActionResult Index()
        {
            var aucs = context.Auctions.Include(x => x.Venichle).ToList();

            return View(aucs);
        }

        public void LoadEndingAuctions()
        {
            ViewBag.Auctions = context.Auctions.Include(x => x.Venichle).OrderBy(x => x.TimeEnd).Take(10).ToList();
        }

        private void LoadCommentBids(int id)
        {
            List<IDisplayable> displayables = new List<IDisplayable>();
            displayables.AddRange(context.Comments.Include(x => x.User).Where(x => x.AuctionId == id).ToList());
            displayables.AddRange(context.Bids.Include(x => x.User).Where(x => x.AuctionId == id).ToList());
            ViewBag.Displayables = displayables.OrderByDescending(x => x.Time).ToList();
        }

        public IActionResult Auction(int id)
        {
            var auction = context.Auctions
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
            LoadCommentBids(id);

            if (auction == null) return NotFound();

            ViewBag.auc = auction;

            return View();
        }

        [HttpPost, Authorize]
        public IActionResult AddComment(BidCommentModel model)
        {
            if (string.IsNullOrEmpty(model.Text))
            {
                ModelState.AddModelError("text", "Comment cannot be empty.");

                return RedirectToAction("Auction", new { id = model.AuctionId });

            }

            var comment = new Comment
            {
                AuctionId = model.AuctionId,
                Text = model.Text,
                CommentTime = DateTime.Now,
                UserId = CurrentUserId
            };


            context.Comments.Add(comment);
            context.SaveChanges();

            return RedirectToAction("Auction", new { id = model.AuctionId });
        }

        [HttpPost, Authorize]
        public IActionResult AddBid(BidCommentModel model)
        {
            var lastBid = context.Bids.OrderByDescending(x => x.Value).FirstOrDefault(x => x.AuctionId == model.AuctionId);
            var auc = context.Auctions.FirstOrDefault(x => x.Id == model.AuctionId);

            if (lastBid == null)
            {
                if (model.Value == null || model.Value < auc.CurrentPrice)
                {
                    return RedirectToAction("Auction", new { id = model.AuctionId });
                }
            }
            else if(model.Value == null || model.Value < lastBid.Value)
            {
                return RedirectToAction("Auction", new { id = model.AuctionId });
            }


            var bid = new Bid
            {
                AuctionId = model.AuctionId,
                Value = model.Value.Value,
                UserId = CurrentUserId,
                BidTime = DateTime.Now

            };

            auc = context.Auctions.FirstOrDefault(x => x.Id == model.AuctionId);
            auc.CurrentPrice = (int)model.Value;

            context.Bids.Add(bid);
            context.Auctions.Update(auc);
            context.SaveChanges();

            return RedirectToAction("Auction", new { id = model.AuctionId });
        }


    }
}