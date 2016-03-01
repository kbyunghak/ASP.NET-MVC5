using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataModel.Models
{
    public class SeedData
    {
        public static void Initialize(PlayerContext db)
        {
            if (!db.Players.Any())
            {
                db.Players.Add(new Player
                {
                    FirstName = "Bob",
                    LastName = "Doe",
                    Position = "ST"
                });
                db.Players.Add(new Player
                {
                    FirstName = "Ann",
                    LastName = "Lee",
                    Position = "DMF"
                });
                db.Players.Add(new Player
                {
                    FirstName = "Sue",
                    LastName = "Douglas",
                    Position = "MF"
                });
                db.Players.Add(new Player
                {
                    FirstName = "Tom",
                    LastName = "Brown",
                    Position = "Business"
                });
                db.Players.Add(new Player
                {
                    FirstName = "Joe",
                    LastName = "Mason",
                    Position = "MF"
                });

                db.SaveChanges();
            }
        }

    }
}
