namespace OOPExerecise.Classes
{
    class BaseCustomerTitle : BaseEntity
    {

        public string Title { get; set; }
        public Customer Customer { get; set; }
        public int CustomerId { get; set; }
    }
}
