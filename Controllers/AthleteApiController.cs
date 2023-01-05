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

    //GET /api/AthleteApi/{id}
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
    [HttpPost]
    public async Task<ActionResult<Athlete>> PostAthlete(AthleteDTO athleteDTO)
    {
        Athlete athlete = new Athlete(athleteDTO);

        var discipline = _context.Disciplines.Find(athleteDTO.DisciplineId);

        athlete.Discipline = discipline!;

        _context.Athletes.Add(athlete);
        await _context.SaveChangesAsync();

        return CreatedAtAction(nameof(GetAthlete), new { id = athlete.Id }, athlete);
    }

    // ...
    // DELETE: api/AthleteApi/5
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteAthlete(int id)
    {
        var athlete = await _context.Athletes.FindAsync(id);
        if (athlete == null)
            return NotFound();

        _context.Athletes.Remove(athlete);
        await _context.SaveChangesAsync();

        return NoContent();
    }
    

    // PUT: api/AthleteApi/5
    // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
    [HttpPut("{id}")]
    public async Task<IActionResult> PutAthlete(int id, Athlete athlete)
    {
        if (id != athlete.Id)
            return BadRequest();

        _context.Entry(athlete).State = EntityState.Modified;
        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!AthleteExists(id))
                return NotFound();
            else
                throw;
        }
        return NoContent();
    }

    // Returns true if a athlete with specified id already exists
    private bool AthleteExists(int id)
    {
        return _context.Athletes.Any(a => a.Id == id);
    }



}

