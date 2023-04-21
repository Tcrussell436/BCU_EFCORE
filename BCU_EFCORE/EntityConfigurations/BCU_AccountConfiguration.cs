using BCU_EFCORE.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BCU_EFCORE.EntityConfigurations;

public class BCU_AccountConfiguration : IEntityTypeConfiguration<BCU_Account>
{
    public void Configure(EntityTypeBuilder<BCU_Account> builder)
    {
        builder.ToTable("BCU_Account");
        
        
    }
}