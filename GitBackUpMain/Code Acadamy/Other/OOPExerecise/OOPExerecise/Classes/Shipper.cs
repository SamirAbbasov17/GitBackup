namespace OOPExerecise.Classes
{
    class Shipper : BaseName
    {
        public Shipper(string phone, Order[] orders)
        {
            Id++;
            Phone = phone;
            Orders = orders;
        }

        public string Phone { get; set; }
        public Order[] Orders { get; set; }

        public void Update(string phone, Order[] orders)
        {
            Id++;
            Phone = phone;
            Orders = orders;
        }


    }
}
