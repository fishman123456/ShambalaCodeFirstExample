using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstExample.Entity
{
    // БД - еда
    // Таблица - еда в меню
    // Поля: id, title, calories, proteins, fats, carbohydrates, weight

    // Класс "Позиция в меню", отображающий записи из БД
    internal class MenuItem
    {
        // поля - столбцы БД
        public int Id { get; set; }             // идентификатор
        public string Title { get; set; }       // название 
        public int Calories { get; set; }       // калории
        public int Proteins { get; set; }       // белки
        public int Fats { get; set; }           // жиры
        public int Carbohydrates { get; set; } // углеводы
        public int Weight { get; set; }         // вес в граммах
        //реализация через агрегацию - посредством навигационных свойств
        public List<Ingredient>? ingredients { get; set; }
        public MenuItem()
        {
            Title = "";
            ingredients = null;
        }

        public override string ToString()
        {
            return $"{Id} - {Title} - {Calories} cal. - " +
                $"p.{Proteins}/f{Fats}/c{Carbohydrates} g/100g - {Weight} g.";
        }
    }
}
