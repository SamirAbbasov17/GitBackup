namespace OOPExerecise.Classes
{
    class CustomerPhone : BaseCustomerTitle
    {
        public CustomerPhone(string areaCode, string number , string title , Customer customer , int customerId)
        {
            Id++;
            AreaCode = areaCode;
            Number = number;
            Title = title;
            Customer = customer;
            CustomerId = customerId;
        }

        public string AreaCode { get; set; }
        public string Number { get; set; }

        public void Update(string areaCode, string number, string title, Customer customer, int customerId)
        {
            AreaCode = areaCode;
            Number = number;
            Title = title;
            Customer = customer;
            CustomerId = customerId;
        }

    }
}
