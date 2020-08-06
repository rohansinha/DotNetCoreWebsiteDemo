using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DemoWebsite2
{
    public class RandomController : Controller
    {
        // GET: Random
        public ActionResult Index()
        {
            return View();
        }

        // GET: Random/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Random/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Random/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Random/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Random/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Random/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Random/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}