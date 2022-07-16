using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semesterarbeit
{
    [Serializable()]
    class Customer : Person
    {

        /***************Properties***********************/
        //(Auto-)Properties
        public string CompanyName { get; set; }
        public string CustomerType { get; set; }
        public string ContactPerson { get; set; }
        public string NotesHistory { get; set; }

        /***************Constructor***********************/

        public Customer(int id,string salutation, string firstname, string lastname, string email, Boolean status,
            DateTime creationDate, string lastmodified, string companyname, string customertype) :
            base(id,salutation, firstname,lastname, email, status, creationDate, lastmodified)
        {
            CompanyName = companyname;
            CustomerType = customertype;
        }

        /***************Methods***************************/

        //Method to set all optional attributes
        public void SetOptionalAttributes(string sn = "", string g = "", string t = "", string bp = "", string bf = "",
             string mn = "", string s = "", string zc = "", string c = "", string bdate = "", string cp = "")
        {
            base.SetOptionalAttributes(sn, g, t, bp, bf, mn, s, zc, c, bdate);

            ContactPerson = cp;
            
        }

        //Method to set all mandatory attributes
        public void SetMandatoryAttributes(string sal, string fn, string ln, string email, string compn, string cutype)
        {
            base.SetMandatoryAttributes(sal, fn, ln, email);

            CompanyName = compn;
            CustomerType = cutype;
        }

        //Override method to return the name of the class as a string
        public override string GetClassName()
        {
            return "Customer";
        }

    }
}
