using DropdownTest2.Models;
using Microsoft.EntityFrameworkCore;

namespace DropdownTest2.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<ItemDropdownListViewModel>().HasNoKey();
        }

        public DbSet<PersonaInfo> PersonaInfo { get; set; }
        public DbSet<Department> Department { get; set; }
        public DbSet<SubDepartment> SubDepartment { get; set; }

        public DbSet<ItemDropdownListViewModel> ItemDropdownListViewModel { get; set; }

    }
}
