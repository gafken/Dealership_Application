namespace Dealship_App.Migrations
{
    using Dealship_App.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Dealship_App.Models.VehicleDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Dealship_App.Models.VehicleDBContext context)
        {
            context.Vehicle.AddOrUpdate(i => i.id,
                new Vehicles()
                {
                    id = 1,
                    Year = 2015,
                    Make = "Chevrolet",
                    Model = "Camaro",
                    Color = "Black",
                    MPG = 25,
                    MSRP = 25000

                },

                new Vehicles()
                {
                    id = 2,
                    Year = 2015,
                    Make = "Mitsubishi",
                    Model = "Lancer",
                    Color = "Blue",
                    MPG = 30,
                    MSRP = 17500
                },

                new Vehicles()
                {
                    id = 3,
                    Year = 2015,
                    Make = "Audi",
                    Model = "A8",
                    Color = "White",
                    MPG = 20,
                    MSRP = 115000
                },

                new Vehicles()
                {
                    id = 4,
                    Year = 2015,
                    Make = "Tesla",
                    Model = "Roadster",
                    Color = "Gold",
                    MPG = 245,
                    MSRP = 101500
                }
                );
        }
    }
}
