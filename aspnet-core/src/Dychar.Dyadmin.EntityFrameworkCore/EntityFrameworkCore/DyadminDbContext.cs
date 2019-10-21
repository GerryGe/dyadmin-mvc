using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using Dychar.Dyadmin.Authorization.Roles;
using Dychar.Dyadmin.Authorization.Users;
using Dychar.Dyadmin.MultiTenancy;

namespace Dychar.Dyadmin.EntityFrameworkCore
{
    public class DyadminDbContext : AbpZeroDbContext<Tenant, Role, User, DyadminDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public DyadminDbContext(DbContextOptions<DyadminDbContext> options)
            : base(options)
        {
        }
    }
}
