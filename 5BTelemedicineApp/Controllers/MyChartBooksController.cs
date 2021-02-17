using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using _5BTelemedicineApp.Data;
using _5BTelemedicineApp.Models;

namespace _5BTelemedicineApp.Controllers
{
    public class MyChartBooksController : Controller
    {
        private readonly ApplicationDbContext _context;

        public MyChartBooksController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: MyChartBooks
        public async Task<IActionResult> Index()
        {
            return View(await _context.MyChartBook.ToListAsync());
        }

        // GET: MyChartBooks/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var myChartBook = await _context.MyChartBook
                .FirstOrDefaultAsync(m => m.Id == id);
            if (myChartBook == null)
            {
                return NotFound();
            }

            return View(myChartBook);
        }

        // GET: MyChartBooks/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: MyChartBooks/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Message,Diagnostic")] MyChartBook myChartBook)
        {
            if (ModelState.IsValid)
            {
                _context.Add(myChartBook);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(myChartBook);
        }

        // GET: MyChartBooks/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var myChartBook = await _context.MyChartBook.FindAsync(id);
            if (myChartBook == null)
            {
                return NotFound();
            }
            return View(myChartBook);
        }

        // POST: MyChartBooks/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Message,Diagnostic")] MyChartBook myChartBook)
        {
            if (id != myChartBook.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(myChartBook);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MyChartBookExists(myChartBook.Id))
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
            return View(myChartBook);
        }

        // GET: MyChartBooks/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var myChartBook = await _context.MyChartBook
                .FirstOrDefaultAsync(m => m.Id == id);
            if (myChartBook == null)
            {
                return NotFound();
            }

            return View(myChartBook);
        }

        // POST: MyChartBooks/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var myChartBook = await _context.MyChartBook.FindAsync(id);
            _context.MyChartBook.Remove(myChartBook);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MyChartBookExists(int id)
        {
            return _context.MyChartBook.Any(e => e.Id == id);
        }
    }
}
