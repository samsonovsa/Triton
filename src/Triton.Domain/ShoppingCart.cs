namespace Triton.Domain
{
    public class ShoppingCart
    {
        public int ShoppingCartId { get; set; }
        public int CustomerId { get; set; }
        public ICollection<ShoppingCartItem> ShoppingCartItems { get; set; }

        public Customer Customer { get; set; }
    }
}
