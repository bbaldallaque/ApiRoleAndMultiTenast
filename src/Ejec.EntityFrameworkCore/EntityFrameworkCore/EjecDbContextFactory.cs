using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using Ejec.Configuration;
using Ejec.Web;

namespace Ejec.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class EjecDbContextFactory : IDesignTimeDbContextFactory<EjecDbContext>
    {
        public EjecDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<EjecDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            EjecDbContextConfigurer.Configure(builder, configuration.GetConnectionString(EjecConsts.ConnectionStringName));

            return new EjecDbContext(builder.Options);
        }
    }
}
