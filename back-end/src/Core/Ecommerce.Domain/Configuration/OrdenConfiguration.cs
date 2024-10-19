using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Ecommerce.Domain.Configuration;

public class OrdenConfiguration : IEntityTypeConfiguration<Orden>
{
    public void Configure(EntityTypeBuilder<Orden> builder)
    {
        //RElacion de solo uno a uno
        builder.OwnsOne(o => o.OrdenDireccion, x => {
            x.WithOwner();
        });

        builder.HasMany(o => o.OrdenItems).WithOne()
        .OnDelete(DeleteBehavior.Cascade);

        builder.Property(s => s.Estatus).HasConversion(
            o => o.ToString(),
            o => (OrdenEstatus)Enum.Parse(typeof(OrdenEstatus), o)
        );
    }
}