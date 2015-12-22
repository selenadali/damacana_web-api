﻿
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace damacana_web_api.Models
{
    public class Cart
    { 
        public int Id { get; set; }
        [Required]
        public virtual User User { get; set; }
        public DateTime DateTime { get; set; }
       
        public List<Product> cartproducts { get; set; }
        public decimal TotalPrice { get; set; }

        //Foreign Key
        public int UserId { get; set; }
  

    }

}
