public class Record
{
    public int Id { get; set; }
    public int DisciplineId { get; set; }
    public string Performance { get; set; } = null!;
    public Athlete? Athlete { get; set; } = null!;
    public DateTime Date { get; set; }
    public string Location { get; set; } = null!;
}