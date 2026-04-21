using BulkyWeb.Models;
using Microsoft.EntityFrameworkCore;

namespace BulkyWeb.Data
{
    public class ApplicationDbContext : DbContext
    {
        // base(options) => whatever options we configure ​here will be passed on to the base class of ​TP context. 
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }

        public DbSet<Category> Categories { get; set; }

        /* To add this to the database */
        /* 1. Open Package Manage Console
         * 2. Add database: 
         *      update-database
         * 3. To add migration:
         *      add-migration <MigrationName>
         * 4. To add migration to database:
         * update-database
         */
    }
}
