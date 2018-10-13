using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Business_Challenge_1
{
    public class MenuRepository
    {
        private List<Menu> _menuList;


        public MenuRepository()
        {
            _menuList = new List<Menu>();
        }
        public List<Menu> GetMenuList()
        {
            return _menuList;


        }

        public void AddMenuItem(Menu menu)
        {
            _menuList.Add(menu);

        }

        public void RemoveMenuItem(int menuNumber)
        {
            foreach (Menu m in _menuList)
            {
                if (m.MenuNumber == menuNumber)
                {
                    _menuList.Remove(m);
                    break;
                }
            }
        }

        public string DisplayMenu()
        {
            var menuList = "";

            foreach (var m in _menuList)
            {
                menuList += m.MenuNumber + " " + m.Description + "\n";
            }

            return menuList;

        }
     
    }
}
