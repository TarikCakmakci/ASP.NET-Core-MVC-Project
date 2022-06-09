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
            optionsBuilder.UseSqlServer(@"Server=78.135.105.238;Database=u7174244_ProBudy;User Id=u7174244_ProBudy; Password=KYyp18Q1HPaj97N;");
        }
    }
}
