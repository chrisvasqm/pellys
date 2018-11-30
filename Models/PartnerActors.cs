using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pellys.Models
{
    public class PartnerActors
    {
        public int PartnerId { get; set; }
        public Partner Partner { get; set; }

        public int ActorId { get; set; }
        public Actor Actor { get; set; }
    }
}
