using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using Saho.SchoolManagementSystem.Configuration;
using Saho.SchoolManagementSystem.Web;

namespace Saho.SchoolManagementSystem.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class SchoolManagementSystemDbContextFactory : IDesignTimeDbContextFactory<SchoolManagementSystemDbContext>
    {
        public SchoolManagementSystemDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<SchoolManagementSystemDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            SchoolManagementSystemDbContextConfigurer.Configure(builder, configuration.GetConnectionString(SchoolManagementSystemConsts.ConnectionStringName));

            return new SchoolManagementSystemDbContext(builder.Options);
        }
    }
}
