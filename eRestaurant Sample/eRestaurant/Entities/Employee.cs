using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eRestaurant.Entities
{
    public class Employee
    {
        public Employee() 
        {
            Active = true;
        }

        public int EmployeeID { get; set; }
        public string FirstName {get; set;}
        public string LastName {get; set;}
        public char HomePhone {get; set;}
        public bool Active { get; set; }
    }
  
}
