using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;


namespace Dealship_App.Models
{
    public class Vehicles
    {
        public int id { get; set; }

        public int Year { get; set; }

        public string Make { get; set; }

        public string Model { get; set; }

        public string Color { get; set; }

        public int MPG { get; set; }

        public int MSRP { get; set; }

        public string Image { get; set; }

        public string boughtBy { get; set; }
    }

    public class VehicleDBContext : DbContext
    {
        public DbSet<Vehicles> Vehicle { get; set; }
    }
}