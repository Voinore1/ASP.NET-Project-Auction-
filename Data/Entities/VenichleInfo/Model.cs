namespace Data.Entities.VenichleInfo
{
    public class Model
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int BrandId { get; set; }
        public Brand Brand { get; set; }
        public ICollection<Series>? Series { get; set; }
        public ICollection<Venichle>? Venichles { get; set; }
    }
}
