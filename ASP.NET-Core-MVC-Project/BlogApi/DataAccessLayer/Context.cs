using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogApi.DataAccessLayer
{
    public class Context : DbContext
    {
        
        public DbSet <Employee> Employees { get; set; }
    }
}
