﻿namespace Triton.Domain
{
    public class ShoppingCartItem : IEntity<int>
    {
        public int Id { get; set; }
        public int ShoppingCartId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }

        public Product Product { get; set; }
        public ShoppingCart ShoppingCart { get; set; }
    }
}
