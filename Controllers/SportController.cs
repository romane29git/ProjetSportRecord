using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

public class SportController : Controller // not ControllerBase!
{

    private readonly SportRecordContext _context;

    public SportController(SportRecordContext context)
    {
        _context = context;
    }

    public IActionResult Create()
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

    public async Task<IActionResult> Disciplines(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        // Recherche des disciplines contenues dans ce sport
        var discipline = await _context.Disciplines
            .Where(s => s.SportId == id)
            .ToListAsync();
        if (discipline == null)
        {
            return NotFound();
        }

        return View(discipline);
    }


    public async Task<IActionResult> Record(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var record = await _context.Disciplines
        .Where(a => a.Id == id)
        .FirstOrDefaultAsync();

        if (record == null)
        {
            return NotFound();
        }

        return View(record);
    }



    // POST: Sport/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create([Bind("Id,Name")] Sport sport)
    {
        // Apply model validation rules
        if (ModelState.IsValid)
        {
            _context.Add(sport);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        // At this point, something failed: redisplay form
        return View(sport);
    }

}


