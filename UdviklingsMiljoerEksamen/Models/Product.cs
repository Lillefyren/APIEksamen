using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UdviklingsMiljoerEksamen.Models
{
    public class Product
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string Unit { get; set; }

        public int Amount { get; set; }

        public int Price { get; set; }

        //Til kunne tilføje en tilhørende katagori
        public virtual Category Catagory { get; set; }
    }
}
