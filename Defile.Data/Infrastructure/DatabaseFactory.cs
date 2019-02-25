using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Defile.Data.Infrastructure
{
    public class DatabaseFactory : Disposable, IDatabaseFactory
    {
        private DefileContext dataContext;
        public DefileContext DataContext { get { return dataContext; } }

        public DatabaseFactory()
        {
            dataContext = new DefileContext();
        }
        protected override void DisposeCore()
        {
            if (DataContext != null)
                DataContext.Dispose();
        }
    }
    // Context per user - volume - changement d'état d'un même objet
    // context unique (singleton) - volume - changement d'état d'un même objet
    // context per request (notre solution) + aprés chaque utilisation il sera disposé
}
