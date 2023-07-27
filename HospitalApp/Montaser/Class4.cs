using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Montaser;

namespace heMontaser
{
    class Helper : Person
    {
            private Random rnd = new Random();
            private string[] firstNamesPatients = { "Alexandra", "Alison", "Maria", "Sophie", "Wanda" }, firstNamesDoctors = { "Brandon", "David", "Gordon", "Jonathan", "Peter" }, lastNames = { "Abraham", "Campbell", "Ellison", "Henderson", "Johnston" }, streets = { "2708 Adonais Way", "4154 Cherry Tree Drive", "3466 Wilmar Farm Road", "1949 Jadewood Drive", "501 Blane Street" }, cities = { "Atlanta", "Jacksonville", "Lanham", "Wheatfield", "Fairview Heights" };
            private string generateElementOf(string[] strArray) { return strArray[rnd.Next(strArray.Length)]; }
            private string generateGender() { return rnd.Next(2) == 0 ? "Female" : "Male"; }
            private string generateRole() { return rnd.Next(2) == 0 ? "Patient" : "Doctor"; }
            private DateTime generateBirthDate() { DateTime start = new DateTime(1900, 1, 1); int range = (DateTime.Today - start).Days; return start.AddDays(rnd.Next(range)).AddHours(rnd.Next(24)).AddMinutes(rnd.Next(60)).AddSeconds(rnd.Next(60)); }
            private string generatePhoneNumber() { return rnd.Next(100, 1000) + "-" + rnd.Next(100, 1000) + "-" + rnd.Next(1000, 10000); }
            public Person generatePerson()
            {
                Person person = new Person(); 
                person.Gender = generateGender();
                person.Ptype = generateRole();
                person.Firstname = generateElementOf(this.Gender.Equals("Patient") ? firstNamesPatients : firstNamesDoctors); 
                person.Lastname = generateElementOf(lastNames); 
                person.Birthdate = generateBirthDate(); 
                person.Phone = generatePhoneNumber();
                person.HomeAddress = generateElementOf(streets);
                if (generateRole() == "Patient")
            {
                person.Allergies = new List<Allergies>();
                person.Sickness = "Cold";
            }
                if (generateRole() == "Doctor")
            {
                perosn.Specialities = new List<Specialities>();
                person.Languages = new List<Languages>();
            }
                return person;
               
            }
        }
    }

