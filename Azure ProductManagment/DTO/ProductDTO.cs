﻿namespace Azure_ProductManagment.DTO;

public class ProductDTO {

    // Fields

    public string Name { get; set; }
    public string Description { get; set; }
    public decimal Price { get; set; }
    public int Stock { get; set; }
    public int CategoryId { get; set; }
}
