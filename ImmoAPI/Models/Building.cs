using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ImmoAPI.Models
{
    public class Building
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public decimal Price { get; set; }
    }
}