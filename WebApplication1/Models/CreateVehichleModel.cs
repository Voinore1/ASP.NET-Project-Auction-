using Data.Entities;
using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class CreateVehichleModel
    {
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



        public IFormFile? MainPhoto { get; set; }
        public IEnumerable<IFormFile>? ExteriorPhotos { get; set; }
        public IEnumerable<IFormFile>? InteriorPhotos { get; set; }
        public string? MainPhotoURL { get; set; }
        public IList<string>? ExteriorPhotosURLId { get; set; }
        public IList<string>? InteriorPhotosURLId { get; set; }





        public int BrandId { get; set; }
        [Range(1, int.MaxValue, ErrorMessage = "You need to choose model")]
        public int ModelId { get; set; }
        public int BodyStyleId { get; set; }
        public int FuelTypeId { get; set; }
        public int TransmissionId { get; set; }
        public int? OwnerId { get; set; }
        public int? AuctionId { get; set; }
        public int? Id { get; set; }

    }
}
