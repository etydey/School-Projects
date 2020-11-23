using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MDIApplication.EtyDey
{
    public class Employee
    {
        public string FirstName;
        public string LastName;
        public string City;
        public string Email;
        public string PhoneNumber;
        public decimal Salary;
        public string Department;

        public Employee() { }

        public Employee(string firstName,string lastName,string city,string email,string phoneNumber,decimal salary, string department)
        {
            if(phoneNumber.Length>12)
            {
                throw new Exception("Phone Number cannot be more than 12 Character.");
            }

            FirstName = firstName;
            LastName = lastName;
            City = city;
            Email = email;
            PhoneNumber = phoneNumber;
            Salary = salary;
            Department = department;
        }

        public override string ToString()
        {
            return FirstName + " " + LastName + City + ", " + Email + ", " + PhoneNumber + ", " + Salary.ToString("c") + ", " + Department;
        }
    }
}
