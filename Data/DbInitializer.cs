using Library.Models;
using System;
using System.Linq;

namespace Library.Data
{
    public static class DbInitializer
    {
        public static void Initialize(LibraryContext context)
        {
            context.Database.EnsureCreated();

            // Look for any users.
            if (context.Users.Any())
            {
                return;   // DB has been seeded
            }

            var users = new User[]
            {
                new User{ID=1050,FirstMidName="Alex",LastName="DiCaprio"},
                new User{ID=4022,FirstMidName="Max",LastName="Long"},
                new User{ID=4041,FirstMidName="Monika",LastName="Gill"},
                new User{ID=1045,FirstMidName="John",LastName="Hawkins"},
                new User{ID=3141,FirstMidName="Willie",LastName="Joe"}
            };

            foreach (User u in users)
            {
                context.Users.Add(u);
            }
            context.SaveChanges();

            var books = new Book[]
            {
                new Book{ID=1,Name="Carson",Author="Alexander",Date=DateTime.Parse("2005-09-01")},
                new Book{ID=2,Name="Meredith",Author="Alonso",Date=DateTime.Parse("2002-09-01")},
                new Book{ID=3,Name="Arturo",Author="Anand",Date=DateTime.Parse("2003-09-01")},
                new Book{ID=4,Name="Gytis",Author="Barzdukas",Date=DateTime.Parse("2002-09-01")},
                new Book{ID=5,Name="Yan",Author="Li",Date=DateTime.Parse("2002-09-01")},
                new Book{ID=6,Name="Peggy",Author="Justice",Date=DateTime.Parse("2001-09-01")},
                new Book{ID=7,Name="Laura",Author="Norman",Date=DateTime.Parse("2003-09-01")},
                new Book{ID=8,Name="Nino",Author="Olivetto",Date=DateTime.Parse("2005-09-01")}
            };

            foreach (Book b in books)
            {
                context.Books.Add(b);
            }
            context.SaveChanges();

            var loans = new Loan[]
            {
                new Loan{UserID=1050,BookID=1},
                new Loan{UserID=4041,BookID=2},
                new Loan{UserID=4041,BookID=3},
                new Loan{UserID=3141,BookID=4},
                new Loan{UserID=1045,BookID=5}
            };

            foreach (Loan l in loans)
            {
                context.Loans.Add(l);
            }

            context.SaveChanges();
        }
    }
}