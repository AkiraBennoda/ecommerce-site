using Ecommerce.Domain;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Ecommerce.Persistence;

public class EcommerceDbContext : IdentityDbContext<Usuario>{
    public EcommerceDbContext(DbContextOptions<EcommerceDbContext> options): base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        //Relacion: Categoria tiene muchos productos
        builder.Entity<Categoria>()
                .HasMany(p => p.Productos)
                .WithOne(r => r.Categoria)
                .HasForeignKey(r => r.IdCategoria)
                .IsRequired()
                .OnDelete(DeleteBehavior.Restrict);

        //Relación: Categoria tiene muchas subcategorias
        builder.Entity<Categoria>()
                .HasMany(p => p.SubCategorias)
                .WithOne(r => r.Categoria)
                .HasForeignKey(r => r.IdCategoria)
                .IsRequired()
                .OnDelete(DeleteBehavior.Restrict);        

        //Relacion: Un producto pertenece a una subcategoria
        builder.Entity<Producto>()
                .HasOne(p => p.SubCategoria)
                .WithMany(r => r.Productos)
                .HasForeignKey(r => r.IdSubCategoria)
                .IsRequired()
                .OnDelete(DeleteBehavior.Restrict);

        // Relación: Un Catálogo tiene muchos Productos
        builder.Entity<Catalogo>()
            .HasMany(p => p.Productos)
            .WithOne(r => r.Catalogo)
            .HasForeignKey(r => r.IdCatalogo)
            .OnDelete(DeleteBehavior.Restrict);

        // Relación: Un Proveedor tiene muchos Catálogos    
        builder.Entity<Proveedor>()
            .HasMany(p => p.Catalogos)
            .WithOne(r => r.Proveedor)
            .HasForeignKey(r => r.IdProveedor)
            .OnDelete(DeleteBehavior.Restrict);

        //Relacion del carrito de compras
        builder.Entity<CarritoGeneral>()   
            .HasMany(p => p.CarritoItems)
            .WithOne(r => r.CarritoGeneral)
            .HasForeignKey(r => r.IdCarritoGeneral)
            .IsRequired()
            .OnDelete(DeleteBehavior.Cascade);
 
        builder.Entity<Usuario>().Property(x => x.Id).HasMaxLength(36);
        builder.Entity<Usuario>().Property(x => x.NormalizedUserName).HasMaxLength(90);
        builder.Entity<IdentityRole>().Property(x => x.Id).HasMaxLength(36);
        builder.Entity<IdentityRole>().Property(x => x.NormalizedName).HasMaxLength(36);
    }

    //Defiicion de las entidades que se convertiran en tablas
    public DbSet<Producto>? Productos {get;set;}
    public DbSet<Categoria>? Categorias {get;set;}
    public DbSet<SubCategoria>? SubCategorias {get;set;}

    public DbSet<Catalogo> Catalogos {get;set;}
    public DbSet<Proveedor> Proveedores {get;set;}
    public DbSet<Direccion> Direcciones{get;set;}
    public DbSet<Orden> Ordenes{get;set;}
    public DbSet<CarritoGeneral> CarritosGeneral{get;set;}
    public DbSet<CarritoItem> CarritoItems{get;set;}
    public DbSet<OrdenDireccion> OrdenDirecciones{get;set;}

}