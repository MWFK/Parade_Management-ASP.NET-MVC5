using Defile.Domaine.Entities;
using Defile.Service;
using Defile.Web.Helpers;
using Defile.Web.Models;
using Service.Pattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Defile.Web.Controllers
{
    public class DefileController : Controller
    {
        MyServiceDefile servicedef = null;
        IMyServiceStyliste serviceSty = null;
        public DefileController()
        {
            serviceSty = new MyServiceStyliste();
            servicedef = new MyServiceDefile();
        }
        // GET: Defile
        public ActionResult Index()
        {
            var res = servicedef.GetMany();
            List<DefileViewModel> maliste = new List<DefileViewModel>();
            foreach(var x in res)
            {

                maliste.Add(new DefileViewModel() {
                    DateEvennement = x.DateEvennement,
                    Duree = x.Duree,
                    StylisteName = serviceSty.GetById(x.StylistId).Nom,
                    Defilecode = x.DefileCode


                });
            }
            return View(maliste);
        }

        // GET: Defile/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Defile/Create
        public ActionResult Create()
        {
            var res = new DefileViewModel();
            res.Stylistes = serviceSty.GetMany().ToSelectListItems();
            return View(res); 
        }

        // POST: Defile/Create
        [HttpPost]
        public ActionResult Create(DefileViewModel dvm)
        {
            LeDefile defile = new LeDefile() {

                Duree = dvm.Duree,
                DateEvennement = dvm.DateEvennement,
                StylistId = dvm.StylistCode,  

            };
            servicedef.Add(defile);
            servicedef.Commit();
            return RedirectToAction("Index");
        }

        // GET: Defile/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Defile/Edit/5
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

        // GET: Defile/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Defile/Delete/5
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
