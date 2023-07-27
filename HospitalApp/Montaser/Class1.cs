using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Montaser
{
    class Person
    {
        public DateTime Birthdate { get; set; }
        public string Firstname { get; set; }
        public string Fullname { get; set; }
        public string HomeAddress { get; set; }
        public string Lastname { get; set; }
        public string Phone { get; set; }
        public int PID { get; set; }
        public string Gender { get; set; }
        public string Ptype { get; set; }

        public Person()
        {

        }
        public Person(int pid, string ptype, string gender, string firstname, string lastname, DateTime birth, string homeaddress, string phone)
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
        public virtual int getAge()
        {
            var today = DateTime.Today;
            int age = today.Year - Birthdate.Year;
            if (Birthdate.Date > today.AddYears(-age)) age--;
            return age;
        }
        

    }
}
