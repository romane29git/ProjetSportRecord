using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;


[Route("api/[controller]")]
[ApiController]
public class AthleteApiController : ControllerBase
{
    private readonly SportRecordContext _context;

    public AthleteApiController(SportRecordContext context)
    {
        _context = context;
    }

    // GET: api/StudentApi
    public async Task<ActionResult<IEnumerable<Athlete>>> GetAthletes()
    {
        return await _context.Athletes.OrderBy(a => a.LastName).ToListAsync();
    }

    //GET /api/StudentApi/{id}
    //élève identifié par id

    [HttpGet("{id}")]
    public async Task<ActionResult<Athlete>> GetAthlete(int id)
    {
        var athlete = await _context.Athletes
        .Where(a => a.Id == id)
        // .Include(a => a.Records)
        .FirstOrDefaultAsync(); // ou SingleOrDefaultAsync()

        if (athlete == null)
            return NotFound();
        return athlete;

    }



}

