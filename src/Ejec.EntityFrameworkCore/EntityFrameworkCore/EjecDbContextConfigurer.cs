using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace Ejec.EntityFrameworkCore
{
    public static class EjecDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<EjecDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<EjecDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
