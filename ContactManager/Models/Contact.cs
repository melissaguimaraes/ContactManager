using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactManager.Models
{
    internal class Contact
    {
        
        public string Salutation { get; set; }                
        public string FirstName { get; set; }                 
        public string LastName { get; set; }                  
        public DateOnly? DateOfBirth { get; set; }            
        public string Gender { get; set; }                    
        public string Title { get; set; }                     
        public string BusinessPhone { get; set; }             
        public string MobilePhone { get; set; }               
        public string EmailAddress { get; set; }              
        public string Status { get; set; }                    

        public string EmployeeNumber { get; set; }            
        public string Department { get; set; }                
        public string AhvNumber { get; set; }                 
        public string Residence { get; set; }                  
        public string Nationality { get; set; }                
        public string Address { get; set; }                    
        public string PostalCode { get; set; }                 
        public string PrivatePhone { get; set; }               
        public DateOnly? EntryDate { get; set; }              
        public DateOnly? ExitDate { get; set; }               
        public string Workload { get; set; }                  
        public string Role { get; set; }                      
        public int? ManagementLevel { get; set; }             
        public int? ApprenticeshipYears { get; set; }         
        public int? CurrentApprenticeshipYear { get; set; }   
        public string CompanyName { get; set; }               
        public string BusinessAddress { get; set; }           
        public string CustomerType { get; set; }              
        public string CompanyContact { get; set; }            
    


    }
}
