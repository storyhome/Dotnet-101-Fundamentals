using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Business_Challenge_1
{
    public class Menu
    {
        public int MenuNumber { get; set; }
        public string MenuName { get; set; }    
        public string Description { get; set; }
        public string Ingredients { get; set; }
        public decimal Price { get; set; }


        public Menu()
        {
        }

        public Menu(int menuNumber, string menuName, string description, string ingredients, decimal price)
        {
            MenuNumber = menuNumber;
            MenuName = menuName;
            Description = description;
            Ingredients = ingredients;
            Price = price;
        }
    }
}

