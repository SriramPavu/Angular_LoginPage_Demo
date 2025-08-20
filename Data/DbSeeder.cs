using LoginPageDemo.Models;
using BCrypt.Net;
namespace LoginPageDemo.Data
{
    public class DbSeeder
    {
        public static void Seed(AppDbContext db)
        {
            if (!db.Users.Any())
            {
                var pwd = BCrypt.Net.BCrypt.HashPassword("P@ssw0rd!");
                db.Users.Add(new User { Email = "test@example.com", PasswordHash = pwd, FullName = "Demo User" });
            }

            if (!db.GridItems.Any())
            {
                var rnd = new Random();
                var cities = new[] { "New York", "London", "Paris", "Bangalore", "Tokyo" };
                for (var i = 1; i <= 10; i++)
                {
                    db.GridItems.Add(new GridItem
                    {
                        Name = $"Person {i}",
                        City = cities[rnd.Next(cities.Length)],
                        Age = rnd.Next(18, 65),
                        Status = rnd.Next(2) == 0 ? "Active" : "Inactive",
                        CreatedOn = DateTime.UtcNow.AddDays(-rnd.Next(0, 365))
                    });
                }
            }
            db.SaveChanges();
        }
    }
}
    }
}
