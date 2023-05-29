namespace OOPExerecise.Classes
{
    class Order : BaseEntity
    {
        public Order(OrderDetail orderDetail, int orderDetailId, Customer customer, int customerId, string orderDate, string deliveredDate, Shipper shipper, int shipperId, int custommerAdderesId)
        {
            Id++;
            OrderDetail = orderDetail;
            OrderDetailId = orderDetailId;
            Customer = customer;
            CustomerId = customerId;
            OrderDate = orderDate;
            DeliveredDate = deliveredDate;
            Shipper = shipper;
            ShipperId = shipperId;
            CustommerAdderesId = custommerAdderesId;
        }

        public OrderDetail OrderDetail { get;set; }
        public int OrderDetailId { get; set; }
        public Customer Customer { get; set; }
        public int CustomerId { get; set; }
        public string OrderDate { get; set; }
        public string DeliveredDate { get; set; }
        public Shipper Shipper { get; set; }
        public int ShipperId { get; set; }
        public int CustommerAdderesId { get; set; }
        public ShipStatus ShipStatus { get; set; }
        public int ShipStatusId;
        public void Update(OrderDetail orderDetail, int orderDetailId, Customer customer, int customerId, string orderDate, string deliveredDate, Shipper shipper, int shipperId, int custommerAdderesId)
        {
            Id++;
            OrderDetail = orderDetail;
            OrderDetailId = orderDetailId;
            Customer = customer;
            CustomerId = customerId;
            OrderDate = orderDate;
            DeliveredDate = deliveredDate;
            Shipper = shipper;
            ShipperId = shipperId;
            CustommerAdderesId = custommerAdderesId;
        }
    }
}
