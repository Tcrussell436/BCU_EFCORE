using BCU_EFCORE.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BCU_EFCORE.EntityConfigurations;

public class ManagerConfiguration : IEntityTypeConfiguration<Manager>
{
    public void Configure(EntityTypeBuilder<Manager> builder)
    {
        builder.ToTable("Manager");
        
        builder.HasKey(d => d.ManagerNumber);

        builder.Property(d => d.ManagerNumber)
            .IsRequired();
        
        builder.Property(d => d.ManagerStartDate);

        builder.HasOne(m => m.Employee)
            .WithOne()
            .HasForeignKey((Manager m) => m.ManagerNumber)
            .IsRequired();
    }
}