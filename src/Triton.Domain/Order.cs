﻿namespace Triton.Domain
{
    public class Order : IEntity<int>
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public DateTime OrderDate { get; set; }
        public Address ShippingAddress { get; set; }
        public ICollection<OrderItem> OrderItems { get; set; }
        public OrderStatus OrderStatus { get; set; }

        public Customer Customer { get; set; }
    }
}
