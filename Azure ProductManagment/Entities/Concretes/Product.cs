using Azure_ProductManagment.Entities.Abstracts;

namespace Azure_ProductManagment.Entities.Concretes;

public class Product : IBaseEntitiy {

    // Fields

    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public decimal Price { get; set; }
    public int Stock { get; set; }

    // Foreign KeyIds

    public int CategoryId { get; set; }

    // Navigation Properties

    public virtual Category Category { get; set; }
    public virtual ICollection<ProductImage> ProductImages { get; set; }
}
