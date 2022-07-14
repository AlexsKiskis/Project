using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace workingversion
{
    class AppContext:DbContext
    {
        public DbSet<Table> Tables { get; set; }
        public AppContext() : base("DefaultConnection") { }
    }
}
