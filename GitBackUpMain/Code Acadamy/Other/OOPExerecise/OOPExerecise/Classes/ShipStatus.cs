namespace OOPExerecise.Classes
{
    class ShipStatus : BaseEntity
    {
        public ShipStatus(int customerId, string productName)
        {
            Id++;
            CustomerId = customerId;
            ProductName = productName;
        }

        public int CustomerId { get; set; }
        public string ProductName { get; set; }
        public Order Order { get; set; }
        public int OrderId { get; set; }    
        public Status Status { get; set; }

        public void Update(int customerId, string productName)
        {
            CustomerId = customerId;
            ProductName = productName;
        }

    }
}
