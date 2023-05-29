namespace OOPExerecise.Classes
{
    class Customer : BaseEntity
    {
        public Customer(string firstName, string lastName, CustomerMail[] customerMails, CustomerAddres customerAddres, CustomerPhone[] customerPhones, Order[] order)
        {
            Id++;
            FirstName = firstName;
            LastName = lastName;
            CustomerMails = customerMails;
            CustomerAddres = customerAddres;
            CustomerPhones = customerPhones;
            Order = order;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public CustomerMail[] CustomerMails { get; set; }
        public CustomerAddres CustomerAddres { get; set; }
        public CustomerPhone[] CustomerPhones { get; set; }
        public Order[] Order { get; set; }

        public void Update(string firstName, string lastName, CustomerMail[] customerMails, CustomerAddres customerAddres, CustomerPhone[] customerPhones, Order[] order)
        {
            FirstName = firstName;
            LastName = lastName;
            CustomerMails = customerMails;
            CustomerAddres = customerAddres;
            CustomerPhones = customerPhones;
            Order = order;
        }

    }
}
