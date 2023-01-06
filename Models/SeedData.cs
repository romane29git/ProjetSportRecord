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

            Sport musculation = new Sport
            {
                Name = "Musculation",
            };

            Sport triathlon = new Sport
            {
                Name = "Triathlon",
            };

            Sport cyclisme = new Sport
            {
                Name = "Cyclisme",
            };

            Sport apnee = new Sport
            {
                Name = "Apnée",
            };

            Sport ski = new Sport
            {
                Name = "Ski",
            };

            Sport rugby = new Sport
            {
                Name = "Rugby",
            };






            //add disciplines

            // Natation
            Discipline brasse200 = new Discipline
            {
                Name = "200m Brasse",
                Description = "Cette épreuve consiste à nager 200 mètres en brasse.",
                SportId = 1
            };

            // Athlétisme
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


            // Musculation
            Discipline souleveTerre = new Discipline
            {
                Name = "Soulevé de terre",
                Description = "Le soulevé de terre est un exercice de musculation qui consiste à soulever une barre de poids au-dessus de la tête.",
                SportId = 3
            };

            Discipline developpeCouche = new Discipline
            {
                Name = "Développé couché",
                Description = "Le développé couché est un exercice de musculation qui consiste à soulever une barre de poids à partir d'une position couchée sur un banc.",
                SportId = 3
            };

            Discipline squat = new Discipline
            {
                Name = "Squat",
                Description = "La flexion sur jambes est un mouvement d'accroupi qui constitue un exercice poly-articulaire de force et de musculation ciblant les muscles de la cuisse et les fessiers.",
                SportId = 3
            };

            Discipline bicepsCurl = new Discipline
            {
                Name = "Biceps curl",
                Description = "La flexion du biceps est un exercice classique de musculation ayant pour cible le muscle biceps brachial",
                SportId = 3
            };



            // Triathlon
            Discipline distanceM = new Discipline
            {
                Name = "Distance M",
                Description = "Le triathlon M est une discipline sportive constituée de trois épreuves d'endurance enchaînées dans l'ordre suivant : 1,5 km de natation, 40 km de cyclisme et 10 km de course à pied. ",
                SportId = 4
            };

            Discipline distanceL = new Discipline
            {
                Name = "Distance L",
                Description = "Le triathlon L est une discipline sportive constituée de trois épreuves d'endurance enchaînées dans l'ordre suivant : 3 km de natation, 80 km de cyclisme et 30 km de course à pied. ",
                SportId = 4
            };

            Discipline distanceXL = new Discipline
            {
                Name = "Distance XL",
                Description = "Le triathlon XL est une discipline sportive constituée de trois épreuves d'endurance enchaînées dans l'ordre suivant : 4 km de natation, 120 km de cyclisme et 30 km de course à pied. ",
                SportId = 4
            };

            Discipline ironMan = new Discipline
            {
                Name = "Iron Man",
                Description = "L'Iron Man est une discipline sportive constituée de trois épreuves d'endurance enchaînées dans l'ordre suivant : 3,8 km de natation, 180 km de cyclisme et 42,195 km de course à pied. ",
                SportId = 4
            };

            //cyclisme

            Discipline routeRecordHeure = new Discipline
            {
                Name = "Record de l'heure sur route",
                Description = "Le record de l'heure est une épreuve cycliste qui se déroule généralement sur route et qui consiste à parcourir la plus grande distance possible en une heure. ",
                SportId = 5
            };

            Discipline routeKmPiste = new Discipline
            {
                Name = "Record au kilomètre sur piste",
                Description = "Le record au km est une épreuve cycliste qui se déroule généralement sur piste et qui consiste à parcourir 1km le plus rapidement possible. ",
                SportId = 5
            };

            Discipline cycloCrossHeure = new Discipline
            {
                Name = "Record de l'heure en CycloCross",
                Description = "Le record de l'heure en cyclocross est une épreuve cycliste qui se déroule généralement sur piste de boue et qui consiste à parcourir la plus grande distance possible en une heure.",
                SportId = 5
            };


            //Apnée

            Discipline duree = new Discipline
            {
                Name = "La plus longue apnée",
                Description = "La discipline consite à rester le plus longtemps possible en apnée statique.",
                SportId = 6
            };

            Discipline distance = new Discipline
            {
                Name = "La plus longue distance",
                Description = "La discipline consite à parcourir la plus longue distance possible en apnée.",
                SportId = 6
            };

            Discipline profonfeur = new Discipline
            {
                Name = "Apnée la plus profonde",
                Description = "La discipline consite à descendre le plus bas possible en apnée avec palmes.",
                SportId = 6
            };

            Discipline distanceGlace = new Discipline
            {
                Name = "La plus longue distance en eau glacée",
                Description = "La discipline consite à parcourir la plus longue distance possible en apnée en eau glacée.",
                SportId = 6
            };

            //ski

            Discipline saut = new Discipline
            {
                Name = "Saut à ski",
                Description = "Le saut à ski est une discipline de la famille du ski nordique et qui consiste à descendre une pente sur une rampe pour décoller en essayant d'aller le plus loin possible.",
                SportId = 7
            };

            Discipline vitesse = new Discipline
            {
                Name = "La plus grande vitesse en ski alpin",
                Description = "Le ski de vitesse consiste à atteindre la plus grande vitesse en ski sans moteur.",
                SportId = 7
            };

            Discipline nbTitre = new Discipline
            {
                Name = "Le plus grand nombre de grand G gagné",
                Description = "Ce record correspond au plus grand nombre de titre de grand Géant remporté.",
                SportId = 7
            };

            //rugby

            Discipline essaiSaison = new Discipline
            {
                Name = "Nombre d'essais en une saison",
                Description = "Ce record correspond au plus grand nombre d'essais inscrits en une saison.",
                SportId = 8
            };

            Discipline essaiCarriere = new Discipline
            {
                Name = "Nombre d'essais dans la carrière",
                Description = "Ce record correspond au plus grand nombre d'essais inscrits dans une carrière.",
                SportId = 8
            };

            Discipline championnatMonde = new Discipline
            {
                Name = "Nombre de championnats du monde remportés",
                Description = "Ce record correspond au plus grand nombre de championnat du monde rempostés.",
                SportId = 8
            };



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


            // context.Disciplines.AddRange(
            // brasse200,
            // sautLongueur,
            //  m200,
            // souleveTerre,
            // developpeCouche,
            // squat,
            // bicepsCurl,
            // distanceM,
            // distanceL,
            // distanceXL,
            // ironMan,
            // routeRecordHeure,
            // routeKmPiste,
            // cycloCrossHeure,
            // duree,
            // distance,
            // profonfeur,
            // distanceGlace,
            // saut,
            // vitesse,
            // nbTitre,
            // essaiCarriere,
            // essaiSaison,
            // championnatMonde
            // );



            //context.Sports.AddRange(
            // natation,
            // athletisme
            // musculation,
            // triathlon,
            // cyclisme,
            // apnee,
            // ski,
            // rugby
            //  );


            // context.Athletes.AddRange(
            //        mikePowell,
            //        emmaReaney,

            // );

            //     context.Records.AddRange(
            //        brasse200F,
            //        sautLongueurH
            //    );

            context.SaveChanges();

        }

    }

}




