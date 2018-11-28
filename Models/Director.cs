using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pellys.Models
{
    public class Director
    {
        public int DirectorId { get; set; }
        public string DirectorName { get; set; }


        public virtual ICollection<Movie> Movies { get; set; }
        public virtual ICollection<Partner> Partners { get; set; }
    }
}
