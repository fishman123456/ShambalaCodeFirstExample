using CodeFirstExample.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstExample.RdbService
{
    internal class ApplicationDbContext : DbContext
    {
        public DbSet<MenuItem> MenuItems { get; set; }  // отображение таблицы MenuItem

        // конфигурация подключения к БД
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=fishman\SQLEXPRESS;
                                            Initial Catalog=code_first_menu_db;
                                            Integrated Security=SSPI;
                                            TrustServerCertificate=True;");
        }
    }
}
