using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore;

namespace back_end.DataAccess
{
    public class DbContextFactory : IDesignTimeDbContextFactory<DatabaseContext>
    {
        public DatabaseContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<DatabaseContext>();
            optionsBuilder.UseSqlServer("Server=.; Initial Catalog=ReactTraining; Trusted_Connection=True; TrustServerCertificate=True");

            return new DatabaseContext(optionsBuilder.Options);
        }
    }
}
