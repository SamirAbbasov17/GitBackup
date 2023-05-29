using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewLessonOOP.Models
{
    internal class User : IAccount
    {
        public User(string email,string password,string fullName)
        {
            id++;
            Email = email;
            Password = password;
            FullName = fullName;
        }
        private static int id = 0;

        public int Id { get { return id; } }
        private string password; 
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Password { get { return password; } set { if (PasswordChecker(value))
                {
                    password = value;
                }
                else { throw new Exception("Duzgun Password daxil edin"); } } }

        public bool PasswordChecker(string password)
        {
            if(password.Length < 9 || password.Count(x => char.IsUpper(x)) < 1 || password.Count(x => char.IsLower(x)) < 1 || password.Count(x => char.IsDigit(x)) < 1)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public string ShowInfo()
        {
            string soz = $"""
                user id    -> {this.Id}
                user name  -> {this.FullName}
                user email -> {this.Email}
                """;
            return soz;
        }
    }
}
