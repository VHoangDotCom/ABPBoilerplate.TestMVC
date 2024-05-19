using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace CompanyManagement.EntityFrameworkCore
{
    public static class CompanyManagementDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<CompanyManagementDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<CompanyManagementDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
