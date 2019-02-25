using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Defile.Domaine.Entities
{
    public enum Etat { envoyée , approuvée , désapprouvée}
    public class Affectation
    {
        public Etat Etat { get; set; }
        [Key, Column(Order = 3)]
        public DateTime DateEnvoi { get; set; }
        [Key,Column(Order = 1)]
        public virtual LeDefile Defile { get; set; }
        [Key, Column(Order = 2)]
        public virtual Mannequin  Mannequin { get; set; }
    }
}
