namespace CodeFirstStuff.Migrations.NhlMigrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using Models.NHL;
    using Models.Db;
    internal sealed class Configuration : DbMigrationsConfiguration<CodeFirstStuff.Models.Db.NhlContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            MigrationsDirectory = @"Migrations\NhlMigrations";
        }

        protected override void Seed(CodeFirstStuff.Models.Db.NhlContext context)
        {

            context.Teams.AddOrUpdate(
              p => p.TeamName,
              getTeams().ToArray()
            );
            context.SaveChanges();

            context.Players.AddOrUpdate(
              p => new { p.JerseyNumber, p.FirstName, p.LastName },
              getPlayers(context).ToArray()
            );

            context.SaveChanges();

        }

        private List<Team> getTeams()
        {
            List<Team> teams = new List<Team>()
            {
              new Team {
                  TeamName ="Canucks",
                  City ="Vancouver",
                  Province ="BC" ,
                  SalaryCap =71.4M,
                  CaptainJerseyNumber =33,
                  Manager ="Trvor Linden"
              },
              new Team {
                  TeamName = "Oilers",
                  City = "Edmonton",
                  Province = "Alberta",
                  SalaryCap = 61.4M,
                  CaptainJerseyNumber = 45,
                  Manager = "Bob Smith"
              },
              new Team {
                  TeamName = "Flames",
                  City = "Calgary",
                  Province = "Alberta",
                  SalaryCap = 70.4M,
                  CaptainJerseyNumber = 66,
                  Manager = "Tom Jones"
              }

            };

            return teams;
        }

        private List<Player> getPlayers(NhlContext context)
        {
            List<Player> players = new List<Player>()
            {
              new Player
              {
                  JerseyNumber = "33",
                  FirstName = "Henrik",
                  LastName = "Sedin",
                  IsRight = false,
                  Position = "Center",
                  Salary = 6.5M,
                  TeamName = context.Teams.Find("Canucks").TeamName,
                  StartDate = new DateTime(2005, 9, 1)
              },
              new Player
              {
                  JerseyNumber = "22",
                  FirstName = "Daniel",
                  LastName = "Sedin",
                  IsRight = false,
                  Position = "Left wing",
                  Salary = 6.5M,
                  TeamName = context.Teams.Find("Canucks").TeamName,
                  StartDate = new DateTime(2005, 9, 1)
              },
              new Player
              {
                  JerseyNumber = "30",
                  FirstName = "Ryan",
                  LastName = "Miller",
                  IsRight = false,
                  Position = "Goalie",
                  Salary = 4.5M,
                  TeamName = context.Teams.Find("Canucks").TeamName,
                  StartDate = new DateTime(2015, 9, 1)
              },
              new Player
              {
                  JerseyNumber = "25",
                  FirstName = "Jacob",
                  LastName = "Markstrom",
                  IsRight = true,
                  Position = "Goalie",
                  Salary = 4.0M,
                  TeamName = context.Teams.Find("Canucks").TeamName,
                  StartDate = new DateTime(2015, 10, 1)
              },
              new Player
              {
                  JerseyNumber = "25",
                  FirstName = "Darnell",
                  LastName = "Nurse",
                  IsRight = false,
                  Position = "Defencemen",
                  Salary = 6.0M,
                  TeamName = context.Teams.Find("Oilers").TeamName,
                  StartDate = new DateTime(2013, 7, 1)
              },
              new Player
              {
                  JerseyNumber = "88",
                  FirstName = "Brandon",
                  LastName = "Davidson",
                  IsRight = false,
                  Position = "Defencemen",
                  Salary = 5.9M,
                  TeamName = context.Teams.Find("Oilers").TeamName,
                  StartDate = new DateTime(2013, 11, 1)
              },
              new Player
              {
                  JerseyNumber = "1",
                  FirstName = "Jonas",
                  LastName = "Hiller",
                  IsRight = true,
                  Position = "Goalie",
                  Salary = 5.9M,
                  TeamName = context.Teams.Find("Flames").TeamName,
                  StartDate = new DateTime(2014, 11, 1)
              },
              new Player
              {
                  JerseyNumber = "8",
                  FirstName = "Chris",
                  LastName = "Tanev",
                  IsRight = true,
                  Position = "Defense",
                  Salary = 2.3M,
                  TeamName = context.Teams.Find("Flames").TeamName,
                  StartDate = new DateTime(2015, 10, 15)
              }
            };

            return players;
        }
    }
}
