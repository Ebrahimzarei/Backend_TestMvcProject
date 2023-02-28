using Backend_TestedProject.Infrastruchers.Models.Specifications;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Backend_TestedProject.DataLayer.Infrastruchers.Specification
{
    public class SpecificationConfig : IEntityTypeConfiguration<Specifications>
    {
        public void Configure(EntityTypeBuilder<Specifications> builder)
        {
            builder.ToTable("Table_Specification");
            builder.HasKey(x=>x.Id);
        }
    }
}
