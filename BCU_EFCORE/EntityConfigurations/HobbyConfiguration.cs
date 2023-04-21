using BCU_EFCORE.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BCU_EFCORE.EntityConfigurations;

public class HobbyConfiguration : IEntityTypeConfiguration<Hobby>
{
    public void Configure(EntityTypeBuilder<Hobby> builder)
    {
        builder.ToTable("Hobby");
        
        builder.HasKey(d => d.HobbyName);

        builder.Property(d => d.HobbyName)
            .HasMaxLength(30)
            .IsRequired();

        builder.Property(d => d.Activity)
            .HasMaxLength(10);
    }
}