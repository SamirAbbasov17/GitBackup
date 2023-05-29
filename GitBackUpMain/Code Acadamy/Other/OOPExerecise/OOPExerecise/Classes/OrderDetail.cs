namespace OOPExerecise.Classes
{
    class OrderDetail : BaseEntity
    {
        public OrderDetail(Order order, int orderId, Product product, int productId, string price, int count, string discount)
        {
            Id++;
            Order = order;
            OrderId = orderId;
            Product = product;
            ProductId = productId;
            Price = price;
            Count = count;
            Discount = discount;
        }

        public Order Order { get; set; }
        public int OrderId { get; set; }
        public Product Product { get; set; }
        public int ProductId { get; set; }
        public string Price { get; set; }
        public int Count { get; set; }
        public string Discount { get; set; }

        public void Update(Order order, int orderId, Product product, int productId, string price, int count, string discount)
        {
            Id++;
            Order = order;
            OrderId = orderId;
            Product = product;
            ProductId = productId;
            Price = price;
            Count = count;
            Discount = discount;
        }

    }
}
