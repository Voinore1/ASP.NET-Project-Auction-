using Data.Entities.VenichleInfo;
using Data.Entities;

namespace WebApplication1.Models
{
    public class CreateAuctionModel
    { 
        public int VenichleId { get; set; }
        public int SellerId { get; set; } = 1;
        public DateTime TimeStart { get; set; }
        public DateTime TimeEnd { get; set; }
        public string Name { get; set; } = null!;
        public string MinDescription { get; set; } = null!;
        public int StartPrice { get; set; }
        public int? CurrentPrice { get; set; }
        public bool IsSold { get; set; } = false;
        public string CityNow { get; set; } = null!;

        public int? Id { get; set; }




    }
}
