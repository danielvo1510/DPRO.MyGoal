using Microsoft.EntityFrameworkCore;

namespace DPRO.Mygoal.EntityFrameworkCore
{
    public static class MygoalDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<MygoalDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }
    }
}