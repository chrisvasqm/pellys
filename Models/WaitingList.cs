using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pellys.Models
{
    public class WaitingList
    {
        public int WaitingListId { get; set; }

        public int MovieId { get; set; }
        public Movie Movie { get; set; }

        public virtual ICollection<Partner> Partners { get; set; }
    }
}
