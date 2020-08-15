using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using ABPTest.Configuration;
using ABPTest.Web;

namespace ABPTest.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class ABPTestDbContextFactory : IDesignTimeDbContextFactory<ABPTestDbContext>
    {
        public ABPTestDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<ABPTestDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            ABPTestDbContextConfigurer.Configure(builder, configuration.GetConnectionString(ABPTestConsts.ConnectionStringName));

            return new ABPTestDbContext(builder.Options);
        }
    }
}
