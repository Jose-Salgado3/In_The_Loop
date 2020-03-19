using System;
using InTheLoop.Data;
using InTheLoop.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace InTheLoop.Controllers
{
    public class ListController : Controller
    {
        private readonly ApplicationDbContext _context;

        //Passes DbContext to controller with constructor
        public ListController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: List
        public ActionResult Index()
        {
            return View();
        }

        // GET: List/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: List/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: List/Create
        /// <summary>
        /// Adds a List to the database and sets the ListId value(PK)
        /// </summary>
        /// <param name="l">The list being reffered to</param>
        /// <returns></returns>
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Add(List l)
        {
            if (ModelState.IsValid)
            {
                //Add to the db
                await ListsDb.Add(l, _context);
                return RedirectToAction("Index");
            }
            // Return view with model and error
            return View(l);
        }

        // GET: List/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: List/Edit/5
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

        // GET: List/Delete/5
        public async Task<IActionResult> Delete(int id)
        {
            List list = await ListsDb.GetListById(id, _context);

            return View(list);
        }

        // POST: List/Delete/5
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