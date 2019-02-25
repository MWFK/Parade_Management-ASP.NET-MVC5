using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Defile.Data.Infrastructure
{
    public interface IDatabaseFactory : IDisposable
    {
        DefileContext DataContext { get; }
    }

}
