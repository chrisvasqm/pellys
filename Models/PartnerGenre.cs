using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pellys.Models
{
    public class PartnerGenre
    {
        public int PartnerId { get; set; }
        public Partner Partner { get; set; }

        public int GenreId { get; set; }
        public Genre Genre { get; set; }
    }
}
