using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq.Expressions;
using System.Reflection;

namespace OOP.Example_1.Models;

public class Employee
{
    public int EmployeeId { get; set; }
    public string? Name { get; set; }
    public EmployeeDetail? Detail { get; set; }
}


public class EmployeeDetail
{
    public int EmployeeId { get; set; }
    public Employee? Employee { get; set; }
    public string? Description { get; set; }
}


public class Country
{

    public Country()
    {
        this.Cities = new HashSet<City>();
    }
    public int Id { get; set; }  // primarykey
    public string? Name { get; set; }

    public virtual ICollection<City>? Cities { get; set; }
}


public class City
{



    public int Id { get; set; }
    public string? Name { get; set; }


    public int UlkeId { get; set; }
    public int UlkecikId { get; set; }
    public int UlkeciklerId { get; set; }
    public int MiniklerId { get; set; }

    [ForeignKey("Country")]
    public int MiniminiminiklerId { get; set; }
    public virtual Country? Country { get; set; }
}

public class E1
{
    public string? FirstName { get; set; }
    public virtual void Update(string firstName)
    {
        this.FirstName = firstName;
    }
}


public class E2 : E1
{
    public E2() { }

    public string? LastName { get; set; }
    public string? Mail { get; set; }

    public void Update(string firstName, string lastName, string mail)
    {
        this.LastName = lastName;
        this.Mail = mail;
        base.Update(firstName);
    }

    public virtual void Update(Dictionary<string, object> items)
    {
        //foreach (KeyValuePair<string, object> keyVal in items)
        foreach (var keyVal in items)
        {
            string pName = keyVal.Key;
            object pValue = keyVal.Value;

            // this.pNameV = pValue;


            //Expression<Func<string>> member = (() => pName);
            //var memberExp = (MemberExpression)member.Body;
            //string vName = memberExp.Member.Name;


            switch (pName)
            {
                case "FirstName":
                    {
                        this.FirstName = pValue.ToString();
                        break;
                    }
                case "LastName":
                    {
                        this.LastName = pValue.ToString();
                        break;
                    }
                case "Mail":
                    {
                        this.Mail = pValue.ToString();
                        break;
                    }
                default:
                    break;
            }
        }
    }
}

