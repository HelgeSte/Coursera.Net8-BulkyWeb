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

        // write "ctor" and press tab, to create a constructor

        public DbSet<Category> Categories { get; set; }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Action", DisplayOrder = 1 },
                new Category { Id = 2, Name = "SciFi", DisplayOrder = 2 },
                new Category { Id = 3, Name = "History", DisplayOrder = 3 }
                );  // run add-migration <migration-name> + update-database
        }

        /* Ekstra informasjon */
        /* To add this to the database */
        /* 1. Open Package Manage Console
         * 2. Add database: 
         *      update-database
         * 3. To add migration:
         *      add-migration <MigrationName>
         * 4. To add migration to database:
         * update-database
         */

        /* Proper way to rename a table safely, without deleting content:

            After generating the migration:
                Add-Migration RenameTable

        Open the migration file and change it to:
            migrationBuilder.RenameTable(
                name: "OldName",
                newName: "NewName");
        */
    }
}
