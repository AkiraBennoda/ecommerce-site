using Ecommerce.Domain.Common;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ecommerce.Domain;

public class Catalogo : BaseDomainModel{

    [Column(TypeName = "NVARCHAR(100)")]
    public string? Nombre {get;set;}

    [Column(TypeName = "NVARCHAR(255)")]
    public int Url { get; set; }

     // Relación con Proveedor
    public int IdProveedor { get; set; }
    public Proveedor? Proveedor { get; set; }  // Navegación hacia Proveedor

    // Relación con Productos
    public ICollection<Producto>? Productos { get; set; }  // Navegación hacia Productos
    
}