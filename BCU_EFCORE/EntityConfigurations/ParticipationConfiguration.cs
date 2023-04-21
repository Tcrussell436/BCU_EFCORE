using BCU_EFCORE.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BCU_EFCORE.EntityConfigurations;

public class ParticipationConfiguration : IEntityTypeConfiguration<Participation>
{
    public void Configure(EntityTypeBuilder<Participation> builder)
    {
        builder.ToTable("Participation");
        
        builder.HasKey(d => d.HobbyName);
        builder.HasKey(d => d.DependentEmployeeNumber);
        builder.HasKey(d => d.DependentFirstName);
        builder.HasKey(d => d.DependentLastName);

        builder.Property(d => d.HobbyName)
            .HasMaxLength(40)
            .IsRequired();
        
        builder.Property(d => d.DependentEmployeeNumber)
            .HasMaxLength(9)
            .IsRequired();
        
        builder.Property(d => d.DependentFirstName)
            .HasMaxLength(30)
            .IsRequired();
        
        builder.Property(d => d.DependentFirstName)
            .HasMaxLength(60)
            .IsRequired();
        
        builder.Property(d => d.AnnualCost)
            .HasColumnType("NUMBER(6,2)");

        builder.Property(d => d.HoursPerWeek)
            .HasColumnType("NUMBER(4,2)");

        builder.HasOne(p => p.Hobby)
            .WithMany(h => h.Participations)
            .HasForeignKey(p => p.HobbyName)
            .IsRequired()
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(p => p.Dependent)
            .WithMany(d => d.Participations)
            .HasForeignKey(p => p.DependentEmployeeNumber)
            .HasForeignKey(p => p.DependentFirstName)
            .HasForeignKey(p => p.DependentLastName)
            .IsRequired()
            .OnDelete(DeleteBehavior.Restrict);
    }
}