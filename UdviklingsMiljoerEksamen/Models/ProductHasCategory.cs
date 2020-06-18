using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UdviklingsMiljoerEksamen.Models
{
    public class ProductHasCategory
    {
        //Når oversat til en sql database lader denne fil de to modeller oprette en one-to-many relationship

        public int ProductId { get; set; }
        public int CategoryId { get; set; }

        public virtual Product Product { get; set; }
        public virtual Category Category { get; set; }
    }
}
