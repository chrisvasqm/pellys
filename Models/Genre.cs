using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace Pellys.Models
{
    public class Genre
    {
        [Key]
        public int GenreId { get; set; }

        [Required]
        [MinLength(3), MaxLength(20)]
        public int GenreTitle { get; set; }

        public virtual ICollection<Movie> Movies { get; set; }
        public virtual ICollection<PartnerGenre> PartnerGenres { get; set; }
    }
}
