using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using ABPTest.Authorization.Roles;
using ABPTest.Authorization.Users;
using ABPTest.MultiTenancy;

namespace ABPTest.EntityFrameworkCore
{
    public class ABPTestDbContext : AbpZeroDbContext<Tenant, Role, User, ABPTestDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public ABPTestDbContext(DbContextOptions<ABPTestDbContext> options)
            : base(options)
        {
        }
    }
}
