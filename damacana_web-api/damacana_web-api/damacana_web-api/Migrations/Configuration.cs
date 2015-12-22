namespace damacana_web_api.Migrations
{
    using damacana_web_api.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<damacana_web_api.Models.damacana_web_apiContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }
       protected override void Seed(damacana_web_api.Models.damacana_web_apiContext context){
                
                context.Products.AddOrUpdate(x => x.Id,
                new Product() { Id = 1, Name = "Erikli", Price=10},
                new Product() { Id = 2, Name = "Hayat" , Price=10},
                new Product() { Id = 3, Name = "Sirma" , Price=10}
            );
                  }
    }
}