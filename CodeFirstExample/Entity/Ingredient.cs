using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstExample.Entity
{
    internal class Ingredient
    {
        // Сущность, описывающая пункт состава блюда из меню
       
            // 1. идентификатор
            public int Id { get; set; }

            // 2. описание
            public string Description { get; set; }

            // 3. вес в граммах
            public int Weight { get; set; }

        // реализация через внешний ключ
        public int MenuItemId {  get; set; }
        //реализация через агрегацию - посредством навигационных свойств
        public MenuItem? MenuItem { get; set; }
            public Ingredient()
            {
                Description = "";
            MenuItem = null;
            }

            public override string ToString()
            {
                return $"{Id} - {Description} - {Weight} g.";
            }
        }
    }

