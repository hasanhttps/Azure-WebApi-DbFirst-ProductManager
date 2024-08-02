using Microsoft.AspNetCore.Mvc;
using Azure_ProductManagment.DTO;
using Azure_ProductManagment.Entities.Concretes;

namespace Azure_ProductManagment.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ProductController : ControllerBase {

    // Fields

    private readonly EStoreDbContext _context;

    // Constructors

    public ProductController(EStoreDbContext context) { 
        _context = context;
    }

    // Methods

    [HttpPost("AddProduct")]
    public async Task<IActionResult> AddProduct(ProductDTO productDTO) {

        try {

            if (productDTO == null) {
                return BadRequest();
            }

            var newProduct = new Product() { 
                Name = productDTO.Name,
                Description = productDTO.Description,
                Price = productDTO.Price,
                Stock = productDTO.Stock,
                CategoryId = productDTO.CategoryId,
            };

            var result = await _context.Products.AddAsync(newProduct);
            await _context.SaveChangesAsync();

            if (result != null)
                return Ok("Product Successfully added.");
            else return BadRequest("Some fields probably wrong");
        }
        catch (Exception ex) {
            return StatusCode(500);
        }
    }
}
