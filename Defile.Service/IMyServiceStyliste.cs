using Defile.Domaine.Entities;
using Service.Pattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Defile.Service
{
    public interface IMyServiceStyliste : IMyService<StylisteModeliste>
    {
        float CalculerFabricationCollection(StylisteModeliste sm, DateTime def);
        float CalculerVenteCollection(StylisteModeliste sm, DateTime def);
        float CalculCoutMannequin(StylisteModeliste sm, DateTime def);
        float CalculGain(int sm, DateTime def);
    }
}
