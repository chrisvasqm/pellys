using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pellys.Models
{
    public class Partner
    {
        public int PartnerId { get; set; }
        public string PartnerName { get; set; }
        public string PartnerAddress { get; set; }
        public string PartnerTelephone { get; set; }


        public virtual ICollection<Form> Forms { get; set; }
        public virtual ICollection<Director> Directors { get; set; }
        public virtual ICollection<Actor> Actors { get; set; }
        public virtual ICollection<Genre> Genres { get; set; }
        public virtual ICollection<WaitingList> WaitingLists { get; set; }
    }
}
