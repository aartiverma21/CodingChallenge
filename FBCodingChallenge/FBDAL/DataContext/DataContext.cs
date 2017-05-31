using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FBDAL.Entity;

namespace FBDAL.DataContext
{
    public partial class DataContext : DbContext
    {
        public DataContext()
            : base("name=DataContext")
        {
        }
        public virtual DbSet<User> UserDetail { get; set; }
    }
}
