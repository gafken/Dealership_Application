using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Dealship_App.Models
{
    public class User
    {
        public int id;
        public string firstName;
        public string lastName;
        List<Vehicles> vehiclesPurchased = new List<Vehicles>();
        bool crudAccess;
    }

    public class UserDBContext : DbContext
    {
        public DbSet<User> Users { get; set; }
    }
}