using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace Saho.SchoolManagementSystem.EntityFrameworkCore
{
    public static class SchoolManagementSystemDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<SchoolManagementSystemDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<SchoolManagementSystemDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
