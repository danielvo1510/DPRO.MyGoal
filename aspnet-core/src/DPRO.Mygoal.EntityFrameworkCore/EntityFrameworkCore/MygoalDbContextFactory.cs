using DPRO.Mygoal.Configuration;
using DPRO.Mygoal.Web;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.Extensions.Configuration;

namespace DPRO.Mygoal.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class MygoalDbContextFactory : IDbContextFactory<MygoalDbContext>
    {
        public MygoalDbContext Create(DbContextFactoryOptions options)
        {
            var builder = new DbContextOptionsBuilder<MygoalDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            MygoalDbContextConfigurer.Configure(builder, configuration.GetConnectionString(MygoalConsts.ConnectionStringName));
            
            return new MygoalDbContext(builder.Options);
        }
    }
}