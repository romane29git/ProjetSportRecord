public class Sport
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public char Gender { get; set; }
    public List<Discipline> Disciplines { get; set; } = null!;
}