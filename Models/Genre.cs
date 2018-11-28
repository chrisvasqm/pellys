using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pellys.Models
{
    public class Genre
    {
        public int GenreId { get; set; }
        public int GenreTitle { get; set; }

        public virtual ICollection<Movie> Movies { get; set; }
        public virtual ICollection<Partner> Partners { get; set; }
    }
}
