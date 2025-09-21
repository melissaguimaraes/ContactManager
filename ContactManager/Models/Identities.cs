using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactManager.Models
{
    // Person class -> Mother class for all User related sub classes
    public class Person
    {
        public string PersonalNumber { get; set; }
        public string Salutation { get; set; }                
        public string FirstName { get; set; }                 
        public string LastName { get; set; }
        public string FullName => $"{FirstName} {LastName}";
        public DateOnly DateOfBirth { get; set; }            
        public string Gender { get; set; }                    
        public string Title { get; set; }                     
        public string BusinessPhone { get; set; }             
        public string MobilePhone { get; set; }
        public string PrivatePhone { get; set; }
        public string EmailAddress { get; set; }              
        public bool Status { get; set; }                            
        public string AhvNumber { get; set; }                 
        public string City { get; set; }                  
        public string Nationality { get; set; }                
        public string Street { get; set; }                    
        public string PostalCode { get; set; }                           
    }

    // from here customer and employee (maybe in future more person types) hinherit from person //

    public class Customer : Person
    {
        public string CompanyName { get; set; }
        public char CustomerType { get; set; }
        public Employee CompanyContact { get; set; }
    }

    public class Employee : Person
    {
        public string Department { get; set; }
        public DateOnly? EntryDate { get; set; }
        public bool IsLeaving { get; set; }
        public DateOnly? ExitDate { get; set; }
        public string Workload { get; set; }
        public string Role { get; set; }
        public int? ManagementLevel { get; set; }
        public bool IsAdmin { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
   
    }

    // inherits from Employee
    public class Trainee : Employee
    {
        public int? ApprenticeshipYears { get; set; }
        public int? CurrentApprenticeshipYear { get; set; }
    }
}
