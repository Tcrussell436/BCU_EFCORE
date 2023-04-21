using BCU_EFCORE.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BCU_EFCORE.EntityConfigurations;

public class DependentConfiguration : IEntityTypeConfiguration<Dependent>
{
    public void Configure(EntityTypeBuilder<Dependent> builder)
    {
        builder.ToTable("Dependent");

        builder.HasKey(d => d.EmployeeNumber);
        builder.HasKey(d => d.DependentFirstName);
        builder.HasKey(d => d.DependentLastName);

        builder.Property(d => d.EmployeeNumber)
            .HasMaxLength(9)
            .IsRequired();
        
        builder.Property(d => d.DependentFirstName)
            .HasMaxLength(30)
            .IsRequired();
        
        builder.Property(d => d.DependentLastName)
            .HasMaxLength(60)
            .IsRequired();
        
        builder.Property(d => d.Relationship)
            .HasMaxLength(30);
        
        builder.Property(d => d.BirthDate);
        
        builder.Property(d => d.Gender)
            .HasColumnType("CHAR");

        builder.HasOne(d => d.Employee)
            .WithMany(e => e.Dependents)
            .HasForeignKey(d => d.EmployeeNumber)
            .IsRequired();
    }
}