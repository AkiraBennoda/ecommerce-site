using Ecommerce.Domain.Common;

namespace Ecommerce.Domain;

public class CarritoItem : BaseDomainModel{
    public string? Producto { get; set; }
    public string? SKU { get; set; }
    public string? Catalogo { get; set; }
    public int? Cantidad { get; set; }

    //Maneja la relacion entre productos y oredenes de compra
    public Guid? CarritoMasterId { get; set; }

    public string? IdCarritoGeneral {get; set; }
    public virtual CarritoGeneral? CarritoGeneral {get; set; }

    public string? IdProducto {get; set;}
}