using CodeFirstExample.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstExample.Service
{
    // Интерфейс бизнес-логики для взаимодействия с сущностью MenuItem
    internal interface IMenuItemSerivce
    {
        // 1. добавить запись
        MenuItem Add(MenuItem item);
        // 2. получить все
        List<MenuItem> GetMenu();
        // 3. получить по id
        MenuItem? GetMenuItemById(int id);
    }
}
