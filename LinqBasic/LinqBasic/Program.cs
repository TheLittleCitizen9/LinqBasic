using System;
using System.Collections.Generic;
using LinqBasic.Abstract;

namespace LinqBasic
{
    class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<Person> persons = new List<Person>()
                                       {
                                           new Person()
                                               {
                                                   Id = 1,
                                                   Name = "Tomer",
                                                   PersonGender = Gender.Male
                                               },
                                           new Person()
                                               {
                                                   Id = 2,
                                                   Name = "Tami",
                                                   PersonGender = Gender.Female
                                               },
                                                                                              new Person()
                                               {
                                                   Id = 3,
                                                   Name = "Nadav",
                                                   PersonGender = Gender.Male
                                               },
                                                                                           new Person()
                                               {
                                                   Id = 4,
                                                   Name = "Roy",
                                                   PersonGender = Gender.Male
                                               },
                                                                                          new Person()
                                               {
                                                   Id = 5,
                                                   Name = "Bar",
                                                   PersonGender = Gender.Female
                                               },

                                       };
            PersonRetriver personRetriver = new PersonRetriver();

            var malesId = personRetriver.GetMalesId(persons);
            foreach (var item in malesId)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("===================");
            var orderById = personRetriver.OrderById(persons);
            foreach (var item in orderById)
            {
                Console.WriteLine(item.Id);
            }

            Console.WriteLine("===================");
            var oddIds = personRetriver.GetOddIds(persons);
            foreach (var item in oddIds)
            {
                Console.WriteLine(item.Id);
            }


        }
    }
}
