namespace Projekt7Edyszyn.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using Projekt7Edyszyn.Models;
    using System.Collections.Generic;

    internal sealed class Configuration : DbMigrationsConfiguration<Projekt7Edyszyn.DAL.TraningContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Projekt7Edyszyn.DAL.TraningContext context)
        {

            var tranings = new List<Traning>
            {
                new Traning { DST = "3.235", TM = "03:20:21", AVG = "23.5", MAX = "32.5",KM1 = "2:02", DATE = "2017-05-11 15:21:41", TEMP = "23", WEATHER = "poogdna", ENDMNDO = "adadada"},
                new Traning { DST = "8.235", TM = "03:25:21", AVG = "22", MAX = "26",KM1 = "1:20", DATE = "2017-05-91 15:21:41", TEMP = "23", WEATHER = "poogdna", ENDMNDO = "adadada"}
            };
            tranings.ForEach(t => context.Tranings.AddOrUpdate(r => r.DST, t));
            context.SaveChanges();
       
        }
    }
}
