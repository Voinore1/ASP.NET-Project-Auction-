namespace Data.Entities.VenichleInfo
{
    public class Venichle
    {
        public int Id { get; set; }
        public string VIN { get; set; }
        public int BrandId { get; set; }a
        public int ModelId { get; set; }
        public int SeriesId { get; set; }
        public int? AuctionId { get; set; }
        public int ManufactureDate { get; set; }
        public int Odometr { get; set; }
        public double FuelConsumption { get; set; }
        public int Seats { get; set; }
        public double ToHundred { get; set; }
        public string ExteriorColor { get; set; }
        public int BodyStyleId { get; set; }
        public int FuelTypeId { get; set; }
        public int TransmissionId { get; set; }

        public ICollection<string> PictureURLs { get; set; }
        public BodyStyle BodyStyle { get; set; }
        public FuelType FuelType { get; set; }
        public Transmission Transmission { get; set; }
        public Brand Brand { get; set; }
        public Model Model { get; set; }
        public Series Series { get; set; }
        public Auction? Auction { get; set; }

    }
}