namespace OOPExerecise.Classes
{
    class CustomerAddres : BaseCustomerTitle
    {
        public CustomerAddres(string country, string city, string town, string street, string building, string no, string title, Customer customer, int customerId)
        {
            Id++;
            Country = country;
            City = city;
            Town = town;
            Street = street;
            Building = building;
            No = no;
            Title = title;
            Customer = customer;
            CustomerId = customerId;
        }

        public string Country { get; set; }
        public string City { get; set; }
        public string Town { get; set; }
        public string Street { get; set; }
        public string Building { get; set; }
        public string No { get; set; }

        public void Update(string country, string city, string town, string street, string building, string no, string title, Customer customer, int customerId)
        {
            Country = country;
            City = city;
            Town = town;
            Street = street;
            Building = building;
            No = no;
            Title = title;
            Customer = customer;
            CustomerId = customerId;
        }

    }
}
