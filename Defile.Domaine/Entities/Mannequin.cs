using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Defile.Domaine.Entities
{
    public class Mannequin
    {
        [Key]
        public string CIN { get; set; }
        public float Taille { get; set; }
        public float Poid { get; set; }
        [DataType(DataType.Currency)]
        public float PrixParHeure { get; set; }
        public virtual ICollection<Affectation> Affectations { get; set; }

        public int Age { get; set; }
       
        public int NumContact { get; set; }
    }
}
