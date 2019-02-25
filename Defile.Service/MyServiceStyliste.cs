using Defile.Domaine.Entities;
using Service.Pattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Defile.Service
{
    public class MyServiceStyliste: MyService<StylisteModeliste>,IMyServiceStyliste
    {
        public float CalculerFabricationCollection(StylisteModeliste sm,DateTime def)
        {
                  
            float prixCollection = 0;
            float prixAccessoirs = 0;
            foreach (Article a in sm.Defiles.Where(d => d.DateEvennement == def).FirstOrDefault().Articles)
            {
                prixCollection += a.PrixUnitaireFabrication;
               
                if (a.nbAccessoires != 0)
                {
                    prixAccessoirs += a.nbAccessoires * 100;
                    
                }
            }
            Console.WriteLine("prixCollection  :  "+ prixCollection + " +prixAccessoirs : " + prixAccessoirs);
            return prixCollection+prixAccessoirs;
        }

        public float CalculerVenteCollection(StylisteModeliste sm, DateTime def)
        {

            float prixVente = 0;
            
            foreach (Article a in sm.Defiles.Where(d => d.DateEvennement == def).FirstOrDefault().Articles)
            {
                prixVente += a.PrixUnitaireVente;
            }
            Console.WriteLine("prixVente  :  "+ prixVente);
            return prixVente;
        }


        public float CalculCoutMannequin(StylisteModeliste sm, DateTime def)
        {
            float CoutMannquin = 0;
           
            foreach (Affectation a in sm.Defiles.Where(d => d.DateEvennement == def).FirstOrDefault().Affectations)
                CoutMannquin += a.Mannequin.PrixParHeure * sm.Defiles.Where(d => d.DateEvennement == def).FirstOrDefault().Duree;

            Console.WriteLine("   CoutMannquin  : "+ CoutMannquin);
             return CoutMannquin;
        }

        public float CalculGain (int smId, DateTime def)
        {
            StylisteModeliste sm = GetById(smId);
            Console.WriteLine("nom  = "+sm.Nom);
            Console.ReadKey();
            return CalculerVenteCollection(sm, def) - 
                CalculCoutMannequin(sm, def) - 
                CalculerFabricationCollection(sm, def);

        }

    }
}
