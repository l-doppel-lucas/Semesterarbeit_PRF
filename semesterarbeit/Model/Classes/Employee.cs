﻿using System;

namespace semesterarbeit
{
    public enum MgmLvl
    {
        Level0,
        Level1,
        Level2,
        Level3,
        Level4,
        Level5
    }

    [Serializable()]
    class Employee : Person
    {
        public int EmplNr { get; set; }
        public string Departement { get; set; }
        public string Workpensum { get; set; }
        public string Ahv { get; set;}
        public string Nationality { get; set; }
        public string Birthplace{ get; set; }
        public string Privatephone { get; set; }
        public DateTime Entrydate { get; set; }
        public DateTime Exitdate { get; set; }
        public string Role { get; set; }
        public MgmLvl Lvl { get; set; }


        /*---------------------------------------------------------------------
        Methods
        -----------------------------------------------------------------------*/

        public void SetMandatoryAttributes(bool disabled, string sal, string fn, string ln, DateTime birthdate, string gender, string mail,  
            string street, string city, string zip, string changehistory, string departement, string role, string pens, DateTime entrdate)
        {
            base.SetMandatoryAttributes(disabled, sal, fn, ln, birthdate, gender, mail, street, city, zip, changehistory);

            Departement = departement;
            Workpensum = pens;
            Entrydate = entrdate;
            Role = role;
        }

        public void SetOptionalAttributes(string title, string mph, string bph, string bfa, string ahv, string nat,
            string pph, string birthpl, DateTime exdate, MgmLvl lvl)
        {
            base.SetOptionalAttributes(title, mph, bph, bfa);

            Ahv = ahv;
            Nationality = nat;
            Privatephone = pph;
            Birthplace = birthpl;
            Exitdate = exdate;
            Lvl = lvl;
        }


        public override string ToString()
        {
            return base.ToString() + ", " + Departement + ", " + Entrydate + ", " + Exitdate + ", " + Workpensum + ", " + Role + ", " + Lvl;
        }

        public override string GetClassName()
        {
            return "Employee";
        }
    }
}
