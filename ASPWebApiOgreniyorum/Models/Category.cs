namespace ASPWebApiOgreniyorum.Models;

public class Category
{
    public int CategoryId { get; set; }
    public string CategoryName { get; set; } = string.Empty;
    public string CategoryDescription { get; set; } = string.Empty;

    // Iliski Tanimi: Bir kategoride birden fazla urun olabilir.
    public List<Product> Products { get; set; } = new();
}