namespace Ordering.Infrastructure.Data.Extensions
{
    internal class InitialData
    {
        public static IEnumerable<Customer> Customers => new List<Customer>
        {
           Customer.Create(CustomerId.Of(Guid.NewGuid()), "John Smith", "john.smith@gmail.com"),
           Customer.Create(CustomerId.Of(Guid.NewGuid()), "Alice Johnson","alice.johnson@example.com")
        };

        public static IEnumerable<Product> Products => new List<Product>
        {
           Product.Create(ProductId.Of(Guid.NewGuid()), "Laptop", 3000),
           Product.Create(ProductId.Of(Guid.NewGuid()), "Smartphone", 1500)
        };

        public static IEnumerable<Order> OrdersWithItems
        {
            get
            {
                var address1 = Address.Of(
                    "John",
                    "Smith",
                    "john.smith@gmail.com",
                    "123 Main Street",
                    "United States",
                    "California",
                    "90001");

                var address2 = Address.Of(
                    "Emily",
                    "Johnson",
                    "emily.johnson@gmail.com",
                    "456 Oxford Street",
                    "United Kingdom",
                    "London",
                    "SW1A1");

                var payment1 = Payment.Of(
                    "John Smith",
                    "4111111111111111",
                    "12/28",
                    "123",
                    1);

                var payment2 = Payment.Of(
                    "Emily Johnson",
                    "5555555555554444",
                    "08/29",
                    "456",
                    2);

                var order1 = Order.Create(
                    OrderId.Of(Guid.NewGuid()),
                    CustomerId.Of(new Guid("d37eddd8-629d-440d-a8df-3f1986c0c5c5")),
                    OrderName.Of("ORD-1001"),
                    shippingAddress: address1,
                    billingAddress: address1,
                    payment1);

                order1.Add(ProductId.Of(new Guid("08abdded-6be1-45dd-8e54-2a1e7e41a508")), 1, 1299.99m); // Laptop
                order1.Add(ProductId.Of(new Guid("4952b6f6-f9f6-4708-89d9-c07b1711fe1d")), 2, 49.99m);   // Wireless Mouse

                var order2 = Order.Create(
                    OrderId.Of(Guid.NewGuid()),
                    CustomerId.Of(new Guid("fa6e2b10-b629-401b-b34c-a70217ecc75c")),
                    OrderName.Of("ORD-1002"),
                    shippingAddress: address2,
                    billingAddress: address2,
                    payment2);

                order2.Add(ProductId.Of(new Guid("08abdded-6be1-45dd-8e54-2a1e7e41a508")), 1, 899.99m);  // Smartphone
                order2.Add(ProductId.Of(new Guid("4952b6f6-f9f6-4708-89d9-c07b1711fe1d")), 1, 199.99m);  // Smart Watch

                return new List<Order>
                {
                    order1,
                    order2
                };
            }
        }
    }
}
