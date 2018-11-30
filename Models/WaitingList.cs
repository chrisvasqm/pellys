using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace Pellys.Models
{
    public class WaitingList
    {
        [Key]
        public int WaitingListId { get; set; }

        public int MovieId { get; set; }
        public Movie Movie { get; set; }

        public virtual ICollection<PartnerWaitingList> PartnerWaitingLists { get; set; }
    }
}
