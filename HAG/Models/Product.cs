using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HAG.Models
{
    public class Product
    {
        public long id { get; set; }
        public string name { get; set; }
        public long price { get; set; }
        public string category { get; set; }
        public string image { get; set; }
        public Product() { }

        public Product(long id, string name, long price, string category, string image)
        {
            this.id = id;
            this.name = name;
            this.price = price;
            this.category = category;
            this.image = image;
        }

        

    }
    
}