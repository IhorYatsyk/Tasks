using System;
using System.Collections.Generic;

namespace Task_3._2._PersonWithAddRange
{
    class Program
    {
        static void Main(string[] args)
        {
            string name, numbersOfAllPersons = "", numberOfPerson;
            int age;
            Console.Write("Enter the count > 5 of persons: count = ");
            int count = Convert.ToInt32(Console.ReadLine());
            while (count <= 5)
            {
                Console.WriteLine("Count has to be greater than 5!");
                Console.Write("Enter the count > 5 of persons: count = ");
                count = Convert.ToInt32(Console.ReadLine());
            }
            var list1 = new List<Person>();
            for (int i = 0; i < count; i++)
            {
                Console.Write($"Enter the name of the {i + 1} person: name = ");
                name = Console.ReadLine();
                Console.Write($"Enter the age of the {i + 1} person: age = ");
                age = Convert.ToInt32(Console.ReadLine());
                Console.Write($"Enter the count of {i + 1} person phone numbers > 2: count of phone numbers = ");
                int countOfNumbers = Convert.ToInt32(Console.ReadLine());
                while (countOfNumbers <= 2)
                {
                    Console.WriteLine("The count of phone numbers has to be greater than two!");
                    Console.Write($"Enter the count of {i + 1} person phone numbers > 2: count of phone numbers = ");
                    countOfNumbers = Convert.ToInt32(Console.ReadLine());
                }
                var phoneNumbers = new List<string>();
                for (int j = 0; j < countOfNumbers; j++)
                {
                    Console.Write($"Enter the {j + 1} number of {i + 1} person: ");
                    numberOfPerson = Console.ReadLine();
                    numbersOfAllPersons = numbersOfAllPersons + numberOfPerson + ", ";
                    phoneNumbers.Add(numberOfPerson);
                }
                var person = new Person { Name = name, Age = age, PhoneNumbers = phoneNumbers };
                list1.Add(person);
            }
            var list2 = new List<Person>();
            Console.WriteLine("Add two persons.");
            for (int i = 0; i < 2; i++)
            {
                Console.Write($"Enter the name of the {i + count + 1} person: name = ");
                name = Console.ReadLine();
                Console.Write($"Enter the age of the {i + count + 1} person: age = ");
                age = Convert.ToInt32(Console.ReadLine());
                Console.Write($"Enter the count of {i + count + 1} person phone numbers > 2: count of phone numbers = ");
                int countOfNumbers = Convert.ToInt32(Console.ReadLine());
                while (countOfNumbers <= 2)
                {
                    Console.WriteLine("The count of phone numbers has to be greater than two!");
                    Console.Write($"Enter the count of {i + count + 1} person phone numbers > 2: count of phone numbers = ");
                    countOfNumbers = Convert.ToInt32(Console.ReadLine());
                }
                var phoneNumbers = new List<string>();
                for (int j = 0; j < countOfNumbers; j++)
                {
                    Console.Write($"Enter the {j + 1} number of {i + count + 1} person: ");
                    numberOfPerson = Console.ReadLine();
                    numbersOfAllPersons = numbersOfAllPersons + numberOfPerson + " ";
                    phoneNumbers.Add(numberOfPerson);
                }
                var person = new Person { Name = name, Age = age, PhoneNumbers = phoneNumbers };
                list2.Add(person);
            }
            list1.AddRange(list2);
            foreach (var item in list1)
            {
                Console.WriteLine($"The name of person is: {item.Name}. The age of this person is {item.Age}");
            }
            Console.WriteLine("All phone numbers: " + numbersOfAllPersons);
            Console.ReadKey();
        }
    }
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public IEnumerable<string> PhoneNumbers { get; set; }
    }
}
