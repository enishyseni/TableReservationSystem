using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Persistence
{
    public class DevDataContext : IDesignTimeDbContextFactory<DataContext>
    {
            public DataContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<DataContext>();
            builder.EnableSensitiveDataLogging(true);
            builder.UseSqlServer("Data Source=SQL5101.site4now.net;Initial Catalog=db_a6e02b_trs;User Id=db_a6e02b_trs_admin;Password=1a2b3c4d5e@;Encrypt=False");
            
            return new DataContext(builder.Options);
        }
    }

        
    }
