using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pellys.Models
{
    public class PartnerWaitingList
    {
        public int PartnerId { get; set; }
        public Partner Partner { get; set; }

        public int WaitingListId { get; set; }
        public WaitingList WaitingList { get; set; }
    }
}
