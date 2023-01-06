using CollectiveStartUpClub.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using DbContext = CollectiveStartUpClub.Models.DbContext;

namespace CollectiveStartUpClub.Controllers
{
    public class StartUpClubsController : Controller
    {
        private readonly DbContext _context;

        public StartUpClubsController(DbContext context)
        {
            _context = context;
        }

        // GET: StartUpClubs
        public async Task<IActionResult> Index()
        {
            return View(await _context.StartUpClubs.ToListAsync());
        }

        // GET: StartUpClubs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.StartUpClubs == null)
            {
                return NotFound();
            }

            var startUpClub = await _context.StartUpClubs
                .FirstOrDefaultAsync(m => m.Id == id);
            if (startUpClub == null)
            {
                return NotFound();
            }

            return View(startUpClub);
        }

        // GET: StartUpClubs/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: StartUpClubs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,ProjectName,InvestorSummary,ASourceOfInspiration,MarketOpportunity,YourCompetitors,CurrentPhaseOfTheProject,PatentTrademarkApplicationDetailsOfTheProject,YourGrowthStrategies,ApplicationType,Name,Surname,Email,TelNo,EducationStatus,City,Address")] StartUpClub startUpClub)
        {
            if (ModelState.IsValid)
            {
                _context.Add(startUpClub);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(startUpClub);
        }

        // GET: StartUpClubs/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.StartUpClubs == null)
            {
                return NotFound();
            }

            var startUpClub = await _context.StartUpClubs.FindAsync(id);
            if (startUpClub == null)
            {
                return NotFound();
            }
            return View(startUpClub);
        }

        // POST: StartUpClubs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,ProjectName,InvestorSummary,ASourceOfInspiration,MarketOpportunity,YourCompetitors,CurrentPhaseOfTheProject,PatentTrademarkApplicationDetailsOfTheProject,YourGrowthStrategies,ApplicationType,Name,Surname,Email,TelNo,EducationStatus,City,Address")] StartUpClub startUpClub)
        {
            if (id != startUpClub.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(startUpClub);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!StartUpClubExists(startUpClub.Id))
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
            return View(startUpClub);
        }

        // GET: StartUpClubs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.StartUpClubs == null)
            {
                return NotFound();
            }

            var startUpClub = await _context.StartUpClubs
                .FirstOrDefaultAsync(m => m.Id == id);
            if (startUpClub == null)
            {
                return NotFound();
            }

            return View(startUpClub);
        }

        // POST: StartUpClubs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.StartUpClubs == null)
            {
                return Problem("Entity set 'DbContext.StartUpClubs'  is null.");
            }
            var startUpClub = await _context.StartUpClubs.FindAsync(id);
            if (startUpClub != null)
            {
                _context.StartUpClubs.Remove(startUpClub);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool StartUpClubExists(int id)
        {
            return _context.StartUpClubs.Any(e => e.Id == id);
        }
    }
}
