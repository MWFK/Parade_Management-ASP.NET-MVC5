using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Defile.Domaine.Entities
{
    public class LeDefile
    {
        
        public int DefileCode { get; set; }
        public DateTime DateEvennement { get; set; }
        public Lieu Lieu { get; set; }
        public int Duree { get; set; }
        public int StylistId { get; set; }
        [ForeignKey("StylistId")]
        public virtual StylisteModeliste StylisteModeliste { get; set; }
        public virtual ICollection<Article> Articles { get; set; }
        public virtual ICollection<Affectation> Affectations { get; set; }


    }

    public struct Lieu
    {
        public string Rue { get; set; }
        public string Avenue { get; set; }
    }
}
