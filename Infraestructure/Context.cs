using Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Infraestructure
{
    public class Context : DbContext
    {
        public Context() : base("name = MyContextDB")
        {
        }

        public DbSet<Person> People { get; set; }

        public DbSet<Producto> Productos { get; set; }
    }
}
