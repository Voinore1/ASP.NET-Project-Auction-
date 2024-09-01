namespace Data.Entities.VenichleInfo
{
    public class Venichle
    {
        public int Id { get; set; }
        public string VIN { get; set; }
        public int BrandId { get; set; }
        public int ModelId { get; set; }
        public int SeriesId { get; set; }
        public int ManufactureDate { get; set; }
        public int HP { get; set; }
        public int Odometr { get; set; }
        public int Height { get; set; }
        public int Width { get; set; }
        public int Lenght { get; set; }
        public int Mass { get; set; }
        public double FuelConsumption { get; set; }
        public int Seats { get; set; }
        public int CarryingCap { get; set; }
        public int MaxSpeed { get; set; }
        public int TrunkVol { get; set; }
        public int MyProperty { get; set; }
        public double ToHundred { get; set; }
        public string ExteriorColor { get; set; }
        public int BodyStyleId { get; set; }
        public int FuelTypeId { get; set; }
        public int TransmissionId { get; set; }
        public int DLTid { get; set; }

        public BodyStyle BodyStyle { get; set; }
        public FuelType FuelType { get; set; }
        public Transmission Transmission { get; set; }
        public DLT DrivingLineType { get; set; }

    }
}