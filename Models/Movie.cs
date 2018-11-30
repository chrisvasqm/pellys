using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace Pellys.Models
{
    public class Movie
    {
        [Key]
        public int MovieId { get; set; }

        [Required]
        [MinLength(3), MaxLength(20)]
        public string MovieTitle { get; set; }


        public int GenreId { get; set; }
        public virtual Genre Genre { get; set; }
        public int DirectorId { get; set; }
        public virtual Director Director { get; set; }



        public virtual ICollection<Tape> Tapes { get; set; }
        public virtual ICollection<ActorMovies> ActorMovies { get; set; }
    }
}
