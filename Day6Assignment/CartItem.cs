

public class CartItem
{
    public Product Product { get; set; }
    public int Quantity { get; set; }

    public double TotalPrice()
    {
        return Product.Price * Quantity;
    }
}