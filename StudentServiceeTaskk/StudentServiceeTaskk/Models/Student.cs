using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentServiceeTaskk.Models
{
    internal class Student
    { public static int Idd {  get; private set; }
      public int Id { get; set; }
      public string FirstName { get; set; }
      public string LastName { get; set; }
      public string Email { get; set; }
      public string PhoneNumber { get; set; }
      public string Status { get; set; }
      public double GPA { get; set; }
      public string Major { get; set; }

        public Student()
        {
            Id = Idd;
            Idd++;

        }
    }
 
    
}
