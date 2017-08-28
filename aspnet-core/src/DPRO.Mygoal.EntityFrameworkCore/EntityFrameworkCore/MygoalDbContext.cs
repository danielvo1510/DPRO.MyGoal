using Abp.Zero.EntityFrameworkCore;
using DPRO.Mygoal.Authorization.Roles;
using DPRO.Mygoal.Authorization.Users;
using DPRO.Mygoal.MultiTenancy;
using Microsoft.EntityFrameworkCore;

namespace DPRO.Mygoal.EntityFrameworkCore
{
    public class MygoalDbContext : AbpZeroDbContext<Tenant, Role, User, MygoalDbContext>
    {
        /* Define an IDbSet for each entity of the application */
        
        public MygoalDbContext(DbContextOptions<MygoalDbContext> options)
            : base(options)
        {

        }
    }
}
