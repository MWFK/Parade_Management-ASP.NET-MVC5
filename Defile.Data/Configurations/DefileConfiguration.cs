using Defile.Domaine.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Defile.Data.Configurations
{
    public class DefileConfiguration : EntityTypeConfiguration<LeDefile>
    {
        public DefileConfiguration()
        {
            HasRequired(def => def.StylisteModeliste).WithMany(st => st.Defiles).HasForeignKey(d=>d.StylistId).WillCascadeOnDelete(true);
            HasMany(def => def.Articles).WithOptional(a => a.Defile).HasForeignKey(d => d.DefileId).WillCascadeOnDelete(false);
        }

    }
}
