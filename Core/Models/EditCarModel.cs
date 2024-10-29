using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;

namespace Core.Models
{
    public class EditCarModel
    {
        // Vehicle part

        public int Id { get; set; }
        [StringLength(17)]
        public string VIN { get; set; } = null!;
        public int ManufactureDate { get; set; }
        [Range(0, int.MaxValue)]
        public int Odometr { get; set; }
        public string ExteriorColor { get; set; } = null!;
        public string InteriorColor { get; set; } = null!;
        public bool IsModified { get; set; }
        public bool HaveProblems { get; set; }
        public string? Problems { get; set; }
        public string? Description { get; set; }
        public bool IsHTMLProblemList { get; set; }
        public bool IsHTMLDescription { get; set; }
        public int BrandId { get; set; }
        [Range(1, int.MaxValue, ErrorMessage = "You need to choose model")]
        public int ModelId { get; set; }
        public int BodyStyleId { get; set; }
        public int FuelTypeId { get; set; }
        public int TransmissionId { get; set; }

        public IFormFile? MainPhoto { get; set; }
        public IEnumerable<IFormFile>? ExteriorPhotos { get; set; }
        public IEnumerable<IFormFile>? InteriorPhotos { get; set; }
        public string? MainPhotoURl { get; set; }
        public IList<string>? ExteriorPhotosURLId { get; set; }
        public IList<string>? InteriorPhotosURLId { get; set; }


        // Auction part
        public int AuctionId { get; set; }

        public DateTime AuctionTimeStart { get; set; }
        public DateTime AuctionTimeEnd { get; set; }
        public string AuctionName { get; set; } = null!;
        public string AuctionMinDescription { get; set; } = null!;
        public int AuctionStartPrice { get; set; }
        public bool AuctionIsSold { get; set; } = false;
        public string AuctionCityNow { get; set; } = null!;
    }
}
