using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace AirportApp
{
    internal class MyDBInitializer<T> : CreateDatabaseIfNotExists<AirportModel>
    {
        protected override void Seed(AirportModel airport)
        {
            List<User> users = new List<User>();

            users.Add(new User()
            {
                Name = "Example",
                Surname = "User",
                Email = "exmaple@gmail.com",
                Password = Encryption.CalculateSHA256("password"),
                Admin = false
            });

            users.Add(new User()
            {
                Name = "Admin",
                Surname = "Admin",
                Email = "admin@gmail.com",
                Password = Encryption.CalculateSHA256("admin123"),
                Admin = true
            });

            foreach(User user in users)
                airport.Users.Add(user);
            base.Seed(airport);
        }
    }
}
