using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace Pellys.Models
{
    public class Form
    {
        [Key]
        public int FormId { get; set; }

        [Required]
        public DateTime CreatedDate { get; set; }

        public int PartnerId { get; set; }
        public virtual Partner Partner { get; set; }
        public int TapeId { get; set; }
        public virtual Tape Tape { get; set; }
    }
}
