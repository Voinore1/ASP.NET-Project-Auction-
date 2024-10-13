using AutoMapper;
using Data;
using Data.Entities;
using Data.Entities.VenichleInfo;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using WebApplication1.Models;
using WebApplication1.Services;

namespace WebApplication1.Controllers
{
    public class AccountController(IMapper mapper, AuctionDBContext context, IFileService fileService) : Controller
    {
        private readonly IFileService fileService = fileService;
        private readonly AuctionDBContext context = context;
        private readonly IMapper mapper = mapper;

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
        private void LoadMyCarsAuctionsOff()
        {
            ViewBag.Vehichles = new SelectList(
                context.Venichles.Include(v => v.Auction)
                                 .Include(v => v.Model)
                                 .Where(v => v.OwnerId == 1 && v.Auction == null).ToList(), "Id", "Model.Name");
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
            LoadMyCarsAuctionsOff();

            return View();
        }

        [HttpPost]
        public IActionResult SellCar(CreateAuctionModel model)
        {
            if (!ModelState.IsValid || model.TimeEnd <= model.TimeStart)
            {
                LoadMyCarsAuctionsOff();
                return View(model);
            }

            model.CurrentPrice = model.StartPrice;

            var auc = mapper.Map<Auction>(model);

            context.Auctions.Add(auc);
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
        public async Task<IActionResult> AddCar(CreateVehichleModel model)
        {
            if (!ModelState.IsValid)
            {
                LoadAll();
                return View(model);
            }

            var ven = mapper.Map<Venichle>(model);
            ven.OwnerId = 1;

            Console.WriteLine(model.ExteriorPhotos);
            if (model.MainPhoto != null)
                ven.MainPhotoURL = await fileService.SaveImage(model.MainPhoto);
            if(model.ExteriorPhotos != null)
                ven.ExteriorPhotosURLId = await fileService.SaveImages(model.ExteriorPhotos.ToList());
            if (model.InteriorPhotos != null)
                ven.InteriorPhotosURLId = await fileService.SaveImages(model.InteriorPhotos.ToList());

            context.Venichles.Add(ven);
            context.SaveChanges();

            return RedirectToAction("MyVehichles", "Account");
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
                                       .Where(v => v.OwnerId == 1).ToList();

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
            var ven = context.Venichles.Find(id);

            if (ven == null) return NotFound();

            LoadAll();

            var entity = mapper.Map<CreateVehichleModel>(ven);

            return View(entity);
        }

        [HttpPost]
        public IActionResult EditVehicle(CreateVehichleModel ven)
        {
            if (!ModelState.IsValid)
            {
                LoadAll();
                return View(ven);
            }

            var entity = mapper.Map<Venichle>(ven);

            context.Venichles.Update(entity);
            context.SaveChanges();

            return RedirectToAction("Index", "Home");
        }

        [HttpGet]
        public IActionResult EditAuction(int id)
        {
            var ven = context.Venichles.Include(x => x.Auction).FirstOrDefault(x => x.Id == id);

            if (ven == null) return NotFound();

            LoadAll();

            var entity = mapper.Map<CreateAuctionModel>(ven.Auction);

            return View(entity);
        }

        [HttpPost]
        public IActionResult EditAuction(CreateAuctionModel ven)
        {
            if (!ModelState.IsValid)
            {
                LoadAll();
                return View(ven);
            }

            var entity = mapper.Map<Auction>(ven);
            entity.CurrentPrice = entity.StartPrice;

            context.Auctions.Update(entity);
            context.SaveChanges();

            return RedirectToAction("Index", "Home");
        }

    }
}
