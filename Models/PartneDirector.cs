using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pellys.Models
{
    public class PartnerDirector
    {
        public int PartnerId { get; set; }
        public Partner Partner { get; set; }

        public int DirectorId { get; set; }
        public Director Director { get; set; }
    }
}
