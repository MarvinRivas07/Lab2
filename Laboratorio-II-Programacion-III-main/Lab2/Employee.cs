using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public class Employee
    {
        public string Username { get; set; }
        public string Password { get; set; }

        public Employee(string username, string password)
        {
            Username = username;
            Password = password;
        }
    }
}
