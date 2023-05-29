namespace OOPExerecise.Classes
{
    class CustomerMail : BaseCustomerTitle
    {
        public CustomerMail(string mail, string title, Customer customer, int customerId)
        {
            Id++;
            Mail = mail;
            Title = title;
            Customer = customer;
            CustomerId = customerId;
        }

        public string Mail { get; set; }


        public void Update(string mail, string title, Customer customer, int customerId)
        {
            Mail = mail;
            Title = title;
            Customer = customer;
            CustomerId = customerId;
        }

    }
}
