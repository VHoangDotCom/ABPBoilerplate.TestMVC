using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using CompanyManagement.Authorization.Roles;
using CompanyManagement.Authorization.Users;
using CompanyManagement.MultiTenancy;

namespace CompanyManagement.EntityFrameworkCore
{
    public class CompanyManagementDbContext : AbpZeroDbContext<Tenant, Role, User, CompanyManagementDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public CompanyManagementDbContext(DbContextOptions<CompanyManagementDbContext> options)
            : base(options)
        {
        }
    }
}
