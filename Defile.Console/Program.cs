
using Defile.Data;
using Defile.Domaine.Entities;
using Defile.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Defile.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            /*              
                             //Test 1
                     
            Mannequin test = new Mannequin() { Age=20,CIN="12345678",Poid=60,Taille=160,NumContact=12345678};
            DefileContext ctx = new DefileContext();
            //Mannequin test = new Mannequin();
            ctx.Mannequins.Add(test);
            ctx.SaveChanges();
            System.Console.WriteLine("FIN");
            System.Console.ReadKey();
            */
            //Test 2
             Mannequin test1 = new Mannequin() { Age = 20, CIN = "12345671", Poid = 60, Taille = 160, NumContact = 12345678,PrixParHeure=200 };
             Mannequin test2 = new Mannequin() { Age = 20, CIN = "12345672", Poid = 60, Taille = 160, NumContact = 12345678 , PrixParHeure = 200 };

             StylisteModeliste st = new StylisteModeliste {Nom="admin" ,Prenom="admin",Telephone=12345678};

            Article a = new Article()
            {
                nbAccessoires = 2,
                Couleur = "rouge",
                Matiere = "velour de soie",
                PrixUnitaireFabrication = 100,
                PrixUnitaireVente = 9000
            };
            Article b = new Article()
            {
                nbAccessoires = 5,
                Couleur = "jaune",
                Matiere = "satin de soie",
                PrixUnitaireFabrication = 150,
                PrixUnitaireVente = 7000
            };
           
            
            


            LeDefile def = new LeDefile
             {
                 DateEvennement = new DateTime(2017, 10, 14),
                 StylisteModeliste = st,
                 Duree = 5,
                 Lieu = new Lieu() { Avenue = "test", Rue = "test" },
                 Articles = new List<Article>() { a,b}

             };





             DefileContext ctx = new DefileContext();
               //ctx.Mannequins.Add(test1);
              //ctx.Mannequins.Add(test2);
              ctx.Articles.Add(a);
              ctx.Articles.Add(b);
              ctx.StylisteModelistes.Add(st);
              ctx.Deliles.Add(def);

             ctx.SaveChanges();
             System.Console.WriteLine("FIN p1");

                        //Test 3                      

             List<Affectation> aff1 = new List<Affectation>() {
              new Affectation {Defile=def,Mannequin=test2 ,DateEnvoi=new DateTime(2016,5,10),Etat=Etat.approuvée},
              new Affectation() { Defile = def, Mannequin = test2,DateEnvoi=new DateTime(2016,6,10) ,Etat=Etat.envoyée},
              new Affectation() { Defile = def, Mannequin = test1,DateEnvoi=new DateTime(2016,9,10) ,Etat=Etat.désapprouvée}
             };
             ctx.Affectations.AddRange(aff1);


             ctx.SaveChanges();
             System.Console.WriteLine("FIN p2");
             System.Console.ReadKey();
             
            

            IMyServiceStyliste service = new MyServiceStyliste();
            System.Console.WriteLine(" gain  = "+service.CalculGain(1, new DateTime(2017, 10, 14))  );

            System.Console.WriteLine("Fin p3");
            System.Console.ReadKey();
            
         }
     }
 }
