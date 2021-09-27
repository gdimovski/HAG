using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HAG.Models
{
    public class Client
    {
        [Key]
        public long id { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string address { get; set; }
        public string phone { get; set; }

        public Client() { }
        
    }
}