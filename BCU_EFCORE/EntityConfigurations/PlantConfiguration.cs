using BCU_EFCORE.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BCU_EFCORE.EntityConfigurations;

public class PlantConfiguration : IEntityTypeConfiguration<Plant>
{
    public void Configure(EntityTypeBuilder<Plant> builder)
    {
        builder.ToTable("Plant");
        
        builder.HasKey(d => d.PlantNumber);

        builder.Property(d => d.PlantNumber)
            .IsRequired();

        builder.Property(d => d.PlantName)
            .HasMaxLength(30);
        
        builder.Property(d => d.Budget)
            .HasColumnType("NUMBER(12,2)");
        
        builder.Property(d => d.ManagerNumber)
            .HasMaxLength(9)
            .IsRequired();

        builder.HasOne(p => p.Manager)
            .WithOne(m => m.Plant)
            .HasForeignKey((Plant p) => p.ManagerNumber)
            .IsRequired()
            .OnDelete(DeleteBehavior.Restrict);
    }
}