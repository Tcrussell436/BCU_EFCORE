using BCU_EFCORE.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BCU_EFCORE.EntityConfigurations;

public class JobConfiguration : IEntityTypeConfiguration<Job>
{
    public void Configure(EntityTypeBuilder<Job> builder)
    {
        builder.ToTable("Job");
        
        builder.HasKey(d => d.EmployeeNumber);
        builder.HasKey(d => d.ProjectNumber);

        builder.Property(d => d.EmployeeNumber)
            .HasMaxLength(9)
            .IsRequired();
        
        builder.Property(d => d.ProjectNumber)
            .IsRequired();

        builder.HasOne(j => j.Employee)
            .WithMany(e => e.Jobs)
            .HasForeignKey(j => j.EmployeeNumber)
            .OnDelete(DeleteBehavior.Restrict)
            .IsRequired();

        builder.HasOne(j => j.Project)
            .WithMany(p => p.Jobs)
            .HasForeignKey(j => j.ProjectNumber)
            .OnDelete(DeleteBehavior.Restrict)
            .IsRequired();
    }
}