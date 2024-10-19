using System.Runtime.Serialization;

namespace Ecommerce.Domain;

public enum ProductoStatus{
    [EnumMember(Value = "Producto Inactivo")]
    Inactivo,

    [EnumMember(Value = "Producto Activo")]
    Activo
}