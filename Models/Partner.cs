﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace Pellys.Models
{
    public class Partner
    {
        [Key]
        public int PartnerId { get; set; }

        [Required]
        [MinLength(3), MaxLength(20)]
        [Display(Name = "Nombre")]
        public string PartnerName { get; set; }

        [Required]
        [EmailAddress]
        [Display(Name = "Correo electronico")]
        public string PartnerAddress { get; set; }

        [Required]
        [Phone]
        [Display(Name = "Telefono")]
        public string PartnerTelephone { get; set; }


        public virtual ICollection<Form> Forms { get; set; }
        public virtual ICollection<PartnerDirector> PartnerDirectors { get; set; }
        public virtual ICollection<PartnerActors> PartnerActors { get; set; }
        public virtual ICollection<PartnerGenre> PartnerGenres { get; set; }
        public virtual ICollection<PartnerWaitingList> PartnerWaitingLists { get; set; }
    }
}
