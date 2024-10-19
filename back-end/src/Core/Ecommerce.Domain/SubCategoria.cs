using Ecommerce.Domain.Common;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ecommerce.Domain;

public class SubCategoria : BaseDomainModel{

    [Column(TypeName = "NVARCHAR(100)")]
    public string? Nombre {get;set;}    // Clave foránea que relaciona la SubCategoria con su Categoria
    public int IdCategoria { get; set; }
    public Categoria? Categoria { get; set; }  // Propiedad de navegación hacia la Categoría

    // Relación: Una SubCategoria puede tener varios productos
    public virtual ICollection<Producto>? Productos { get; set; }
   
}