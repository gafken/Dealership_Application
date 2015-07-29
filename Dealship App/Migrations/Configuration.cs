namespace Dealship_App.Migrations
{

    using Dealship_App.Models;

    using System;

    using System.Data.Entity;

    using System.Data.Entity.Migrations;

    using System.Linq;

    using System.Collections.Generic;

    using Microsoft.AspNet.Identity;

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

                MSRP = 25000,

                Image = "http://www.chevrolet.com/content/dam/Chevrolet/northamerica/usa/nscwebsite/en/Home/Vehicles/Cars/2015_Camaro/Model_Overview/01_images/2015-chevrolet-camaro-sports-car-mo-accessories-648x316-04.jpg"

            },

            new Vehicles()

            {

                id = 2,

                Year = 2015,

                Make = "Mitsubishi",

                Model = "Lancer",

                Color = "Blue",

                MPG = 30,

                MSRP = 17500,

                Image = "http://milliwall.com/wp-content/uploads/2015/03/2015-Mitsubishi-Lancer-27-HD-Image.jpg"

            },

            new Vehicles()

            {

                id = 3,

                Year = 2015,

                Make = "Audi",

                Model = "A8",

                Color = "White",

                MPG = 20,

                MSRP = 115000,

                Image = "http://hdwallpapersfit.com/wp-content/uploads/2015/02/audi-r8-wallpapers-white-hd.jpg"

            },

            new Vehicles()

            {

                id = 4,

                Year = 2015,

                Make = "Tesla",

                Model = "Roadster",

                Color = "Gold",

                MPG = 245,

                MSRP = 101500,

                Image = "http://www.cheatsheet.com/wp-content/uploads/2013/05/Model-X-Tesla-Motors-e1369767002520.jpg?628ad9"

            }

            );

        }

    }

}