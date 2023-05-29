namespace OOPExerecise.Classes
{
    class Product : BaseName
    {
        public Product(string price, int amount, int unitsInStock, int categoryId, Category category, OrderDetail orderDetail, int orederDetailId , string name, int id)
        {
            Id ++;
            Name = name;
            Price = price;
            Amount = amount;
            UnitsInStock = unitsInStock;
            CategoryId = categoryId;
            Category = category;
            OrderDetail = orderDetail;
            OrederDetailId = orederDetailId;
        }
        public string Price { get; set; }
        public int Amount { get; set; }
        public int UnitsInStock { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public OrderDetail OrderDetail { get; set; }
        public int OrederDetailId { get; set; }
        public void Update(string price, int amount, int unitsInStock, int categoryId, Category category, OrderDetail orderDetail, int orederDetailId)
        {
            Price = price;
            Amount = amount;
            UnitsInStock = unitsInStock;
            CategoryId = categoryId;
            Category = category;
            OrderDetail = orderDetail;
            OrederDetailId = orederDetailId;
        }

    }
}
