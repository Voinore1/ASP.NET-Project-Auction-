using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities.Venichle
{
    public class Series
    {
        public int id { get; set; }
        public string Name { get; set; }
        public int ModelId { get; set; }
        public Model Model { get; set; }
        public ICollection<Venichle>? Venichles { get; set; }


    }
}
