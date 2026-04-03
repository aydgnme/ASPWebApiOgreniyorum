using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ASPWebApiOgreniyorum
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {

        // Simule edilmiş urunler listesi
        private static List<Product> _products = new List<Product>
        {
            new Product { ProductId = 1, ProductName = "Telefon", ProductDescription = "Akıllı telefon" },
            new Product { ProductId = 2, ProductName = "Bilgisayar", ProductDescription = "Dizüstü bilgisayar" },
            new Product { ProductId = 3, ProductName = "Tablet", ProductDescription = "Tablet bilgisayar" },
            new Product { ProductId = 4, ProductName = "Kitap", ProductDescription = "Roman" },
            new Product { ProductId = 5, ProductName = "Ev Dekorasyonu", ProductDescription = "Ev dekorasyonu ürünleri" }
        };

        // GET: api/Products Tum urunleri listele
        [HttpGet]
        public IActionResult GetProducts()
        {
            return Ok(_products);
        }

        // GET: api/Products/5 Id'si verilen urunu getir
        [HttpGet("{id}")]
        public IActionResult GetProductById(int id)
        {
            var product = _products.FirstOrDefault(p => p.ProductId == id);
            if (product == null)
            {
                return NotFound();
            }
            return Ok(product);
        }

        // POST: api/Products Yeni urun ekle
        [HttpPost]
        public IActionResult CreateProduct([FromBody] Product newProduct)
        {
            // Urun bilgileri eksikse BadRequest don
            if (newProduct == null || string.IsNullOrEmpty(newProduct.ProductName))
            {
                return BadRequest("Urun bilgileri eksik.");
            }

            newProduct.ProductId = _products.Any() ? _products.Max(p => p.ProductId) + 1 : 1;
            _products.Add(newProduct);
           
           // Eklenecek urun yeni bir id alarak listeye eklendikten sonra, eklenen urunu ve 201 Created durum kodunu don
           // Kullanici ID giremesini englleyecegimiz icin, urun id'si otomatik olarak atanir ve kullaniciya geri donulur
            return CreatedAtAction(nameof(GetProductById), new { id = newProduct.ProductId }, newProduct);
        }

        // PUT: api/Products/5 Id'si verilen urunu guncelle
        [HttpPut("{id}")]
        public IActionResult UpdateProduct(int id, [FromBody] Product updatedProduct)
        {
            var existingProduct = _products.FirstOrDefault(p => p.ProductId == id);
            if (existingProduct == null)
            {
                return NotFound();
            }
            if (updatedProduct == null || string.IsNullOrEmpty(updatedProduct.ProductName))
            {
                return BadRequest("Urun bilgileri eksik.");
            }

            existingProduct.ProductName = updatedProduct.ProductName;
            existingProduct.ProductDescription = updatedProduct.ProductDescription;
            existingProduct.ProductPrice = updatedProduct.ProductPrice;
            existingProduct.ProductStock = updatedProduct.ProductStock;
            existingProduct.CategoryId = updatedProduct.CategoryId;

            return NoContent();
        }

        // DELETE: api/Products/5 Id'si verilen urunu sil
        [HttpDelete("{id}")]
        public IActionResult DeleteProduct(int id)
        {
            var product = _products.FirstOrDefault(p => p.ProductId == id);
            if (product == null)
            {
                return NotFound();
            }
            _products.Remove(product);
            return NoContent();
        }

    }
}
