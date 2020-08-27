using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using IS_BartenderAppProject_MV.Models;

namespace IS_BartenderAppProject_MV.Controllers
{
    public class DrinkController : Controller
    {
        private readonly DrinksContext _context;

        public DrinkController(DrinksContext context)
        {
            _context = context;
        }
        //--------------------

        // GET: Drink
        public async Task<IActionResult> Menu()
        {
            return View(await _context.Drinks.ToListAsync());
        }
        //-------------------

        // GET: Drink
        public async Task<IActionResult> Index()
        {
            return View(await _context.Drinks.ToListAsync());
        }

        // GET: Drink/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var drink = await _context.Drinks
                .FirstOrDefaultAsync(m => m.DrinkId == id);
            if (drink == null)
            {
                return NotFound();
            }

            return View(drink);
        }
       
        // GET: Drink/Create
        public IActionResult Upsert(int id = 0)
        {
            if (id == 0)
            {
                return View(new Drink());
            }

            return View(_context.Drinks.Find(id));
        }

        // POST: Drink/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Upsert([Bind("DrinkId,DrinkName,DrinkCost")] Drink drink)
        {
            if (ModelState.IsValid)
            {
                if (drink.DrinkId==0)
                _context.Add(drink);

                else
                    _context.Update(drink);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(drink);
        }

        /*// GET: Drink/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var drink = await _context.Drinks.FindAsync(id);
            if (drink == null)
            {
                return NotFound();
            }
            return View(drink);
        }

        // POST: Drink/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Upsert(int id, [Bind("DrinkId,DrinkName,DrinkCost")] Drink drink)
        {
            if (id != drink.DrinkId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(drink);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DrinkExists(drink.DrinkId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(drink);
        }
        */
        // GET: Drink/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var drink = await _context.Drinks
                .FirstOrDefaultAsync(m => m.DrinkId == id);
            if (drink == null)
            {
                return NotFound();
            }

            return View(drink);
        }

       // POST: Drink/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var drink = await _context.Drinks.FindAsync(id);
            _context.Drinks.Remove(drink);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DrinkExists(int id)
        {
            return _context.Drinks.Any(e => e.DrinkId == id);
        }
    }
}
