namespace TestApp.UnitTests;

public class RentTests
{
    // Method_Scenario_ExpectedBehavior

    [Fact]
    public void CanReturn_UserIsRentee_ReturnsTrue()
    {
        // Arrange
        User rentee = new User();

        Rent rent = new Rent();
        rent.Rentee = rentee;

        // Act
        var result = rent.CanReturn(rentee);

        // Assert
        Assert.True(result);
    }

    [Fact]
    public void CanReturn_UserIsNotRentee_ReturnsFalse()
    {
        // Arrange
        Rent rent = new Rent();
        rent.Rentee = new User();

        // Act
        var result = rent.CanReturn(new User());

        // Assert
        Assert.False(result);
    }

    [Fact]
    public void CanReturn_UserIsAdmin_ReturnsTrue()
    {
        // Arrange
        Rent rent = new Rent();
        rent.Rentee = new User();

        // Act
        var result = rent.CanReturn(new User { IsAdmin = true });

        // Assert
        Assert.True(result);
    }

    [Fact]
    public void CanReturn_UserIsEmpty_ShouldThrowArgumentNullException()
    {
        // Arrange
        Rent rent = new Rent();
        rent.Rentee = new User();

        // Act
        Action act = () => rent.CanReturn(null); // delegate

        // Assert
        Assert.Throws<ArgumentNullException>(act);

        // ekwiwalent:

        //try
        //{
        //    act();
        //    Assert.Fail("Brak oczekiwanego ArgumentNullException");
        //}
        //catch (ArgumentNullException ex)
        //{           
        //}

    }
}