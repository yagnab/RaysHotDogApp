namespace RaysHotDogApp.WebService.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using Models;
    using System.Collections.Generic;

    internal sealed class Configuration : DbMigrationsConfiguration<RaysHotDogApp.WebService.Models.RaysAppContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "RaysHotDogApp.WebService.Models.RaysAppContext";
        }

        protected override void Seed(RaysHotDogApp.WebService.Models.RaysAppContext context)
        {
            
        }
    }
}
