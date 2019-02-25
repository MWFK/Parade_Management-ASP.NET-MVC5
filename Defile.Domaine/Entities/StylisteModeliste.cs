using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Defile.Domaine.Entities
{
    public class StylisteModeliste
    {
      
        public int StylistCode { get; set; }
      
        public int Telephone { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }

        public virtual ICollection<LeDefile> Defiles { get; set; }
    }
}
