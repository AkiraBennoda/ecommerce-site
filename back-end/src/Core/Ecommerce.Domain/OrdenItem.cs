using Ecommerce.Domain.Common;
using System.ComponentModel.DataAnnotations.Schema;


namespace Ecommerce.Domain;

public class OrdenItem : BaseDomainModel
{

    public Producto? Producto { get; set; }

    public string? ProductoId { get; set; }

     public decimal? Precio { get; set; }

    public int? Cantidad { get; set; }
    public Orden? Orden  { get; set; }
    public int OrdenId { get; set; }
    public string? ProductoItemId { get; set; }

    public string? ProdcutoNombre{get; set;}

    public string? Catalogo { get; set; }

}
