using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace Dychar.Dyadmin.EntityFrameworkCore
{
    public static class DyadminDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<DyadminDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<DyadminDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
