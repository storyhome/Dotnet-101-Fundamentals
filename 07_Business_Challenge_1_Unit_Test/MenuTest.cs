using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using _07_Business_Challenge_1;

namespace _07_Business_Challenge_1_Unit_Test
{
    [TestClass]
    public class MenuTest
    {
        private Menu _menu_1;
        private Menu _menu_2;
        private Menu _menu_3;
       
        private List<Menu> _menusList = new List<Menu>();


        [TestInitialize]
        public void Arrange()
        {
            _menu_1 = new Menu
            {
                MenuNumber = 1,
                MenuName = "Chesseburger",
                Description = "Swiss on Wheat Bun",
                Ingredients = "Swiss Cheese, Groundbeef,Wheat Bun ",
                Price = 6.78m
            };
            _menu_2 = new Menu
            {
                MenuNumber = 2,
                MenuName = "Cheese Fries",
                Description = "Loaded Fries",
                Ingredients = "Potatos,Bacon, Special Sauce ",
                Price = 4.78m
            };

            _menu_3 = new Menu
            {
                MenuNumber = 3,
                MenuName = "Plain Fries",
                Description = "No extra just potatos",
                Ingredients = "Potatos",
                Price = 1.50m

            
            };

            _menusList.Add(_menu_1);
            _menusList.Add(_menu_2);
            _menusList.Add(_menu_3);
        }
        
        [TestMethod]
        public void TestMethod1()
        {
        }
    }
}
