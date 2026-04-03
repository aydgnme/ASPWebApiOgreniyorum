using ASPWebApiOgreniyorum.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ASPWebApiOgreniyorum
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        // Simule edilmiş kategoriler listesi
        private static List<Category> _categories = new List<Category>
        {
         new Category { CategoryId = 1, CategoryName = "Elektronik", CategoryDescription = "Telefon, bilgisayar, tablet ve aksesuar urunleri"},
         new Category { CategoryId = 2, CategoryName = "Kitap", CategoryDescription = "Roman, bilim, tarih ve kisisel gelisim kitaplari"},
         new Category { CategoryId = 3, CategoryName = "Ev ve Yaşam", CategoryDescription = "Ev duzeni, dekorasyon ve yasam alanlari icin urunler"}
            };


        // GET: api/Categories Tum kategorileri listele 
        [HttpGet]
        public IActionResult GetCategories()
        {
            return Ok(_categories);
        }

        // GET: api/Categories/5 Id'si verilen kategoriyi getir
        [HttpGet("{id}")]
        public IActionResult GetCategoryById(int id)
        {
            var category = _categories.FirstOrDefault(c => c.CategoryId == id);
            if (category == null)
            {
                return NotFound();
            }
            return Ok(category);
        }

        // Get: api/Categories/5/products Id'si verilen kategorinin urunlerini getir
        [HttpGet("{id}/products")]
        public IActionResult GetProductsByCategoryId(int id)
        {
            var category = _categories.FirstOrDefault(c => c.CategoryId == id);
            if (category == null)
            {
                return NotFound();
            }
            return Ok(category.Products);
        }

        // POST: api/Categories Yeni kategori ekle
        [HttpPost]
        public IActionResult CreateCategory([FromBody] Category newCategory)
        {
            if (newCategory == null || string.IsNullOrEmpty(newCategory.CategoryName))
            {
                return BadRequest("Kategori bilgileri eksik.");
            }

            newCategory.CategoryId = _categories.Max(c => c.CategoryId) + 1;
            _categories.Add(newCategory);
            return CreatedAtAction(nameof(GetCategoryById), new { id = newCategory.CategoryId }, newCategory);
        }

        // PUT: api/Categories/5 Id'si verilen kategoriyi guncelle
        [HttpPut("{id}")]
        public IActionResult UpdateCategory(int id, [FromBody] Category updatedCategory)
        {
            var category = _categories.FirstOrDefault(c => c.CategoryId == id);
            if (category == null)
            {
                return NotFound();
            }

            if (updatedCategory == null || string.IsNullOrEmpty(updatedCategory.CategoryName))
            {
                return BadRequest("Kategori bilgileri eksik.");
            }

            category.CategoryName = updatedCategory.CategoryName;
            category.CategoryDescription = updatedCategory.CategoryDescription;

            return NoContent();
        }

        // DELETE: api/Categories/5 Id'si verilen kategoriyi sil
        [HttpDelete("{id}")]
        public IActionResult DeleteCategory(int id)
        {
            var category = _categories.FirstOrDefault(c => c.CategoryId == id);
            if (category == null)
            {
                return NotFound();
            }

            _categories.Remove(category);
            return NoContent();
        }

    }
}
