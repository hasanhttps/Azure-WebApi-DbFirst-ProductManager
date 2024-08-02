using Azure_ProductManagment.Entities.Abstracts;

namespace Azure_ProductManagment.Entities.Concretes;

public class ProductImage : IBaseEntitiy {

    // Fields

    public int Id { get; set; }
    public string ImageUrl { get; set; }

    // Foreign Key

    public int ProductId { get; set; }

    // Navigation Property

    public virtual Product Product { get; set; }
}
