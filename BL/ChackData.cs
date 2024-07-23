using DAL.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BL
{
    public class ChackData
    {
        public static void ChackDetails(Employee newEmployee)
        {
            //if (newEmployee.Id < 100000000 || newEmployee.Id > 999999999)
            //    throw new ArgumentException("Validation failed for field – Id");
            if (newEmployee.FirstName.Length < 2 || !newEmployee.FirstName.All(char.IsLetter))
                throw new ArgumentException("Validation failed for field – First Name");
            if (newEmployee.LastName.Length < 2 || !newEmployee.LastName.All(char.IsLetter))
                throw new ArgumentException("Validation failed for field – Last Name");
            if (newEmployee.Age < 18 || newEmployee.Age > 67)
                throw new ArgumentException("Validation failed for field – Age");
            if (newEmployee.StartOfWorkYear < 1980 || newEmployee.StartOfWorkYear > DateTime.Now.Year)
                throw new ArgumentException("Validation failed for field – Start Of Work Year");

            InterviewsMBL interviewsMBL = new InterviewsMBL();
            List<string> roles = new List<string>();
            roles = interviewsMBL.GetRoles();
            if (!roles.Contains(newEmployee.RoleInCompany))
                throw new ArgumentException("Validation failed for field – Role In Company");
            if (newEmployee.PhoneNumber.Length != 10 || !newEmployee.PhoneNumber.All(char.IsDigit))
                throw new ArgumentException("Validation failed for field – Phone Number");
            if (Regex.IsMatch(@"^[^@\s]+@[^@\s]+\.[^@\s]+$", newEmployee.Email))
                throw new ArgumentException("Validation failed for field – Email");


        }
    }
}