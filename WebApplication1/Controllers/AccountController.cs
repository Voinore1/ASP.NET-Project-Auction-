using AutoMapper;
using Core.Models;
using Core.Services;
using Data;
using Data.Entities;
using Data.Entities.VenichleInfo;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;

namespace Core.Controllers
{
    [Authorize]
    public class AccountController(IMapper mapper, AuctionDBContext context, IFileService fileService) : Controller
    {
        private readonly IFileService fileService = fileService;
        private readonly AuctionDBContext context = context;
        private readonly IMapper mapper = mapper;
        public int CurrentUserId => int.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier));

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
        public IActionResult GetModelsByBrand(int brandId)
        {

            var models = context.Models.Where(m => m.BrandId == brandId).ToList();

            return Json(models);

        }
        [HttpGet]
        public IActionResult GetVehicleDetails(int vehicleId)
        {
            var vehicle = context.Venichles.Include(x => x.Model)
                                           .Include(x=>x.BodyStyle)
                                           .Include(x => x.FuelType)
                                           .Include(x => x.Transmission)
                                           .Include(x => x.Brand)
                                           .Where(x => x.Id == vehicleId)
                                           .FirstOrDefault();

            var entity = new 
            {
                Model = vehicle.Model.Name,
                Brand = vehicle.Brand.Name,
                ExteriorColor = vehicle.ExteriorColor,
                Year = vehicle.ManufactureDate,
                InteriorColor = vehicle.InteriorColor,
                Odometr = vehicle.Odometr,
                Vin = vehicle.VIN,
                FuelType = vehicle.FuelType.Name,
                BodyStyle = vehicle.BodyStyle.Style,
                Transmission = vehicle.Transmission.Name,
                ImageUrl = vehicle.MainPhotoURL
            };

            return Json(entity);
        }


        [HttpGet]
        public IActionResult SellCar()
        {
            LoadAll();
            return View();
        }

        [HttpPost]
        public IActionResult SellCar(SellCarModel model)
        {
            if (!ModelState.IsValid || model.AuctionTimeEnd <= model.AuctionTimeStart)
            {
                LoadAll();
                return View(model);
            }

            var ven = mapper.Map<Venichle>(model);

            ven.OwnerId = CurrentUserId;
            ven.Auction.SellerId = CurrentUserId;

            context.Venichles.Add(ven);

            context.SaveChanges();

            return RedirectToAction("Index", "Home");
        }

        public IActionResult MyVehichles()
        {
            var ven = context.Venichles.Include(v => v.Brand)
                                       .Include(v => v.Model)
                                       .Include(v => v.BodyStyle)
                                       .Include(v => v.FuelType)
                                       .Include(v => v.Transmission)
                                       .Include(v => v.Owner)
                                       .Include(v => v.Auction)
                                       .Where(v => v.OwnerId == CurrentUserId).ToList();
            Console.WriteLine(CurrentUserId);

            return View(ven);
        }

        public IActionResult Delete(int id)
        {
            var ven = context.Venichles.Include(x=> x.Auction).FirstOrDefault(x => x.Id == id);
            if (ven != null)
            {
                if (ven.Auction != null)
                {
                    if (DateTime.Now.Ticks < ven.Auction.TimeStart.Ticks)
                    {
                        context.Auctions.Remove(ven.Auction);
                        context.Venichles.Remove(ven);
                    }
                }
                else
                {
                    context.Venichles.Remove(ven);
                }
                
                
            }
            
            context.SaveChanges();
            return RedirectToAction("MyVehichles", "Account");
                        
        }

        [HttpGet]
        public IActionResult EditVehicle(int id)
        {
            var ven = context.Venichles.Include(x => x.Auction).FirstOrDefault(x => x.Id == id);

            if (ven == null) return NotFound();

            LoadAll();

            var entity = mapper.Map<EditCarModel>(ven);

            return View(entity);
        }

        [HttpPost]
        public IActionResult EditVehicle(EditCarModel ven)
        {
            if (!ModelState.IsValid)
            {
                LoadAll();
                return View(ven);
            }

            ven.ExteriorPhotosURLId = context.Venichles.AsNoTracking().FirstOrDefault(x => x.Id == ven.Id).ExteriorPhotosURLId;
            ven.InteriorPhotosURLId = context.Venichles.AsNoTracking().FirstOrDefault(x => x.Id == ven.Id).InteriorPhotosURLId;

            var entity = mapper.Map<Venichle>(ven);
            entity.OwnerId = CurrentUserId;


            var auc = mapper.Map<Auction>(ven);
            auc.SellerId = CurrentUserId;

            context.Venichles.Update(entity);
            context.Auctions.Update(auc);
            context.SaveChanges();

            return RedirectToAction("Index", "Home");
        }



    }
}
