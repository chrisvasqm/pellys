using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
namespace Pellys.Models
{
    public class Actor
    {
        [Key]
        public int ActorId { get; set; }
        
        [Required]
        [MinLength(3),MaxLength(20)]
        public string ActorName { get; set; }


        public virtual ICollection<ActorMovies> ActorMovies { get; set; }
        public virtual ICollection<PartnerActors> PartnerActors { get; set; }
    }
}
