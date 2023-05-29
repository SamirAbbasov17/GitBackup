namespace OOP.Inheritance.Models;

public class BasePerson : BaseAuditableEntity  // tamamen keyfi :)
{
    public string FirstName { get; set; } = null!;  // -> NotNull
    public string? MidleName { get; set; }  // 2. İsim
    public string LastName { get; set; } = null!;  // -> NotNull
    public string? HomePhone { get; set; }
    public string? Mail { get; set; }
    public string Address { get; set; } = null!;

}
