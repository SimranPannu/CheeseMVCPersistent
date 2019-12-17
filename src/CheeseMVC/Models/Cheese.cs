using System.Collections.Generic;

namespace CheeseMVC.Models
{
    public class Cheese
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        //for part 2
        
        public CheeseCategory Category { get; set; }
        public int CheeseCategoryID { get; set; }

        public IList<CheeseMenu> CheeseMenu { get; set; }

    }
}
