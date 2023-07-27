using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Montaser;

namespace dcMontaser
{
    class Doctor :  Person
    {
        private string Education { get; set; }
        private string[] Languages { get; set; }
        private string[] Specialities { get; set; }

        public Doctor()
        {

        }
        public Doctor(int pid, string ptype, string gender, string firstname, string lastname, DateTime birth, string homeaddress, string phone)
        {
            this.PID = pid;
            this.Ptype = ptype;
            this.Gender = gender;
            this.Firstname = firstname;
            this.Lastname = lastname;
            this.Birthdate = birth;
            this.HomeAddress = homeaddress;
            this.Phone = phone;
        }
        public void treatlllness()
        {

        }
        public void treatlnjury()
        {

        }
    }
}
