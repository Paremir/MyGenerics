using System;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {

            MySet<int> sett1 = new MySet<int>(new int[] { 1, 2, 3,4,5 });
            MySet<int> sett2 = new MySet<int>(new int[] { 5,6,7,8 });
            MySet<int> subset = new MySet<int>(new int[] { 3,4,5 });

            Console.Write("Union:");
            foreach (var item in sett1.Union(sett2))
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            Console.Write("Intersection:");
            foreach (var item in sett1.Intersection(sett2))
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            Console.Write("Dif: ");
            foreach (var item in sett1.Difference(sett2))
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            Console.Write("Dif1: ");
            foreach (var item in sett2.Difference(sett1))
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            Console.Write("subset: ");
                Console.WriteLine(sett1.Subset(subset));

            Console.WriteLine();
            Console.Write("SymDif: ");
            foreach (var item in sett1.SymDif(sett2))
            {
                Console.Write(item + " ");
            }
        }
    }
}
