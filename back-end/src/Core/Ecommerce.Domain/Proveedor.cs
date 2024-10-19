using Ecommerce.Domain.Common;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ecommerce.Domain;

public class Proveedor : BaseDomainModel{

    [Column(TypeName = "NVARCHAR(100)")]
    public string? Nombre {get;set;}
      // Relación: Un Proveedor puede tener múltiples Catálogos
    public virtual ICollection<Catalogo>? Catalogos { get; set; }
}