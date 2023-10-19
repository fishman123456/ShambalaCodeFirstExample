using CodeFirstExample.Entity;
using CodeFirstExample.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstExample.RdbService
{
    // имплементация интерфейса, работающая с БД
    internal class RdbItemService : IMenuItemSerivce
    {

        public MenuItem Add(MenuItem item)
        {
            using (var db = new ApplicationDbContext())
            {
                db.Add(item);
                db.SaveChanges();
                return item;
            }
        }

        public List<MenuItem> GetMenu()
        {
            using (var db = new ApplicationDbContext())
            {
                return db.MenuItems.ToList();
            }
        }

        public MenuItem? GetMenuItemById(int id)
        {
            using (var db = new ApplicationDbContext())
            {
                return db.MenuItems.FirstOrDefault(item => item.Id == id);
            }
        }
    }
}
