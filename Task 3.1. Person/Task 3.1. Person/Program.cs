using System;
using System.Collections.Generic;

namespace Task_3._1._Person
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            int age;
            Console.Write("Enter the count > 5 of persons: count = ");
            int count = Convert.ToInt32(Console.ReadLine());
            while (count <= 5)
            {
                Console.WriteLine("Count has to be greater than 5!");
                Console.Write("Enter the count > 5 of persons: count = ");
                count = Convert.ToInt32(Console.ReadLine());
            }
            var list = new List<Person>();
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
                    phoneNumbers.Add(Console.ReadLine());
                }
                var person = new Person { Name = name, Age = age, PhoneNumbers = phoneNumbers };
                list.Add(person);
            }
            foreach (var item in list)
            {
                Console.WriteLine($"The name of person is: {item.Name}. The age of this person is {item.Age}");
            }
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
