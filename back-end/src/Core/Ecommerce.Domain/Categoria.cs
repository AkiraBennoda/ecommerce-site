using System.ComponentModel.DataAnnotations.Schema;
using Ecommerce.Domain.Common;

namespace Ecommerce.Domain;

public class Categoria : BaseDomainModel{

    [Column(TypeName = "NVARCHAR(100)")]
    public string? Nombre { get; set; }

    //Indica que tiene una lista de productos
    public virtual ICollection<Producto>? Productos {get;set;}

        // Relación: Una Categoría tiene una lista de subcategorías
    public virtual ICollection<SubCategoria>? SubCategorias { get; set; }
}