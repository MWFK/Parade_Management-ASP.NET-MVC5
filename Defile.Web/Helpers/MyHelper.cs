using Defile.Domaine.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Defile.Web.Helpers
{
    public static class MyHelper
    {
        public static IEnumerable<SelectListItem> ToSelectListItems(
              this IEnumerable<StylisteModeliste> styl)
        {
            return
                styl.OrderBy(s => s.StylistCode)
                      .Select(a =>
                          new SelectListItem
                          {
                              //Selected = (loc.CIN == selectedId),
                              Text = a.Nom + " " + a.Prenom,
                              Value = a.StylistCode.ToString()
                          });
        }
        public static IEnumerable<SelectListItem> ToSelectListItems(
              this IEnumerable<string> etats)
        {
            return
                
                     etats.Select(etat => new SelectListItem
                        {
                            Text = etat,
                            Value = etat
                        }


                );
        }
        public static IEnumerable<SelectListItem> ToSelectListItems(
              this IEnumerable<Mannequin> styl)
        {
            return
                styl.OrderBy(s => s.CIN)
                      .Select(a =>
                          new SelectListItem
                          {
                              //Selected = (loc.CIN == selectedId),
                              Text = a.CIN,
                              Value = a.CIN
                          });
        }
    }
}