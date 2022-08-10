using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace semesterarbeit
{
    enum CustType
    {
        A,
        B,
        C,
        D,
        E
    }

    class Customer : Person
    {
        public string Companyname { get; set; }
        public CustType Type { get; set; }
        public string Companycontact { get; set; }



        /******** Constructor ********/
        public Customer(int id, string salutation, string firstname, string lastname, string mail, Boolean status,
            DateTime creationDate, string changehistory, string companyname, CustType type, string companycontact)
            
            :base( id,  salutation,  firstname, lastname, mail, status,
            creationDate, changehistory)
        {
            Companyname = companyname;
            Type = type;
            Companycontact = Companycontact;
        }


        /******** Methods ********/

        public override string ToString()
        {
            return base.ToString() + ", " + Companyname + ", " + Type + ", " + Companycontact;
        }

        public override string PrintAll()
        {
            return base.PrintAll() + ", " + Companyname + ", " + Type + ", " + Companycontact;
        }

        public override string GetClassName()
        {
            return "Customer";
        }
    }
    
}
