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
        ViewData["idSport"] = id;
        var sport = await _context.Sports.FindAsync(id);
        ViewData["nomSport"] = sport.Name;
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

    // GET: Sport/CreateDiscipline/5
    public IActionResult CreateDiscipline(int? id)
    {
        ViewData["idSport"] = id;
        return View();
    }

    // POST: Sport/CreateDiscipline
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> CreateDiscipline([Bind("Id,Name,Description,SportId")] Discipline discipline)
    {
        // Apply model validation rules
        if (ModelState.IsValid)
        {
            _context.Add(discipline);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        // At this point, something failed: redisplay form
        return View(discipline);
    }


    public async Task<IActionResult> Record(int? id)
    {
        ViewData["idDiscipline"] = id;
        var discipline = await _context.Disciplines.FindAsync(id);
        ViewData["nomDiscipline"] = discipline.Name;
        ViewData["descrDiscipline"] = discipline.Description;

        if (id == null)
        {
            return NotFound();
        }

        // Recherche des records de la discipline
        var record = await _context.Records
            .Where(s => s.DisciplineId == id)
            .Include(s => s.Athlete)
            .ToListAsync();
        if (record == null)
        {
            return View(null);
        }

        return View(record);
    }

}


