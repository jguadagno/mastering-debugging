using System;
using System.Collections.Generic;
using System.Linq;

namespace MasteringDebugging
{
    static class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = PopulatePeople();

            foreach (var person in people)
            {
                Console.WriteLine(person.FullName);
            } 
            var parentCount = people.Where(p => p.LastName =="Guadagno").Count(p => p.Children is not null);
            Console.WriteLine($"Number of parents is {parentCount}");
            Console.WriteLine("Press Enter");
            Console.ReadLine();
            Console.WriteLine("Done");
        }
        static List<Person> PopulatePeople ()
        {
            return new List<Person> {
                new Person {FirstName = "Joseph", MiddleInitial="J", LastName="Guadagno", Email="jguadagno@hotmail.com", DateOfBirth= DateTime.Parse("05/31/1971 2:17 am"), Children = new List<Person> {new Person {FirstName = "JJ"}}},
                new Person {FirstName = "Deidre", MiddleInitial="A", LastName="Guadagno", Email="deeguadagno@hotmail.com", DateOfBirth= DateTime.Parse("05/03/1970")},
                new Person {FirstName = "Joseph", MiddleInitial="J", LastName="Guadagno", Email="jjguadagno@gmail.com", DateOfBirth= DateTime.Parse("05/31/1997")},
                new Person {FirstName = "Emily", MiddleInitial="E", LastName="Guadagno", Email="eeguadagno@msn.com", DateOfBirth= DateTime.Parse("05/31/1999")}
            };
        }
    }
}