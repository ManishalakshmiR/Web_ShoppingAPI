using ShoppingAPI.Models;
public class User
{
    public int Id { get; set; }
    public string Email { get; set; } = string.Empty;
    public string Password { get; set; } = string.Empty;
    public string Username { get; set; } = string.Empty;
    public string ShippingAddress { get; set; } = string.Empty;
    public List<Order> PurchaseHistory { get; set; } = new List<Order>();
}

