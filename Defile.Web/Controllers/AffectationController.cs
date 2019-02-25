using Defile.Domaine.Entities;
using Defile.Service;
using Defile.Web.Helpers;
using Defile.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Defile.Web.Controllers
{
    public class AffectationController : Controller
    {
        MyServiceMannequin servicem = null;
        MyServiceAffectation serviAff = null;
       
        public AffectationController()
        {
            servicem = new MyServiceMannequin();
            serviAff = new MyServiceAffectation();

        }
        // GET: Reservation
        public ActionResult Index()
        {
            return View();
        }

        // GET: Reservation/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Reservation/Create
        public ActionResult Create()
        {
            var res = new AffectationViewModel();
            res.Mannequins = servicem.GetMany().ToSelectListItems();
            return View(res);
        }

        // POST: Reservation/Create
        [HttpPost]
        public ActionResult Create(AffectationViewModel avm)
        {
            Affectation f = new Affectation() {

                DateEnvoi= DateTime.Now,
                Etat = Etat.envoyée,
                Mannequin = servicem.GetById(avm.CIN),

            };
            serviAff.Add(f);
            serviAff.Commit();
            return RedirectToAction("Index");
        }

        // GET: Reservation/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Reservation/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Reservation/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Reservation/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
