namespace ShopperApp.UnitTests;

public class ShoppingCartTests
{

    // 1. Czy produkt dodanie siê do koszyka?
    // Po dodaniu jednego produktu sprawdzamy ile mamy produktów w koszyku.


    // 3. Czy produkty po dodaniu do koszyka zwracaj¹ prawid³ow¹ sumê?

    // 4. Czy jeœli dodamy kilka razy ten sam produkt, to koszyk poprawnie zwróci iloœæ tego produktu


    // 2. Czy produkt usuwa siê z koszyka?
    // Po usuniêciu jednego produktu sprawdzamy ile mamy produktów w koszyku.

    // 5. Czy mo¿na wyj¹æ produkt z koszyka, którego nie ma koszyku. 

    // 6. Czy mo¿na wyczyœciæ koszyk?

    // 7. Czy jest zabezpieczenie przed wrzuceniem produktu za cena za 0 z³ lub poni¿ej 0 z³

    // 8. Czy jest zabezpieczenie przed wrzuceniem produktu i iloœci 0 lub mniejsze

    // 9. Czy nazwa produktu nie jest pusta

    ShoppingCart cart;

    // w xUnit mo¿na umieœciæ aran¿acjê w konstruktorze
    // bo dla ka¿dej metody testuj¹cej jest on wywo³ywany
    public ShoppingCartTests()
    {
        // Arrange
        cart = new ShoppingCart();
    }


    [Fact]
    public void AddItem_SingleItem_ReturnsSingleItem()
    {
        // Arrange

        // Act
        cart.AddItem("Product A", 1.99m, 1);

        // Assert
        Assert.Single(cart.Items);

        Assert.Equal("Product A", cart.Items[0].ItemName);
        Assert.Equal(1.99m, cart.Items[0].Price);
        Assert.Equal(1, cart.Items[0].Quantity);
    }

    [Fact]
    public void AddItem_DoubleProduct_ReturnsTwoQuantity()
    {
        // Arrange        

        // Act
        cart.AddItem("Product A", 1.99m, 1);
        cart.AddItem("Product B", 1.99m, 1);

        // Assert
        Assert.Equal(2, cart.Items.Count);

        Assert.Equal("Product B", cart.Items[1].ItemName);
        Assert.Equal(1.99m, cart.Items[1].Price);
        Assert.Equal(1, cart.Items[1].Quantity);

    }

    [Fact]
    public void CalculateTotal_MultiProducts_ReturnsCorrectTotal()
    {
        // Arrange
        cart.AddItem("Product A", 10m, 1);
        cart.AddItem("Product B", 5m, 2);

        // Act
        var result = cart.CalculateTotal();

        // Assert
        Assert.Equal(20m, result);

    }

    [Fact]
    public void AddItem_TheSameProducts_ReturnsValidQuantity()
    {
        // Arrange

        // Act
        cart.AddItem("Product A", 1.99m, 2);
        cart.AddItem("Product A", 1.99m, 1);

        // Assert
        Assert.Single(cart.Items);

        Assert.Equal("Product A", cart.Items[0].ItemName);
        Assert.Equal(1.99m, cart.Items[0].Price);
        Assert.Equal(3, cart.Items[0].Quantity);

    }

    [Fact]
    public void RemoveItem_ExistsProduct_ShouldRemoveItem()
    {
        // Arrange
        cart.AddItem("Product A", 1.99m, 2);

        // Act
        cart.RemoveItem("Product A");

        // Assert
        Assert.Empty(cart.Items);
    }

    [Fact]
    public void RemoveItem_NotExistProduct_ShouldThrowInvalidOperationException()
    {
        // Arrange

        // Act
        Action act = () => cart.RemoveItem("Product A");

        // Assert
        Assert.Throws<InvalidOperationException>(act);

    }

    [Fact]
    public void Clear_WhenCalled_ShouldReturnsEmptyItems()
    {
        // Arrange

        // Act
        cart.Clear();

        // Assert
        Assert.Empty(cart.Items);
    }

    [Fact]
    public void AddItem_PriceZero_ShouldThrowArgumentException()
    {
        // Arrange

        // Act
        Action act = () => cart.AddItem("a", 0, 1);


        // Assert
        Assert.Throws<ArgumentException>(act);

    }

    [Fact]
    public void AddItem_PriceBelowZero_ShouldThrowArgumentException()
    {
        // Arrange

        // Act
        Action act = () => cart.AddItem("a", -1, 1);

        // Assert
        Assert.Throws<ArgumentException>(act);

    }

    /*

    [Fact]
    public void AddItem_QuantityZero_ShouldThrowArgumentException()
    {
        // Arrange

        // Act
        Action act = () => cart.AddItem("a", 1.99m, 0);


        // Assert
        Assert.Throws<ArgumentException>(act);

    }

    [Fact]
    public void AddItem_QuantityBelowZero_ShouldThrowArgumentException()
    {
        // Arrange

        // Act
        Action act = () => cart.AddItem("a", 1.99m, -1);

        // Assert
        Assert.Throws<ArgumentException>(act);

    }

    */

    [Theory]
    [InlineData(0)]
    [InlineData(-1)]
    public void AddItem_InvalidQuantity_ShouldThrowArgumentException(int quantity)
    {
        // Act
        Action act = () => cart.AddItem("a", 1.99m, quantity);

        // Assert
        Assert.Throws<ArgumentException>(act);
    }

    [Fact]
    public void AddItem_EmptyItemName_ShouldArgumentNullException()
    {
        // Arrange

        // Act        
        Action act = () => cart.AddItem(string.Empty, 1.99m, 1);

        // Assert
        Assert.Throws<ArgumentNullException>(act);
    }

    [Fact]
    public void RemoveItem_EmptyItemName_ShouldArgumentNullException()
    {
        // Arrange

        // Act        
        Action act = () => cart.RemoveItem(string.Empty);

        // Assert
        Assert.Throws<ArgumentNullException>(act);
    }

}