using System;

namespace HashTable
{
    class Program
    {
        static void Main(string[] args)
        {
            var myhas = new HashTable<Person>(100);
            myhas.Add(new Person() {Name="Вася",Age=23,Gender=1 });
            myhas.Add(new Person() {Name="Петр",Age=43,Gender=1 });
            myhas.Add(new Person() {Name="Ион",Age=13,Gender=1 });
            myhas.Add(new Person() {Name="Штефан",Age=53,Gender=1 });
            myhas.Add(new Person() {Name="Вася",Age= 23,Gender=1 });
            var person = new Person() { Name = "Вася", Age = 23, Gender = 1 };
            myhas.Add(person);

            Console.WriteLine(myhas.Search((new Person() { Name = "Вася", Age = 23, Gender = 1 })));
            Console.WriteLine(myhas.Search(person));

        }
    }
}
