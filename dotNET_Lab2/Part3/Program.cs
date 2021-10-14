
using System;

namespace Lab2.net
{
    class Program
    {
        static void Main(string[] args)
        {
            Importer football = new Importer(AppDomain.CurrentDomain.BaseDirectory.ToString() + @"..\..\..\Data\football.dat", 1, 6, 8);
            Importer weather = new Importer(AppDomain.CurrentDomain.BaseDirectory.ToString() + @"..\..\..\Data\weather.dat", 0, 1, 2);

            Console.WriteLine(Data.FindMin(football.DataList));
            Console.WriteLine(Data.FindMin(weather.DataList));

        }
    }
}
