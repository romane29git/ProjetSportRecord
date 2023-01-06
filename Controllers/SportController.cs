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


