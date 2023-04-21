using BCU_EFCORE.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BCU_EFCORE.EntityConfigurations;

public class ProjectConfiguration : IEntityTypeConfiguration<Project>
{
    public void Configure(EntityTypeBuilder<Project> builder)
    {
        builder.ToTable("Project");
        
        builder.HasKey(d => d.ProjectNumber);

        builder.Property(d => d.ProjectNumber)
            .IsRequired();

        builder.Property(d => d.ProjectName)
            .HasMaxLength(30);

        builder.Property(d => d.Location)
            .HasMaxLength(60);

        builder.Property(d => d.PlantNumber)
            .IsRequired();

        builder.HasOne(pr => pr.Plant)
            .WithMany(pl => pl.Projects)
            .HasForeignKey(pr => pr.PlantNumber)
            .IsRequired()
            .OnDelete(DeleteBehavior.Restrict);
    }
}