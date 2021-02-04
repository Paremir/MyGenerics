using System;

namespace Map_Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            var dict = new Dictionary<int, string>();
            dict.Add(new Item<int, string>(1, "Один"));
            dict.Add(new Item<int, string>(2, "Два"));
            dict.Add(new Item<int, string>(3, "Три"));
            dict.Add(new Item<int, string>(1, "Один"));

            foreach (var item in dict)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(dict.Search(1));
            Console.WriteLine(dict.Search(2));
            Console.WriteLine(dict.Search(8));

            dict.Remove(1);
            dict.Remove(2);
            foreach (var item in dict)
            {
                Console.WriteLine(item);
            }
        }
    }
}
