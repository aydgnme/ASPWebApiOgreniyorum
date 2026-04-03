using System;
using ASPWebApiOgreniyorum.Models;

namespace ASPWebApiOgreniyorum;

public class Product
{
    public int ProductId { get; set; }
    public string ProductName { get; set; } = string.Empty;
    public string ProductDescription { get; set; } = string.Empty;
    public decimal ProductPrice { get; set; }
    public int ProductStock { get; set; }

    // Iliski Tanimi: Her urunun bir kategorisi olur
    public int CategoryId { get; set; } // Dis Anahtar (Foreign Key)
    public Category? Category { get; set;} // Navigation Property
}
