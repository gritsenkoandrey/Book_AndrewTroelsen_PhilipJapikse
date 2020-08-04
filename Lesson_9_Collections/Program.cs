using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_9_Collections
{
    public class Program
    {
        static void Main(string[] args)
        {
            #region SortedSet

            //SortedSet<Person> people = new SortedSet<Person>(new SortPeopleByAge())
            //{
            //    new Person {PersonFirstName = "Homer", PersonLastName = "Simpsons", PersonAge = 47},
            //    new Person {PersonFirstName = "Marge", PersonLastName = "Simpsons", PersonAge = 45},
            //    new Person {PersonFirstName = "Bart", PersonLastName = "Simpsons", PersonAge = 9},
            //    new Person {PersonFirstName = "Liza", PersonLastName = "Simpsons", PersonAge = 7}
            //};

            //foreach (Person item in people)
            //{
            //    Console.WriteLine(item);
            //}

            //Console.WriteLine();

            //people.Add(new Person { PersonFirstName = "Andrey", PersonLastName = "Gritsenko", PersonAge = 32 });
            //people.Add(new Person { PersonFirstName = "Irina", PersonLastName = "Gritsenko", PersonAge = 35 });
            //people.Add(new Person { PersonFirstName = "Arina", PersonLastName = "Gritsenko", PersonAge = 2 });

            //foreach (Person item in people)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region Dictionary

            //Dictionary<string, Person> personsA = new Dictionary<string, Person>();
            ////Наполнить с помощью метода Add()
            //personsA.Add("Homer", new Person { PersonFirstName = "Homer", PersonLastName = "Simpson", PersonAge = 47 });
            //personsA.Add("Marge", new Person { PersonFirstName = "Marge", PersonLastName = "Simpson", PersonAge = 45 });
            //personsA.Add("Liza", new Person { PersonFirstName = "Liza", PersonLastName = "Simpson", PersonAge = 9 });

            ////Наполнить с помощью синтаксиса инициализации.
            //Dictionary<string, Person> personsB = new Dictionary<string, Person>()
            //{
            //    {"Homer", new Person{ PersonFirstName = "Homer", PersonLastName = "Simpson", PersonAge = 47 }},
            //    {"Marge", new Person { PersonFirstName = "Marge", PersonLastName = "Simpson", PersonAge = 45 }},
            //    {"Liza", new Person { PersonFirstName = "Liza", PersonLastName = "Simpson", PersonAge = 9 }}
            //};

            //// Наполнить с помощью синтаксиса инициализации словаря.
            //Dictionary<string, Person> personsC = new Dictionary<string, Person>()
            //{
            //    ["Homer"] = new Person { PersonFirstName = "Homer", PersonLastName = "Simpson", PersonAge = 47 },
            //    ["Marge"] = new Person { PersonFirstName = "Marge", PersonLastName = "Simpson", PersonAge = 45 },
            //    ["Liza"] = new Person { PersonFirstName = "Liza", PersonLastName = "Simpson", PersonAge = 9 }
            //};

            //// Получить элемент
            //Person homer = personsA["Homer"];
            //Person marge = personsB["Marge"];
            //Person liza = personsC["Liza"];
            //Console.WriteLine(homer);
            //Console.WriteLine(marge);
            //Console.WriteLine(liza);

            #endregion

            Console.ReadLine();
        }
    }
}
