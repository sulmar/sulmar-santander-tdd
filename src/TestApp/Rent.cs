namespace TestApp;

public class Rent
{
    public User Rentee;

    public bool CanReturn(User user)
    {
        if (user == null)
            throw new ArgumentNullException();

        return user == Rentee || user.IsAdmin;
    }
}

public class User
{
    public bool IsAdmin;
}
