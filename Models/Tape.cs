using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pellys.Models
{
    public class Tape
    {
        public int TapeId { get; set; }
        public bool TapeState { get; set; }


        public int MovieId { get; set; }
        public virtual Movie Movie { get; set; }


        public virtual ICollection<Form> Forms { get; set; }
    }
}
