using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tasks
{
    internal class Context : DbContext
    {
        public Context() : base(@"Data Source=.;Initial Catalog=Educational;Integrated Security=True;") 
        { }


        public DbSet<Department> departments { get; set; }

/**/        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)     // why dbcontextop.. cannot work??????????
        //{

        //}
    }
}
