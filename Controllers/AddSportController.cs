using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

public class AddSportController : Controller
{
    private readonly SportRecordContext _context;
    public AddSportController(SportRecordContext context)
    {
        _context = context;
    }

    // POST: Sport/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create([Bind("Id,CourseId,StudentId")] Enrollment enrollment)
    {
        // Lookup student and course
        var student = _context.Students.Find(enrollment.StudentId);
        var course = _context.Courses.Find(enrollment.CourseId);

        // Define student and course for new enrollment
        enrollment.Student = student!;
        enrollment.Course = course!;

        // Create new enrollment in DB
        _context.Add(enrollment);
        await _context.SaveChangesAsync();

        // Redirect to student details
        return RedirectToAction("Details", "Student", new RouteValueDictionary { { "id", enrollment.StudentId } });
    }
}