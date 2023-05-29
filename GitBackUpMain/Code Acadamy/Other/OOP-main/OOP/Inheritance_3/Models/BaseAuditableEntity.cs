namespace OOP.Inheritance.Models;

public class BaseAuditableEntity : BaseEntity
{

    public BaseAuditableEntity()
    {
        this.CreatedDate = DateTime.Now;
        this.CreatedADUserName = Environment.UserName;  // codeacademy//murat.vuranok
        this.CreatedBy = Environment.UserName; // HttpContext muratvuranok  Murat Vuranok
        this.CreatedIP = "82.194.17.140";
    }


    public DateTime CreatedDate { get; set; }
    public string CreatedIP { get; set; } = null!;
    public string CreatedBy { get; set; } = null!;
    public string? CreatedADUserName { get; set; }


    // Modified
    public DateTime? ModifiedDate { get; set; }
    public string? ModifiedBy { get; set; }
    public string? ModifiedIP { get; set; }
    public string? ModifedADUserName { get; set; }
}
