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

    // GET: api/AthleteApi
    public async Task<ActionResult<IEnumerable<Athlete>>> GetAthletes()
    {
        return await _context.Athletes.OrderBy(a => a.LastName).ToListAsync();
    }

    //GET /api/AthletetApi/{id}
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

    // POST: api/AthleteApi
    // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
    [HttpPost]
    public async Task<ActionResult<Athlete>> PostAthlete(Athlete athlete)
    {
        _context.Athletes.Add(athlete);
        await _context.SaveChangesAsync();

        return CreatedAtAction(nameof(GetAthlete), new { id = athlete.Id }, athlete);
    }



}

