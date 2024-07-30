namespace ShoppingAPI.Models
{
    public class Cart
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string Products { get; set; }
        public int Quantities { get; set; }
    }
}
