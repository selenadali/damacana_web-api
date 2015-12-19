using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Web;

namespace damacana_web_api.Models
{
    public class User
    { 
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public virtual ICollection<Cart> Carts { get; set; }
        public virtual ICollection<Purchase> Purchases { get; set; }
    }
}

