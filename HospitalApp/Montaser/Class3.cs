using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Montaser;

namespace ptMontaser
{
    class Patient : Person
    {
        public DateTime Accepted { get; set; }
        public string[] Allergies { get; set; }
        public string Sickness { get; set; }
        public void arrive()
        {

        }
        public void eat()
        {

        }
        public void leave()
        {

        }
        public Patient()
        {

        }
        public Patient(int pid, string ptype, string gender, string firstname, string lastname, DateTime birth, string homeaddress, string phone)
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


    }
}
