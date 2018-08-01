using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_1
{
    public class MenuRepository
    {
        public List<Menu> _menuitems = new List<Menu>();

        public void AddItemToList(Menu items)
        {
            _menuitems.Add(items);
        }
        public List<Menu> GetList()
        {
            return _menuitems;
        }
        public void RemoveItemFromList(string Name)
        {
            int theIndex = _menuitems.FindIndex(menu => menu.Name == Name);
            _menuitems.RemoveAt(theIndex);

        }   
    }
}
