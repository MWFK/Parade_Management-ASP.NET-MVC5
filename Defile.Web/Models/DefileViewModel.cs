using Defile.Domaine.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Defile.Web.Models
{
    public class DefileViewModel
    {
        public int Defilecode { get; set; }

        [DataType(DataType.Date)]
        public DateTime DateEvennement { get; set; }
        
        public int Duree { get; set; }
        

        [Display(Name = "Styliste Modeliste ")]
        public int StylistCode { get; set; }

        public IEnumerable<SelectListItem> Stylistes { get; set; }

        public string StylisteName { get; set; } //pour l'affichage
    }
}