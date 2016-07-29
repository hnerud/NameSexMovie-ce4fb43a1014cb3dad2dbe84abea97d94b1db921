using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using NameSexMovie.Data;
using NameSexMovie.Models;

namespace NameSexMovie.Controllers
{
    public class InformationController : Controller
    {
        private readonly ApplicationDbContext _context;
        
        

        public InformationController(ApplicationDbContext context)
        {
            _context = context;    
        }

        // GET: Information
        public async Task<IActionResult> Index(string category, string searchString, string subcategory)
        {

            if (category == "book")
            {
                IQueryable<string> categoryQuery = from m in _context.Information
                                                   orderby m.book
                                                   select m.book;

                var information = from m in _context.Information
                                  select m;


                if (!String.IsNullOrEmpty(subcategory))
                {
                    information = information.Where(x => x.book == subcategory);
                }
                var informationVM = new InformationViewModel();
                informationVM.selectedCategory = new SelectList(await categoryQuery.Distinct().ToListAsync());
                informationVM.information = await information.ToListAsync();

                return View(informationVM);
            }
            else if (category == "movie")
            {
                IQueryable<string> categoryQuery = from m in _context.Information
                                                   orderby m.movie
                                                   select m.movie;

                var information = from m in _context.Information
                                  select m;


                if (!String.IsNullOrEmpty(subcategory))
                {
                    information = information.Where(x => x.movie == subcategory);
                }
                var informationVM = new InformationViewModel();
                informationVM.selectedCategory = new SelectList(await categoryQuery.Distinct().ToListAsync());
                informationVM.information = await information.ToListAsync();

                return View(informationVM);
            }
            else if (category == "food")
            {
                IQueryable<string> categoryQuery = from m in _context.Information
                                                   orderby m.food
                                                   select m.food;

                var information = from m in _context.Information
                                  select m;


                if (!String.IsNullOrEmpty(subcategory))
                {
                    information = information.Where(x => x.food == subcategory);
                }
                var informationVM = new InformationViewModel();
                informationVM.selectedCategory = new SelectList(await categoryQuery.Distinct().ToListAsync());
                informationVM.information = await information.ToListAsync();

                return View(informationVM);
            }

            else
            {
                IQueryable<string> categoryQuery = from m in _context.Information
                                                   orderby m.music
                                                   select m.music;

                var information = from m in _context.Information
                                  select m;

              
                if (!String.IsNullOrEmpty(subcategory))
                {
                    information = information.Where(x => x.music == subcategory);
                }

                var informationVM = new InformationViewModel();
                informationVM.selectedCategory = new SelectList(await categoryQuery.Distinct().ToListAsync());
                informationVM.information = await information.ToListAsync();

                return View(informationVM);
            }




        }

        // GET: Information/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var information = await _context.Information.SingleOrDefaultAsync(m => m.ID == id);
            if (information == null)
            {
                return NotFound();
            }

            return View(information);
        }

        // GET: Information/Create
        [Authorize]
        public IActionResult Create()
        {

            return View();
        }

        // POST: Information/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,gender,movie,name,book,music,food,age")] Information information)
        {
            if (ModelState.IsValid)
            {
                _context.Add(information);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(information);
        }

        // GET: Information/Edit/5
        [Authorize]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var information = await _context.Information.SingleOrDefaultAsync(m => m.ID == id);
            if (information == null)
            {
                return NotFound();
            }
            return View(information);
        }

        // POST: Information/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,gender,movie,name,book,music,food,age")] Information information)
        {
            if (id != information.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(information);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!InformationExists(information.ID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction("Index");
            }
            return View(information);
        }

        // GET: Information/Delete/5
        [Authorize]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var information = await _context.Information.SingleOrDefaultAsync(m => m.ID == id);
            if (information == null)
            {
                return NotFound();
            }

            return View(information);
        }

        // POST: Information/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var information = await _context.Information.SingleOrDefaultAsync(m => m.ID == id);
            _context.Information.Remove(information);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        private bool InformationExists(int id)
        {
            return _context.Information.Any(e => e.ID == id);
        }
    }
}
