//Tiene toda la información de la transaccion
using Ecommerce.Domain.Common;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ecommerce.Domain;

public class Orden : BaseDomainModel{

    public Orden(){}
    public Orden(
        string compradorNombre,
        string compradorEmail,
        OrdenDireccion ordenDireccion,
        decimal subTotal,
        decimal total,
        decimal impuesto,
        decimal precioEnvio){

        CompradorNombre = compradorNombre;
        CompradorUsername = compradorEmail;
        OrdenDireccion = ordenDireccion;
        SubTotal = subTotal;
        Total = total;
        Impuesto = impuesto;
        PrecioEnvio = precioEnvio;
    }
    
    public String? CompradorNombre {get;set;}
    public string? CompradorUsername { get; set; }
    public OrdenDireccion? OrdenDireccion { get; set; }
    public IReadOnlyList<OrdenItem> OrdenItems { get; set; }
    
    [Column(TypeName="decimal(10,2)")]
    public decimal SubTotal { get; set; }
    
    public OrdenEstatus Estatus {get;set;} = OrdenEstatus.Pending;
    
    [Column(TypeName="decimal(10,2)")]
    public decimal Total { get; set; }

    [Column(TypeName="decimal(10,2)")]
    public decimal Impuesto{ get; set; }

    [Column(TypeName="decimal(10,2)")]
    public decimal PrecioEnvio { get; set; }

    public string? PaymentIntentId { get; set; }
    public string? ClienteSecret { get; set; }
    public int StripeApiKey { get; set; }

}