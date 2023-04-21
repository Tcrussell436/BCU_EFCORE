using BCU_EFCORE.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BCU_EFCORE.EntityConfigurations;

public class BuildingConfiguration : IEntityTypeConfiguration<Building>
{
    public void Configure(EntityTypeBuilder<Building> builder)
    {
        builder.ToTable("Building");

        builder.HasKey(b => b.BuildingNumber);

        builder.Property(b => b.BuildingNumber)
            .IsRequired();

        builder.Property(b => b.BuildingName)
            .HasMaxLength(30);
        
        builder.Property(b => b.PlantNumber)
            .IsRequired();

        builder.HasOne(b => b.Plant)
            .WithMany(p => p.Buildings)
            .HasForeignKey(b => b.PlantNumber)
            .OnDelete(DeleteBehavior.Restrict)
            .IsRequired();
    }
}