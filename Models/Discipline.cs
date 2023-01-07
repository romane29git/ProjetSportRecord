using System.ComponentModel.DataAnnotations.Schema;

public class Discipline
{
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public string Description { get; set; } = null!;
    public int SportId { get; set; }
}