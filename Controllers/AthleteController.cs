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
        var athletes = await _context.Athletes.OrderBy(m => m.LastName).ToListAsync();
        return View(athletes);
    }
}