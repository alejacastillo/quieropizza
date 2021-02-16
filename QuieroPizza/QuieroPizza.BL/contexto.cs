using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuieroPizza.BL
{
   public class Contexto : DbContext
    {
        public Contexto(): base(@"Data Source = (LocalDB)\MSSQLLocalDB;AttachDBFilename=" +
            Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\QuieroPizzaDB.mdf")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

        }


        public DbSet <Producto> Productos { get; set; }
    }
}
