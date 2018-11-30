using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace Pellys.Models
{
    public class Tape
    {
        [Key]
        public int TapeId { get; set; }

        [Required]
        public bool TapeState { get; set; }


        public int MovieId { get; set; }
        public virtual Movie Movie { get; set; }


        public virtual ICollection<Form> Forms { get; set; }
    }
}
