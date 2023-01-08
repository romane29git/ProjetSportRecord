using System.ComponentModel.DataAnnotations;

public class Athlete
{
    public int Id { get; set; }

    [Display(Name = "Nom")]
    public string LastName { get; set; } = null!;

    [Display(Name = "Prénom")]
    public string FirstName { get; set; } = null!;

    [Display(Name = "Genre")]
    public char Gender { get; set; }

    [Display(Name = "Date de naissance")]
    public DateTime BirthDate { get; set; }

    [Display(Name = "Nationalité")]
    public string Nationality { get; set; } = null!;

    public Discipline? Discipline { get; set; } = null!;

    // Constructeur vide par défaut
    public Athlete() { }

    public Athlete(AthleteDTO dto)
    {
        Id = dto.Id;
        LastName = dto.LastName;
        FirstName = dto.FirstName;
        Gender = dto.Gender;
        BirthDate = dto.BirthDate;
        Nationality = dto.Nationality;
    }
}
