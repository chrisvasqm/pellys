using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace Pellys.Models
{
    public class Director
    {
        [Key]
        public int DirectorId { get; set; }
        [Required]
        [MinLength(3), MaxLength(20)]
        public string DirectorName { get; set; }


        public virtual ICollection<Movie> Movies { get; set; }
        public virtual ICollection<PartnerDirector> PartnerDirectors { get; set; }
    }
}
