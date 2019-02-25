using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Defile.Web.Models
{
    public class AffectationViewModel
    {

        public string Etat = "Envoyée";
        
        public DateTime DateEnvoi { get; set; }
        
        public int DefileId { get; set; }
        public string CIN { get; set; }
        public IEnumerable<SelectListItem>  Mannequins { get; set; }
    }
}