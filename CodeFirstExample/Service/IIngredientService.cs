using CodeFirstExample.Entity;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstExample.Service
{
        // Сервис для работы с ингредиентами
        internal interface IIngredientService
        {
            // 1. добавить новый ингредиент
            Ingredient Add(Ingredient ingredient);

            // 2. получить все ингредиенты определенного MenuItem
            List<Ingredient> GetAll(int menuItemId);

            // 3. получить ингредиент по id
            Ingredient? GetIngredientById(int id);
        }
}
