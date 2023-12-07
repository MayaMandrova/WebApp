namespace WebApplication.Models;

public class ProductModel
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public double PriceForPiece { get; set; }
    public int Quantity { get; set; }
}