using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

public class AddSportController : Controller
{
    private readonly SportRecordContext _context;
    public AddSportController(SportRecordContext context)
    {
        _context = context;
    }

    // // POST: Sport/Create
    // [HttpPost]
    // [ValidateAntiForgeryToken]
    // public async Task<IActionResult> Create([Bind("Name")] Sport sport)
    // {
    //     // Create new sport in DB
    //     _context.Add(sport);
    //     await _context.SaveChangesAsync();

    //     // Redirect to student details
    //     //return RedirectToAction("Details", "Student", new RouteValueDictionary { { "id", enrollment.StudentId } });
    // }
}