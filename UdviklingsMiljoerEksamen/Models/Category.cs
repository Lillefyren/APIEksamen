using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UdviklingsMiljoerEksamen.Models
{
    public class Category
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        //for at kunne finde alle produkter som hører under denne katagori
        public virtual ICollection<Product> Products { get; set; }
    }
}
