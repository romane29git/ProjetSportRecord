using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;


public class DisciplineController : Controller // not ControllerBase!
{
    private readonly SportRecordContext _context;

    public DisciplineController(SportRecordContext context)
    {
        _context = context;
    }

    // public IActionResult Create()
    // {
    //     return View();
    // }

    // GET: Discipline
    public async Task<IActionResult> Index()
    {
        var disciplines = await _context.Disciplines
        .OrderBy(d => d.Name)
        .Where(d => d.SportId == 1)
        .ToListAsync();

        return View(disciplines);
    }
}