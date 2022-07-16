using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semesterarbeit
{
    interface IPerson
    {
        
        string Salutation { get; set; }
        string Firstname { get; set; }
        string Secondname { get; set; }
        string Lastname { get; set; }
        string Birthdate { get; set; }
        string Gender { get; set; }
        string Title { get; set; }
        string BusinessPhone { get; set; } 
        string BusinessFax { get; set; } 
        string MobileNumber { get; set; } 
        string Email { get; set; }
        Boolean Status { get; set; }
        string City { get; set; }
        string Street { get; set; }
        string Zipcode { get; set; }
        DateTime CreationDate { get; set; }
        string LastModified { get; set; }


        string GetClassName();
    }
}
