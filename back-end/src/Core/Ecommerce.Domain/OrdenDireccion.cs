using Ecommerce.Domain.Common;

namespace Ecommerce.Domain;

public class OrdenDireccion : BaseDomainModel{
    public string? Direccion { get; set; }
    public string? Ciudad { get; set; }
    public string? Calle { get; set; }
    public string? Estado { get; set; }
    public string? CodigoPostal { get; set; }
    public string? Pais { get; set; }
    public string? Usuario { get; set; }
}