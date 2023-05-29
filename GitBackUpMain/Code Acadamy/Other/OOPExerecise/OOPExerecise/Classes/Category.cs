 namespace OOPExerecise.Classes
{
    class Category :BaseName
    {
        public Category(string description, Product[] products,string name)
        {
            Id++;
            Name = name;
            Description = description;
            Products = products;
        }

        public string Description { get; set; }
        public Product[] Products { get; set; }

        public void Update(string description, Product[] products, string name)
        {
            Name = name;
            Description = description;
            Products = products;
        }

    }
}
