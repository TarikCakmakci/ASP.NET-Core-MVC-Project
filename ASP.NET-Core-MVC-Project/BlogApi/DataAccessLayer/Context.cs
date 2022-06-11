using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogApi.DataAccessLayer
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=78.135.105.238;Database=u7174244_Pro;User Id=u7174244_Pro; Password=AE7A70C1-13DB-4D9E-9C1E-07D0856700DE;");
        }
        public DbSet <Employee> Employees { get; set; }
    }
}
