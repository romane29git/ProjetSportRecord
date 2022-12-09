public class Athlete
{
    public int Id { get; set; }
    public string LastName { get; set; } = null!;
    public string FirstName { get; set; } = null!;
    public char Gender { get; set; }
    public DateTime BirthDate { get; set; }
    public string Nationality { get; set; } = null!;
    public Discipline? Discipline { get; set; } = null!;

}