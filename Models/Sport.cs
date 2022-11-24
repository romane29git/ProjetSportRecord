public class Sport
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public string Description { get; set; } = null!;
    public List<Discipline> Disciplines { get; set; } = null!;
}