using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Ecommerce.Domain.Configuration;

public class OrdenItemConfiguration : IEntityTypeConfiguration<OrdenItem>
{
    public void Configure(EntityTypeBuilder<OrdenItem> builder)
    {
        builder.Property(x => x.Precio).HasColumnType("decimal(10,2)");
    }
}