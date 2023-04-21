using BCU_EFCORE.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Oracle.ManagedDataAccess.Client;

namespace BCU_EFCORE.EntityConfigurations;

public class BCU_AccountConfiguration : IEntityTypeConfiguration<BCU_Account>
{
    public void Configure(EntityTypeBuilder<BCU_Account> builder)
    {
        builder.ToTable("BCU_Account");

        builder.HasKey(a => a.AccountNumber);
        builder.HasKey(a => a.AccountType);

        builder.Property(a => a.AccountNumber)
            .IsRequired();

        builder.Property(a => a.AccountType)
            .HasMaxLength(2)
            .IsRequired();

        builder.Property(a => a.Balance)
            .HasColumnType("NUMBER(10,2)")
            .IsRequired();

        builder.Property(a => a.DependentEmployeeNumber)
            .HasMaxLength(9);
        builder.Property(a => a.DependentFirstName)
            .HasMaxLength(30);
        builder.Property(a => a.DependentLastName)
            .HasMaxLength(60);
        builder.Property(a => a.EmployeeNumber)
            .HasMaxLength(9);

        builder.HasOne(a => a.Dependent)
            .WithMany(d => d.BcuAccount)
            .HasForeignKey(a => a.DependentEmployeeNumber)
            .HasForeignKey(a => a.DependentFirstName)
            .HasForeignKey(a => a.DependentLastName)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(a => a.Employee)
            .WithMany(e => e.BcuAccount)
            .HasForeignKey(a => a.EmployeeNumber)
            .OnDelete(DeleteBehavior.Restrict);
    }
}