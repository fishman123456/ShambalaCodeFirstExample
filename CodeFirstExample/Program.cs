using CodeFirstExample.Entity;
using CodeFirstExample.RdbService;
using CodeFirstExample.Service;
using CodeFirstExample.ServiceMock;

// процедура тестирования работы сервиса MenuItem
void TestMenuItem(IMenuItemSerivce service)
{
    // 1. получить все записи
    List<MenuItem> menuItems = service.GetMenu();
    if (menuItems.Count == 0)
    {
        // 2. если таблица пустая, то добавить записи
        var egg = service.Add(new MenuItem()
        {
            Title = "яйцо",
            Calories = 157,
            Proteins = 13,
            Fats = 11,
            Carbohydrates = 1,
            Weight = 75
        });
        menuItems.Add(egg);
        var beef = service.Add(new MenuItem()
        {
            Title = "говядина",
            Calories = 106,
            Proteins = 20,
            Fats = 3,
            Carbohydrates = 0,
            Weight = 100
        });
        menuItems.Add(beef);
        var jelly = service.Add(new MenuItem()
        {
            Title = "мармелад",
            Calories = 321,
            Proteins = 0,
            Fats = 0,
            Carbohydrates = 80,
            Weight = 100
        });
        menuItems.Add(jelly);
    }
    // 3. вывести каждую из записей по id
    foreach (MenuItem item in menuItems)
    {
        MenuItem? found = service.GetMenuItemById(item.Id);
        Console.WriteLine(found);
    }
}

// вызов
TestMenuItem(new RdbItemService());