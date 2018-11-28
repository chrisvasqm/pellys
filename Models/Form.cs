using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pellys.Models
{
    public class Form
    {
        public int FormId { get; set; }
        public DateTime CreatedDate { get; set; }

        public int PartnerId { get; set; }
        public virtual Partner Partner { get; set; }
        public int TapeId { get; set; }
        public virtual Tape Tape { get; set; }
    }
}
