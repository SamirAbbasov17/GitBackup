namespace OOP.Inheritance.Models;

// School
public class Employee : BasePerson
{
    public string? CellPhone { get; set; }
    public string? CompanyMail { get; set; }
    public decimal Salary { get; set; }
    public string Department { get; set; } = null!;
}
