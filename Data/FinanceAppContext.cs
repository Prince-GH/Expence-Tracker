

using Expance.Models;
using Microsoft.EntityFrameworkCore;

namespace Expance.Data
{
    public class FinanceAppContext : DbContext
    {
        public FinanceAppContext(DbContextOptions<FinanceAppContext> options) : base(options)
        {

        }


        // Create the instance of the context class
        public DbSet<FinanceApp> Expances { get; set; }

    }
}
