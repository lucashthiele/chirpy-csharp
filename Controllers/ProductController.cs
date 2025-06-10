using api.Models;
using Microsoft.AspNetCore.Mvc;

namespace api.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class ProductController : ControllerBase
  {
    [HttpGet]
    public IActionResult GetProducts()
    {
      return Ok(new List<Product>
      {
        new() { Id = 1, Name = "Apple", Price = 1.99M },
        new() { Id = 2, Name = "Orange", Price = 2.99M },
      });
    }

    [HttpGet("{id}")]
    public IActionResult GetProduct(int id)
    {
      Product product = new() { Id = id, Name = "Tomato", Price = 3.99M };

      return Ok(product);
    }

    [HttpPost]
    public IActionResult CreateProduct([FromBody] Product product)
    {
      // TODO - validation logic
      // TODO - save product logic
      return CreatedAtAction(nameof(GetProduct), new { id = product.Id }, product);
    }

    [HttpPut("{id}")]
    public IActionResult UpdateProduct(int id, [FromBody] Product product)
    {
      // TODO - validation logic
      // TODO - update product logic
      return NoContent();
    }

    [HttpDelete("{id}")]
    public IActionResult DeleteProduct(int id)
    {
      // TODO - validation logic
      // TODO - delete logic

      return NoContent();
    }
  }
}