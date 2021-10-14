using System;
using System.IO;
using System.Collections.Generic;

namespace Part2
{
    class Program
    {
        static void Main(string[] args)
        {
            Import football = new Import(AppDomain.CurrentDomain.BaseDirectory.ToString() + @"..\..\..\Data\football.dat");

            Console.WriteLine(Football.Find(football.data));
        }
    }
}
