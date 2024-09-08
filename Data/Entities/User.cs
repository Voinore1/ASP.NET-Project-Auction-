using Data.Entities.VenichleInfo;

namespace Data.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int PhoneNumber { get; set; }
        public int Balance { get; set; }

        public ICollection<Comment>? Comments { get; set; }
        public ICollection<Auction>? Auctions { get; set; }
        public ICollection<Auction>? WatchList { get; set; } 
        public ICollection<Venichle>? Venichles { get; set; }

    }
}
