using Dot_Net_Developer_Test.Models;
using Microsoft.AspNetCore.Mvc;

namespace Dot_Net_Developer_Test.Controllers
{
    public class StockMController : Controller
    {
        public readonly StockMDbContext db;
        public StockMController(StockMDbContext db)
        {
            this.db = db;
        }
        public IActionResult StockM()
        {
            return View();
        }
        [HttpPost]
        public IActionResult StockM(StockM d)
        {
            if (ModelState.IsValid)
            {
                db.StockMs.Add(d);
                db.SaveChanges();
                return RedirectToAction("List");
            }
            return View(d);
        }
        [HttpGet]
        public IActionResult List()
        { 
            var StokeM = db.StockMs.ToList();
            return View(db.StockMs);
        }
        public IActionResult Search(string searchtext)
        {
            ViewData["List"] = searchtext;
            var stockMs = from x in db.StockMs select x;
            if (!String.IsNullOrEmpty(searchtext))
            {
                stockMs = stockMs.Where(x => x.Trade_code.Contains(searchtext)||x.Date.Contains(searchtext));
            }
            return View(stockMs);

        }
        [HttpGet]
        public async Task<IActionResult> Edit(int Id)
        {
            var stockM = await db.StockMs.FindAsync(Id);
            return View(stockM);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(StockM em)
        {
            var StockM = await db.StockMs.FindAsync(em.Id);

            if (em is not null)
            {
                StockM.Date=em.Date;
                StockM.Trade_code = em.Trade_code;
                StockM.High=em.High;
                StockM.Low=em.Low;
                StockM.Open=em.Open;
                StockM.Close=em.Close;
                StockM.Valume=em.Valume;

                await db.SaveChangesAsync();
            }
            return RedirectToAction("List", "StockM");
        }
        public async Task<IActionResult> Delete(int Id)
        {
            var StockM = await db.StockMs.FindAsync(Id);
            if (StockM is not null)
            {
                db.StockMs.Remove(StockM);
                await db.SaveChangesAsync();
            }
            return RedirectToAction("List", "StockM");
        }
    }
}
