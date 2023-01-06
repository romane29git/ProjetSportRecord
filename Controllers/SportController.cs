using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;


public class SportController : Controller // not ControllerBase!
{

    private readonly SportRecordContext _context;

    public SportController(SportRecordContext context)
    {
        _context = context;
    }

   // GET: Sport
    public async Task<IActionResult> Create()
    {
        return View();
    }

    // GET: Sport
    public async Task<IActionResult> Index()
    {
        var sports = await _context.Sports
        .OrderBy(s => s.Name)
        .ToListAsync();

        return View(sports);
    }

    public async Task<IActionResult> Details(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var sports = await _context.Sports
            .FirstOrDefaultAsync(m => m.Id == id);
        if (sports == null)
        {
            return NotFound();
        }
        return View(sports);
    }

    // // POST: Sport/Create
    // [HttpPost]
    // [ValidateAntiForgeryToken]
    // public async Task<IActionResult> Create(Sport sport)
    // {
    //     // Create new sport in DB
    //     _context.Add(sport);
    //     await _context.SaveChangesAsync();

    //     // Redirect to student details
    //     return RedirectToAction("Sport");
    // }


}


