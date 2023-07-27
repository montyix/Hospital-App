using System;
using Montaser;
using heMontaser;
using dcMontaser;
using ptMontaser;

namespace PersonApp
{
    class Program
    {
        static void Main()
        {
            Helper personGenerator = new Helper();
            Person person = personGenerator.generatePerson();
            Console.WriteLine("==========");
            Console.WriteLine("Firstname: {0} \n\r Lastname: {1} \n\r Gender: {2} \n\r Birthday: {3} \n\r Role: {4}", person.Firstname, person.Lastname, person.Gender, person.Birthdate, person.Ptype);
            if (person.Ptype == "Patient")
            {
                Console.WriteLine("Entrance: {0} \n\r Leaving: {1} \n\r Sicknes: {2} \n\r Allergies: {4} \n\r Sickness: {5}", person.arrive(). person.leave(),)
            }
            if (person.Ptype == "Doctor")
            {
                Console.WriteLine("Specialities:{0} \n\r Languages: {1} \n\r Education: {2}", )
            }
        }
    }
}

