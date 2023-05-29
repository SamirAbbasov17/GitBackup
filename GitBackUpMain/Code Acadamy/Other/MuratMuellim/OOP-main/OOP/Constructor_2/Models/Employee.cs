using System.ComponentModel.DataAnnotations.Schema;

namespace OOP.Constructor_2.Models;

public class Employee
{
   
    #region Constructor
    public Employee()
    {
        this.HireDate = DateTime.Now;
    }
    public Employee(string firstName) : this()
    {
        this.FirstName = firstName;
    }
    public Employee(string firstName, string lastName) : this(firstName: firstName)
    {
        this.LastName = lastName;
    }
    public Employee(string firstName, string lastName, string mail) : this(firstName: firstName, lastName: lastName)
    {
        this.Mail = mail;
    }
    public Employee(string firstName, string lastName, string mail, string phone) : this(firstName, lastName, mail)
    {
        this.Phone = phone;
    }
    public Employee(string firstName, string lastName, string mail, string phone, string address) : this(firstName, lastName, mail, phone)
    {
        this.Address = address;
    } 
    #endregion


    public int Id { get; set; }
    public string FirstName { get; set; } = null!;
    public string LastName { get; set; } = null!;
     
    private string? _mail;
    [NotMapped]  // Database içerisinde yer almayacak!!!
    public string Mail
    {
        get
        {
            if (string.IsNullOrWhiteSpace(this._mail))
            {
                _mail = $"{this.FirstName}.{this.LastName}@code.edu.az".ToLower();
            }
            return _mail;
        }
        set
        {
            _mail = value;
        }
    }


    [NotMapped]
    public string FullName { get => this.FirstName + " " + this.LastName; }


    //public string? Mail
    //{
    //    get => _mail;
    //    set
    //    {
    //        if (string.IsNullOrWhiteSpace(value))
    //        {
    //            _mail = $"{this.FirstName}.{this.LastName}@code.edu.az".ToLower();
    //        }
    //        else
    //        {
    //            _mail = value;
    //        }
    //    }
    //}


    public string? Address { get; set; }
    public string? Phone { get; set; }

    //public DateTime HireDate { get; set; } = DateTime.Now;
    //public DateTime HireDate { get => DateTime.Now; }
    public DateTime HireDate { get; private set; }
}


// ?         -> Null
// = null!   -> Not Null ( zorunlu alandır )