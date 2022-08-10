using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace semesterarbeit
{
    class Trainee : Employee
    {

        public string Appyears { get; set; }
        public string Currappyear { get; set; }


        /*---------------------------------------------------------------------
        Constructor
        -----------------------------------------------------------------------*/

        public Trainee(int id, string salutation, string firstname, string lastname, string email, Boolean status,
             DateTime creationDate, string lastmodified, string department, string role, string appyears) :
             base(id, salutation, firstname, lastname, email, status, creationDate, lastmodified, department, role)
        {
            Appyears = appyears;
        }


        /*---------------------------------------------------------------------
        Methods
        -----------------------------------------------------------------------*/
        public override string ToString()
        {
            return base.ToString() + ", " + Appyears + ", " + Currappyear;
        }

        public override string PrintAll()
        {
            return base.PrintAll() + ", " + Appyears + ", " + Currappyear;
        }


        public override string GetClassName()
        {
            return "Trainee";
        }


    }
}
