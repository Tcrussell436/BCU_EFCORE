using BCU_EFCORE.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BCU_EFCORE.EntityConfigurations;

public class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
{
    public void Configure(EntityTypeBuilder<Employee> builder)
    {
        builder.ToTable("Employee");
        
        builder.HasKey(d => d.EmployeeNumber);

        builder.Property(d => d.EmployeeNumber)
            .HasMaxLength(9)
            .IsRequired();
        
        builder.Property(d => d.FirstName)
            .HasMaxLength(30);
        
        builder.Property(d => d.LastName)
            .HasMaxLength(60);
        
        builder.Property(d => d.StreetLine1)
            .HasMaxLength(60);
        
        builder.Property(d => d.StreetLine2)
            .HasMaxLength(60);
        
        builder.Property(d => d.City)
            .HasMaxLength(50);
        
        builder.Property(d => d.State)
            .HasMaxLength(2);
        
        builder.Property(d => d.Postal)
            .HasMaxLength(10);
        
        builder.Property(d => d.Gender)
            .HasColumnType("CHAR");
        
        builder.Property(d => d.DateHired);
        
        builder.Property(d => d.Salary)
            .HasColumnType("NUMBER(9,2)");
        
        builder.Property(d => d.SupervisorNumber)
            .HasMaxLength(9);
        
        builder.Property(d => d.PlantNumber)
            .IsRequired();

        builder.HasOne(e => e.Plant)
            .WithMany(p => p.Employees)
            .HasForeignKey(e => e.PlantNumber)
            .OnDelete(DeleteBehavior.Restrict)
            .IsRequired();
    }
}