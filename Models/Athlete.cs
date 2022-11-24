public class Athlete
{
    public int Id { get; set; }
    public string LastName { get; set; } = null!;
    public string FirstName { get; set; } = null!;
    public int Age { get; set; }
    public string BriefDescription { get; set; } = null!;
    public string Nationality { get; set; } = null!;
    public Discipline Discipline { get; set; } = null!;

}