using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;


public class AthleteController : Controller
{
    private readonly SportRecordContext _context;

    public AthleteController(SportRecordContext context)
    {
        _context = context;
    }

    // GET: Athlete
    public async Task<IActionResult> Index()
    {
        var athletes = await _context.Athletes.OrderBy(a => a.LastName).ToListAsync();
        return View(athletes);
    }


    //Supprimer un athlète : problème avec record

    // GET: Athlete/Delete/{id}
    // public async Task<IActionResult> Delete(int? id)
    // {
    //     if (id == null)
    //     {
    //         return NotFound();
    //     }

    //     var athlete = await _context.Athletes
    //         .FirstOrDefaultAsync(a => a.Id == id);
    //     if (athlete == null)
    //     {
    //         return NotFound();
    //     }

    //     return View(athlete);
    // }


    // POST: Athlete/Delete/{id]}
    // [HttpPost, ActionName("Delete")]
    // [ValidateAntiForgeryToken]
    // public async Task<IActionResult> DeleteConfirmed(int id)
    // {
    //     var athlete = await _context.Athletes.FindAsync(id);
    //     _context.Athletes.Remove(athlete!);

    //     await _context.SaveChangesAsync();
    //     return RedirectToAction(nameof(Index));
    // }

}
