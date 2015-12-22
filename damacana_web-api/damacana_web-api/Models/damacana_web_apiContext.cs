using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace damacana_web_api.Models
{
    public class damacana_web_apiContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public damacana_web_apiContext() : base("name=damacana_web_apiContext")
        {
                        this.Database.Log = s => System.Diagnostics.Debug.WriteLine(s);
        }

        public System.Data.Entity.DbSet<damacana_web_api.Models.Product> Products { get; set; }

        public System.Data.Entity.DbSet<damacana_web_api.Models.Cart> Carts { get; set; }

        public System.Data.Entity.DbSet<damacana_web_api.Models.User> Users { get; set; }

        public System.Data.Entity.DbSet<damacana_web_api.Models.Purchase> Purchases { get; set; }
    
    }
}
