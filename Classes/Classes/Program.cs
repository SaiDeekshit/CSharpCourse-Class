using System;

namespace Classes
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //Creating instance for first person
            Person firstPerson = new Person();
            firstPerson.FirstName = "Rama";
            firstPerson.LastName = "Krishna";
            firstPerson.Country = "India";

            //Creating instance for second person
            Person secondPerson = new Person();
            secondPerson.FirstName = "Tim";
            secondPerson.LastName = "David";
            secondPerson.Country = "Australia";

            Console.WriteLine(firstPerson.FirstName);
            Console.WriteLine(secondPerson.FirstName);
        }

    }

    //Class represent person details
    class Person
    {
        string firstName;
        string lastName;
        DateTime birthDate;
        string country;

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public DateTime BirthDate { get; set; }

        public string Country { get; set; }
    }
}
