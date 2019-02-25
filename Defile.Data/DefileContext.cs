using Defile.Data.Configurations;
using Defile.Data.CustomConventions;
using Defile.Domaine.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Defile.Data
{
    public class DefileContext : DbContext
    {
        public DefileContext():base("name=DefileChaine")
        {

        }

        public DbSet<StylisteModeliste> StylisteModelistes { get; set; }
        public DbSet<LeDefile> Deliles { get; set; }
        public DbSet<Mannequin> Mannequins { get; set; }
       public DbSet<Article> Articles { get; set; }
       public DbSet<Affectation> Affectations { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
          modelBuilder.Configurations.Add(new DefileConfiguration());
           modelBuilder.Conventions.Add(new CodeConvention());
            
        }

    }
}
