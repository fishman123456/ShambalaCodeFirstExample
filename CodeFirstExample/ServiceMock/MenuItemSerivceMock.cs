using CodeFirstExample.Entity;
using CodeFirstExample.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstExample.ServiceMock
{
    // Имплементация-заглушка
    internal class MenuItemSerivceMock : IMenuItemSerivce
    {
        public static List<MenuItem> menuItems = new List<MenuItem>();
        public static int nextId = 1;
        public MenuItem Add(MenuItem item)
        {
            item.Id = nextId++;
            menuItems.Add(item);
            return item;
        }

        public List<MenuItem> GetMenu()
        {
            return menuItems.ToList();
        }

        public MenuItem? GetMenuItemById(int id)
        {
            return menuItems.FirstOrDefault(item => item.Id == id);
        }
    }
}
