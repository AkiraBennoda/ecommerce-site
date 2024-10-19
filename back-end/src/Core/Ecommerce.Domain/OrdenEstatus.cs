using System.Runtime.Serialization;

namespace Ecommerce.Domain;

public enum OrdenEstatus{
    [EnumMember(Value = "Pendiente")]
    Pending,

    [EnumMember(Value = "El pago fue recibido")]
    Completado,

    [EnumMember(Value = "El producto fue enviado")]
    Enviado,
    [EnumMember(Value = "El pago tuvo errores")]
    Error



}