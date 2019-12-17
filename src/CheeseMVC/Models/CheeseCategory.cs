using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CheeseMVC.Models
{
    public class CheeseCategory
    {
        //In Models/, create a new model class named CheeseCategory. 
        //Give it an ID property and a Name property that's a string.
        public int ID { get; set; }

        public string Name { get; set; }
        public IList<Cheese> Cheeses { get; set; }
    }
}
