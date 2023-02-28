using Backend_TestedProject.DataLayer.Infrastruchers.Specification;
using Backend_TestedProject.Infrastruchers.Models.Specifications;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace Backend_TestedProject.DataLayer.Common
{
    public class TestProject_Context : DbContext
    {
        public TestProject_Context (Microsoft.EntityFrameworkCore.DbContextOptions<TestProject_Context> options) : base(options)
        {

            //AutomaticMigrationsEnabled = true;
            //AutomaticMigrationDataLossAllowed = false;
            Database.EnsureCreated();
        }
        public Microsoft.EntityFrameworkCore.DbSet<Specifications> tbl_Specification { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new SpecificationConfig());
            base.OnModelCreating(modelBuilder);
        }
    }
}
