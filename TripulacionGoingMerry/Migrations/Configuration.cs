namespace TripulacionGoingMerry.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using TripulacionGoingMerry.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<TripulacionGoingMerry.DAL.TripContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(TripulacionGoingMerry.DAL.TripContext context)
        {
            var tripulantes = new List<Tripulants>
            {
                new Tripulants {ID = 1, Name="lufy",EnrollmentDate= DateTime.Parse("2023-08-14")},
                new Tripulants {ID = 2, Name="camilo",EnrollmentDate= DateTime.Parse("2023-08-15")}
            };
            tripulantes.ForEach(t => { context.Tripulants.AddOrUpdate(t); });

            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension metho
            //  to avoid creating duplicate seed data.
        }
    }
}
