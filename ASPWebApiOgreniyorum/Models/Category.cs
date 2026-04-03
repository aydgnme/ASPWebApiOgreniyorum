namespace ASPWebApiOgreniyorum.Models;

public class Category
{
    public int CategoryId { get; set; }
    public string CategoryName { get; set; } = string.Empty;
    public string CategoryDescription { get; set; } = string.Empty;

    // Gelecekte buraya Product listesi eklenecek (1:N Iliskisi icin)

}