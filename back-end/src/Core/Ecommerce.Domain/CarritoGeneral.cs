using Ecommerce.Domain.Common;

namespace Ecommerce.Domain;

public class CarritoGeneral : BaseDomainModel{
    public Guid? CarritoMasterId { get; set; }
    public virtual ICollection<CarritoItem>? CarritoItems { get; set;}

}