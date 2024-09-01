using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities.Venichle
{
    public class Transmition
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Venichle>? Venichles { get; set; }

    }
}
