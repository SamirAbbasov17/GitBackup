namespace OOP.Constructor.Models;

public class Product
{
    #region Constractor
    public Product() { }

    /// <summary>
    /// Yeni bir ürün oluştururken kullanabilirsiniz ( yeni bir ürün için zorunlu alanlar )
    /// </summary>
    /// <param name="productName"></param>
    /// <param name="amount"></param>
    public Product(string productName, decimal? amount)
    {
        this.ProductName = productName;
        this.Amount = amount;
    }
    #endregion

    #region Properties
    public int Id { get; set; }
    public string ProductName { get; set; } = null!;
    public string? Description { get; set; }
    public decimal? Price { get; set; }
    public decimal? Amount { get; set; }
    public decimal? Balance { get; set; }
    #endregion

    #region Public Methods

    /// <summary>
    /// Ürün Güncelleme Metodu
    /// </summary>
    /// <param name="productName">Ürün Adı</param>
    /// <param name="desceription">Açıklama</param>
    public void Update(string productName, string desceription)
    {
        this.ProductName = productName;
        this.Description = desceription;
    }

    /// <summary>
    /// Ürün Amount değerini günceller
    /// </summary>
    /// <param name="amount">amount değeri</param>
    public void UpdateAmount(decimal amount)
    {
        this.Amount = amount;
    }

    /// <summary>
    /// Ürün Balance değerini günceller
    /// </summary>
    /// <param name="balance"></param>
    /// <param name="price"></param>
    public void UpdateBalance(decimal balance, decimal price)
    {
        this.Balance = balance;
        this.Price = price;
    }

    #endregion
}

