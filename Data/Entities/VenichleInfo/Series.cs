namespace Data.Entities.VenichleInfo
{
    public class Series
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int ModelId { get; set; }
        public Model Model { get; set; }
        public ICollection<Venichle>? Venichles { get; set; }


    }
}
