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



    // GET: Sport/CreateDiscipline?SportId=5
    public async Task<IActionResult> CreateDiscipline(int? sportId)
    {
        if (sportId == null)
        {
            return NotFound();
        }

        // Lookup sports by id
        var sport = await _context.Sports.FindAsync(sportId);
        if (sport == null)
        {
            return NotFound();
        }

        // Retrieve list of sports existing
        var sportsQuery = from s in _context.Sports
                          select s;

        var availableSports = sportsQuery.ToList();

        ViewData["Sports"] = sport;
        //ViewData["CourseId"] = new SelectList(availableCourses, "Id", "Title");
        return View();
    }



    // POST: Sport/CreateDiscipline
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> CreateDiscipline([Bind("Id,Name,SportId")] Discipline discipline)
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



        // Lookup student and course
        // var student = _context.Students.Find(enrollment.StudentId);
        // var course = _context.Courses.Find(enrollment.CourseId);

        // // Define student and course for new enrollment
        // enrollment.Student = student!;
        // enrollment.Course = course!;

        // // Create new enrollment in DB
        // _context.Add(enrollment);
        // await _context.SaveChangesAsync();

        // // Redirect to student details
        // return RedirectToAction("Details", "Student", new RouteValueDictionary { { "id", enrollment.StudentId } });



    }

}


