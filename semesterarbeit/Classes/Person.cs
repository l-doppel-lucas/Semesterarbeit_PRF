using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace semesterarbeit
{
    class Person
    {
       public string Firstname { get; set; }

        public string Lastname { get; set; }

        public DateTime Birthdate { get; set; }

        public bool IsDeleted { get; set; }

        public Person(string firstname, string lastname, DateTime birthdate, bool isDeleted)
        { 
            Firstname = firstname;
            Lastname = lastname;
            Birthdate = birthdate;
            IsDeleted = isDeleted;
        }

        public override bool Equals(object obj)
        {
            return obj is Person person &&
                   Firstname == person.Firstname &&
                   Lastname == person.Lastname &&
                   Birthdate == person.Birthdate;
        }

        public override string ToString()
        {
            return Firstname + ", " + Lastname + ", " + Birthdate.ToShortDateString();
        }
    }
}
