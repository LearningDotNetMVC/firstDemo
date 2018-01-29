using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Diagnostics;

namespace MvcDemo.Controllers
{
    public class ProcessController : Controller
    {
        // GET: Process
        [Authorize]
        public ViewResult List()
        {
            var processesList = from p in Process.GetProcesses()
                                select p;

            ViewData.Model = processesList.ToList();

            return View();
        }

        // GET: Process/Details/5
        public ActionResult Details(int id)
        {
            var process = (from p in Process.GetProcesses() where p.Id == id select p).Single();
            ViewData["Process"] = process.ProcessName;
            ViewData["ProcessId"] = process.Id;
            ViewData["ProcessMachineName"] = process.MachineName;
            //ViewData.Model = process;

            //passing the object as parameter --> Model,  at view
            return View(process);
        }

        // GET: Process/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Process/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Process/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Process/Edit/5
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

        // GET: Process/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Process/Delete/5
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
