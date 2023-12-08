namespace ShopperApp;

public class CartItem
{
    public string ItemName { get; }
    public decimal Price { get; }
    public int Quantity { get; set; }

    public decimal TotalPrice
    {
        get
        {
            return Price * Quantity;
        }
    }

    public CartItem(string itemName, decimal price, int quantity)
    {
        ItemName = itemName;
        Price = price;
        Quantity = quantity;
    }
}
