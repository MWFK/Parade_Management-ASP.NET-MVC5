using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Defile.Data.CustomConventions
{
    public class CodeConvention : Convention
    {
        public CodeConvention()
        {
            Properties<int>().Where(p=>p.Name.EndsWith("Code")).Configure(p=>p.IsKey());
        }
    }
}
