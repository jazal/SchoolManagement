using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using Saho.SchoolManagementSystem.Authorization.Roles;
using Saho.SchoolManagementSystem.Authorization.Users;
using Saho.SchoolManagementSystem.MultiTenancy;

namespace Saho.SchoolManagementSystem.EntityFrameworkCore
{
    public class SchoolManagementSystemDbContext : AbpZeroDbContext<Tenant, Role, User, SchoolManagementSystemDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public SchoolManagementSystemDbContext(DbContextOptions<SchoolManagementSystemDbContext> options)
            : base(options)
        {
        }
    }
}
