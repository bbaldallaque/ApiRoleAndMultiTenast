using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using Ejec.Authorization.Roles;
using Ejec.Authorization.Users;
using Ejec.MultiTenancy;

namespace Ejec.EntityFrameworkCore
{
    public class EjecDbContext : AbpZeroDbContext<Tenant, Role, User, EjecDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public EjecDbContext(DbContextOptions<EjecDbContext> options)
            : base(options)
        {
        }
    }
}
