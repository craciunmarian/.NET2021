using System;
using Extension;

namespace dotNET_Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            Manager m = new Manager("aaaaa", "bbbb", new DateTime(2021, 5, 1), new DateTime(2021, 7, 10), 1234.5);
            Architect a = new Architect("cccc", "dddd", new DateTime(2021, 10, 1), new DateTime(2021, 11, 10), 2100);

            Console.WriteLine(a.GetFullName());
            Console.WriteLine(a.IsActive());
            Console.WriteLine(a.Salutation());
            Console.WriteLine(m.Salutation());

            string s = "ana are mere";

            var arr = s.SplitWords();

            foreach (var i in arr)
            {
                Console.WriteLine(i);
            }
        }
    }
}
