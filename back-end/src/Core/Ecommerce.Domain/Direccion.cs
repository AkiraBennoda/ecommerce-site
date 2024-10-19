using Ecommerce.Domain.Common;

namespace Ecommerce.Domain;

public class Direccion : BaseDomainModel
{
    public string? Calle { get; set; }
    public string? Ciudad { get; set; }
    public string? Estado { get; set; }
    public string? CodigoPostal { get; set; }

    public string? IdPersona { get; set; }

}