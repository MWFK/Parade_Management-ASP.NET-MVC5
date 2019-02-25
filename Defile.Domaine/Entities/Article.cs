using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Defile.Domaine.Entities
{
    public class Article
    {
        
        public int ArticleCode { get; set; }
        public string Matiere { get; set; }
        public string Couleur { get; set; }
        public int nbAccessoires { get; set; }
        [DataType(DataType.Currency)]
        public float PrixUnitaireFabrication { get; set; }
        [DataType(DataType.Currency)]
        public float PrixUnitaireVente { get; set; }
       
        public int? DefileId { get; set; }
        [ForeignKey("DefileId")]
        public virtual LeDefile Defile { get; set; }
    }
}
