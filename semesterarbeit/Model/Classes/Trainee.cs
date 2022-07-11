using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace semesterarbeit
{
    class Trainee : Employee
    {

        public int Appyears { get; set; }
        public int Currappyear { get; set; }


        /******** Constructor ********/

        public Trainee(bool status, int id, string title, string salutation, string firstname, string lastname, DateTime birthdate, string gender, string ahv,
            string nationality, string privatephone, string mobilephone, string businessphone, string businessfax, string mail, string departement, DateTime entrydate, 
            DateTime exitdate, string employmentlvl, string role, MgmLvl lvl, int appyears, int currappyear) : 
            base(status, id, title, salutation, firstname, lastname, birthdate, gender, ahv, 
                nationality, privatephone, mobilephone, businessphone, businessfax, mail, 
                departement, entrydate, exitdate, role, employmentlvl, lvl)
        {
            Appyears = appyears;
            Currappyear = currappyear;
        }
    }
}
