using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProductApi.Data;
using ProductApi.Entities;

namespace ProductApi.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ProductAPIController : ControllerBase
    {
        // Veri tabanına erişebileceğim nesne.
        private readonly DataContext _context;

        public ProductAPIController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var products = _context.Products.ToList();
            return Ok(products);
        }

        [HttpGet]
        [Route("[action]/{id}")]
        public IActionResult GetProductById(int id)
        {
            var product = _context.Products.Find(id);
            return Ok(product);
        }

        [HttpGet]
        [Route("[action]/{name}")]
        public IActionResult GetByName(string name)
        {
            var product = _context.Products.FirstOrDefault(x=>x.Name.ToUpper()==name.ToUpper());
            return Ok(product);
        }

        [HttpPost]
        public IActionResult Post([FromBody] Product product) // Post ve Update işlemlerine neden FromBody yaptık?
        {
            var createdProduct = _context.Products.Add(product);
            _context.SaveChanges();
            return Ok(product);

        }

        [HttpPut]
        public IActionResult Update([FromBody] Product product)
        {
            var updatedProduct = _context.Products.Update(product);
            _context.SaveChanges();
            return Ok(product);
        }

        [HttpDelete("id")]
        public void Delete(int id)
        {
            var deletedProduct = _context.Products.Find(id);
            _context.Products.Remove(deletedProduct);
            _context.SaveChanges();
        }

    }
}
