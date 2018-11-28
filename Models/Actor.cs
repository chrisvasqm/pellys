using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pellys.Models
{
    public class Actor
    {
        public int ActorId { get; set; }
        public string ActorName { get; set; }


        public virtual ICollection<Movie> Movies { get; set; }
        public virtual ICollection<Partner> Partners { get; set; }
    }
}
