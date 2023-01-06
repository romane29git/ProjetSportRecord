using System;

public class SeedData
{
    public static void init()
    {
        using (var context = new SportRecordContext())
        {
            // Add Sport
            Sport natation = new Sport
            {
                Name = "Natation",
            };

            Sport athletisme = new Sport
            {
                Name = "Athlétisme",
            };

            // context.Sports.AddRange(
            //     natation,
            //     athletisme
            // );

            //add disciplines
            Discipline brasse200 = new Discipline
            {
                Name = "200m Brasse",
                Description = "Cette épreuve consiste à nager 200 mètres en brasse.",
                SportId = 1
            };

            Discipline sautLongueur = new Discipline
            {
                Name = "Saut en longueur",
                Description = "Le saut en longueur est une épreuve d'athlétisme consistant à couvrir la plus longue distance possible en sautant, avec de l'élan, à partir d'une marque fixe.",
                SportId = 2
            };

            Discipline m200 = new Discipline
            {
                Name = "200 mètres",
                Description = "Le 200 mètres est une épreuve d'athlétisme consistant à parcourir un demi-tour d'une piste d'athlétisme de 400 m.",
                SportId = 2
            };

            //     context.Disciplines.AddRange(
            //        brasse200,
            //        sautLongueur,
            //        m200
            //    );

            //add atletes
            Athlete mikePowell = new Athlete
            {
                FirstName = "Mike",
                LastName = "Powell",
                BirthDate = DateTime.Parse("1963-11-10"),
                Nationality = "USA",
                Discipline = sautLongueur,
                Gender = 'H'
            };

            Athlete emmaReaney = new Athlete
            {
                FirstName = "Emma",
                LastName = "Reaney",
                BirthDate = DateTime.Parse("1992-10-20"),
                Nationality = "USA",
                Discipline = brasse200,
                Gender = 'F'
            };

            //     context.Athletes.AddRange(
            //        mikePowell,
            //        emmaReaney
            //    );

            //add record
            Record sautLongueurH = new Record
            {
                Discipline = sautLongueur,
                Performance = "8,95 m",
                Athlete = mikePowell,
                Date = DateTime.Parse("1991-08-30"),
                Location = "Tokyo"
            };

            Record brasse200F = new Record
            {
                Discipline = brasse200,
                Performance = "2min 04sec 06",
                Athlete = emmaReaney,
                Date = DateTime.Parse("2014-03-22"),
                Location = "Minneapolis"
            };

            //     context.Records.AddRange(
            //        brasse200F,
            //        sautLongueurH
            //    );

            context.SaveChanges();

        }

    }

}




