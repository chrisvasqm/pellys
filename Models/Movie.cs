using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pellys.Models
{
    public class Movie
    {
        public int MovieId { get; set; }
        public string MovieTitle { get; set; }


        public int GenreId { get; set; }
        public virtual Genre Genre { get; set; }
        public int DirectorId { get; set; }
        public virtual Director Director { get; set; }



        public virtual ICollection<Tape> Tapes { get; set; }
        public virtual ICollection<Actor> Actors { get; set; }
    }
}
