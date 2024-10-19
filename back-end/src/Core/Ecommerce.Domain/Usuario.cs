using Microsoft.AspNetCore.Identity;

namespace Ecommerce.Domain;

public class Usuario : IdentityUser{
    public string? Nombre { get; set; }
    public string? APaterno { get; set; }
    public string? AMaterno { get; set; }
    public string? Telefono { get; set; }
    public string? Correo  { get; set; }
    public bool IsActive { get; set; }

}