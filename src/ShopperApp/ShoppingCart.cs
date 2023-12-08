namespace ShopperApp;

// Refaktoring - ulepszenie kodu (czytelniejszy) bez zmiany funkcjonalności.

public class ShoppingCart
{
    public List<CartItem> Items { get; } = new List<CartItem>();

    public void AddItem(string itemName, decimal price, int quantity)
    {
        if (price <= 0)
            throw new ArgumentException();

        if (quantity <= 0)
            throw new ArgumentException();

        var existingItem = GetCartItem(itemName);

        if (existingItem == null)
        {
            Items.Add(new CartItem(itemName, price, quantity));
        }
        else
        {
            existingItem.Quantity += quantity;
        }
    }

    public void RemoveItem(string itemName)
    {
        var existingItem = GetCartItem(itemName);

        if (existingItem == null)
        {
            throw new InvalidOperationException();
        }
        else
        {
            Items.Remove(existingItem);
        }
    }

    private CartItem? GetCartItem(string itemName)
    {
        if (string.IsNullOrEmpty(itemName))
            throw new ArgumentNullException();

        return Items.SingleOrDefault(item => item.ItemName == itemName);
    }

    public void Clear()
    {
        Items.Clear();
    }

    public decimal CalculateTotal()
    {
        return Items.Sum(item => item.TotalPrice);
    }
}
