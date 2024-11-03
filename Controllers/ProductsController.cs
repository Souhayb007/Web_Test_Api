using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Web_Test_Api.Model;
using Web_Test_Api.Models;
using Web_Test_Api.Service;

namespace Web_Test_Api.Controllers
{
    [Route("inventory")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        MarketApi dbb;
        //public ProductsController(MarketApi db) { this.dbb = db; }
        private readonly IStorage storage;
        public ProductsController(IStorage storage)
        {
            this.storage = storage;
        }
        [HttpGet]
        public IEnumerable<Product> Get()
        {
            return this.storage.GetAll().ToArray();
        }
        [HttpDelete("{barcode}")]
        public IActionResult Delete(int barcode)
        {
            int n=this.storage.DeleteProduct(barcode);
            
            if (n==0)
            { return NotFound(); }
            return NoContent();
        }
        [HttpPut("{barcode}")]
        public IActionResult Update(int barcode,Product productupd)
        {
            int p = this.storage.UpdateProduct(barcode,productupd);
            if (p == 0)
            { return NotFound(); }
            else { return NoContent(); }
           
            
        }
        [HttpPost]
        public IActionResult Ajouter(Product p)
        {
            this.storage.AddProduct(p);
            return Ok();
        }



    }
}
