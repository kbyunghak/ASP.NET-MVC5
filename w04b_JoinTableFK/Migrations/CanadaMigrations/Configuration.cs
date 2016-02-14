namespace CodeFirstStuff.Migrations.CanadaMigrations
{
    using System.Collections.Generic;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using Models.Canada;
    using Models.Db;

    internal sealed class Configuration : DbMigrationsConfiguration<CodeFirstStuff.Models.Db.CanadaContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            MigrationsDirectory = @"Migrations\CanadaMigrations";
        }

        //  protected override void Seed(CodeFirstStuff.Models.Db.CanadaContext context)
        // {
        //  This method will be called after migrating to the latest version.

        //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
        //  to avoid creating duplicate seed data. E.g.
        //
        //    context.People.AddOrUpdate(
        //      p => p.FullName,a
        //      new Person { FullName = "Andrew Peters" },
        //      new Person { FullName = "Brice Lambson" },
        //      new Person { FullName = "Rowan Miller" }
        //    );
        //
        // }


        protected override void Seed(CodeFirstStuff.Models.Db.CanadaContext context)
        {

            context.Provinces.AddOrUpdate(
              p => p.ProvinceCode,
              getProvinces().ToArray()
            );
            context.SaveChanges();

            context.Cities.AddOrUpdate(
              p => new { p.CityId },
              getCities(context).ToArray()
            );

            context.SaveChanges();

        }

        private List<Province> getProvinces()
        {
            List<Province> provinces = new List<Province>()
            {
              new Province {
                  ProvinceName ="British Columbia",
                  ProvinceCode ="BC"
              },
              new Province {
                  ProvinceName ="NewFoundLand",
                  ProvinceCode ="NL"
              },
              new Province {
                  ProvinceName ="Alberta",
                  ProvinceCode ="AL"
              }

            };

            return provinces;
        }

        private List<City> getCities(CanadaContext context)
        {
            List<City> cities = new List<City>()
            {
              new City
              {
                  CityId = 1,
                  CityName = "Vancouver",
                  Papulation = "10000",
                  ProvinceCode = context.Provinces.Find("BC").ProvinceCode,

              },
              new City
              {
                  CityId = 3,
                  CityName = "SaintJohn's",
                  Papulation = "200",
                  ProvinceCode = context.Provinces.Find("NL").ProvinceCode
              }
            };

            return cities;
        }
    }
}
