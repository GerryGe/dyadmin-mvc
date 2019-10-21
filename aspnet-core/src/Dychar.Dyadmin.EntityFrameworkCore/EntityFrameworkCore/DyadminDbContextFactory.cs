using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using Dychar.Dyadmin.Configuration;
using Dychar.Dyadmin.Web;

namespace Dychar.Dyadmin.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class DyadminDbContextFactory : IDesignTimeDbContextFactory<DyadminDbContext>
    {
        public DyadminDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<DyadminDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            DyadminDbContextConfigurer.Configure(builder, configuration.GetConnectionString(DyadminConsts.ConnectionStringName));

            return new DyadminDbContext(builder.Options);
        }
    }
}
