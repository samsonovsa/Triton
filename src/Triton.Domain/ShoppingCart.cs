namespace Triton.Domain
{
    public class ShoppingCart : IEntity<int>
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public ICollection<ShoppingCartItem> ShoppingCartItems { get; set; }

        public Customer Customer { get; set; }
    }
}
