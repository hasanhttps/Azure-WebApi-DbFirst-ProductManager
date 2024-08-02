using Azure_ProductManagment.Entities.Abstracts;

namespace Azure_ProductManagment.Entities.Concretes;

public class Category : IBaseEntitiy {

    // Fields

    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }

    // Navigation Properties

    public virtual ICollection<Product> Products { get; set; }
}
