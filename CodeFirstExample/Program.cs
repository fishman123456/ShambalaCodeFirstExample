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
// процедура тестирования сервиса Ingredient
void TestIngredient(IIngredientService ingredientService, IMenuItemSerivce menuItemSerivce)
{
    // 1. получение всех MenuItem
    List<MenuItem> menuItems = menuItemSerivce.GetMenu();
    foreach (MenuItem menuItem in menuItems)
    {
        // 2. для каждого из нихз получить все ингредиенты
        List<Ingredient> ingredients = ingredientService.GetAll(menuItem.Id);
        if (ingredients.Count == 0)
        {
            // 3. если ингредиенты отсутствуют, то добавить их (по 2)
            ingredientService.Add(new Ingredient()
            {
                Description = $"ingredient#1 {menuItem.Title}",
                Weight = 100,
                MenuItemId = menuItem.Id
            });
            ingredientService.Add(new Ingredient()
            {
                Description = $"ingredient#2 {menuItem.Title}",
                Weight = 100,
                MenuItemId = menuItem.Id
            });
            // и снова вытянуть из БД
            ingredients = ingredientService.GetAll(menuItem.Id);
        }
        // 3. получить по id 
        foreach (Ingredient ing in ingredients)
        {
            Ingredient? ingredient = ingredientService.GetIngredientById(ing.Id);
            Console.WriteLine($"{ingredient} of {ingredient?.MenuItem}");
        }
    }
}