using FamilyTree.Model;
using FamilyTree.Service;
using System;

namespace FamilyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person();
            person1.FirstName = "David";

            Person person2 = new Person();
            person2.FirstName = "Daniel";

            Person person3 = new Person();
            person3.FirstName = "Rachel";

            Person person4 = new Person();
            person4.FirstName = "Daniel";

            person1.Children = new Person[] { person2, person3 };
            person3.Children = new Person[] { person4 };

            PersonService personService = new PersonService();
            Console.WriteLine(personService.FindSameName(person1, "Daniel"));
            Console.ReadLine();
        }
    }
}
