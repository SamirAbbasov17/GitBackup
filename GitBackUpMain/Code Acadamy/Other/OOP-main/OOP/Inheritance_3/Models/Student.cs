namespace OOP.Inheritance.Models;

public class Student : BasePerson
{
    public Student() { }
    public Student(string firstName, string lastName, string schoolNumber)
    {
        this.SchoolNumber = schoolNumber;
        base.FirstName = firstName;
        base.LastName = lastName;
    }

    public string SchoolNumber { get; set; } = null!;
    public string? Section { get; set; }

    /// <summary>
    /// Öğrenciyi Güncelle
    /// </summary>
    /// <param name="firstName">Adı</param>
    /// <param name="lastName">Soyadı</param>
    /// <param name="schoolNumber">Okul Numarası</param>
    public void Update(string firstName, string lastName, string schoolNumber)
    {
        this.SchoolNumber = schoolNumber;
        base.FirstName = firstName;
        base.LastName = lastName;
    }
}
