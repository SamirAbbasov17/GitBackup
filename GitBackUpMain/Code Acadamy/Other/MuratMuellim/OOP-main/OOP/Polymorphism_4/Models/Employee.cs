namespace OOP.Polymorphism.Models;

public class Employee
{
    #region Constructor
    public Employee() { }
    /// <summary>
    /// Yeni Personel Ekleme
    /// </summary>
    /// <param name="firstName"></param>
    /// <param name="midleName"></param>
    /// <param name="lastName"></param>
    /// <param name="homePhone"></param>
    /// <param name="mail"></param>
    /// <param name="address"></param>
    /// <param name="cellPhone"></param>
    /// <param name="companyMail"></param>
    /// <param name="salary"></param>
    /// <param name="department"></param>
    public Employee(string firstName, string? midleName, string lastName, string? homePhone, string? mail, string address, string? cellPhone, string? companyMail, decimal salary, string department)
        : this()
    {
        this.FirstName = firstName;
        this.MidleName = midleName;
        this.LastName = lastName;
        this.HomePhone = homePhone;
        this.Mail = mail;
        this.Address = address;
        this.CellPhone = cellPhone;
        this.CompanyMail = companyMail;
        this.Salary = salary;
        this.Department = department;
    }
    #endregion

    #region Public Methods
    public void Update(string firstName, string? midleName, string lastName, string? homePhone, string? mail, string address, string? cellPhone, string? companyMail, decimal salary, string department)
    {
        this.FirstName = firstName;
        this.MidleName = midleName;
        this.LastName = lastName;
        this.HomePhone = homePhone;
        this.Mail = mail;
        this.Address = address;
        this.CellPhone = cellPhone;
        this.CompanyMail = companyMail;
        this.Salary = salary;
        this.Department = department;
    }
    #endregion

    #region Properties
    public int Id { get; set; }
    public string FirstName { get; set; } = null!;
    public string? MidleName { get; set; }
    public string LastName { get; set; } = null!;
    public string? HomePhone { get; set; }
    public string? Mail { get; set; }
    public string Address { get; set; } = null!;
    public string? CellPhone { get; set; }
    public string? CompanyMail { get; set; }
    public string Department { get; set; } = null!;
    public decimal Salary { get; set; }
    #endregion

    public string FullName { get => $"{FirstName} {LastName}"; }
    public override string ToString()
    {
        //return this.FirstName + " " + this.LastName;
        return this.FullName;
    }
}



public class Telefon
{
    public string Marka { get; set; }
    public string Model { get; set; }
    public virtual string Sound() { return "Default Telefon Sesi"; }
}


public class SmartPhone : Telefon
{
    public bool HasCamera { get; set; }
    public string SendNotification { get; set; }
    public virtual string NotificationSond() { return "Default Notification Sesi"; }
}

public class Apple : SmartPhone
{
    public string FindMyPhone { get; set; }

    public override string Sound()
    {
        return "Apple Telefon Sesi"; //base.Sound(); //"Default Telefon Sesi"
    }

    public override string NotificationSond()
    {
        return "Apple Size Bildirim Gönderdi :)";
    }
}
public class Samsung : SmartPhone
{
    public string NFC { get; set; }
    public override string Sound()
    {
        return "Samsung Telefon Sesi";
    }
}
public class Nokia : SmartPhone
{
    public string WindowsSync { get; set; }
    public override string Sound()
    {
        return "Nokia Tune";
    }
}