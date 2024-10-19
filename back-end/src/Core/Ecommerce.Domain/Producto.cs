using System.ComponentModel.DataAnnotations.Schema;
using Ecommerce.Domain.Common;


namespace Ecommerce.Domain;


public class Producto : BaseDomainModel{
    
    [Column(TypeName = "NVARCHAR(100)")]
    public string? Nombre { get; set; }
    
    [Column(TypeName = "NVARCHAR(100)")]
    public string? SkuCodigo { get; set; }
    
    [Column(TypeName = "NVARCHAR(100)")]
    public string? Descripcion { get; set; }
    
    [Column(TypeName = "NVARCHAR(100)")]
    public string? Modelo {get; set;}
    
    [Column(TypeName = "decimal(10,2)")]
    public decimal? Precio { get; set; }
    

    public ProductoStatus Estatus { get; set; } = ProductoStatus.Activo;
    
  
    public string? IdCategoria { get; set; }
    public Categoria? Categoria {get;set;}  //Acceso a categoria

    public string? IdSubCategoria { get; set; }   // Clave foránea opcional
     public SubCategoria? SubCategoria { get; set; }  // Navegación hacia SubCategoría
       // Relación con Catálogo
    public int IdCatalogo { get; set; }
    public Catalogo? Catalogo { get; set; }  // Navegación hacia Catálogo
    

    


}