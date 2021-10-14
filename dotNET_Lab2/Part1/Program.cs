using Lab2.Weather;
using System;

namespace Lab2
{
    class Program
    {
        static void Main()
        {
            //ExtractorTool extractorTool = new(@"C:\Users\DenisaIonela\Desktop\Lab2\weather.dat");
            ExtractorTool extractorTool = new(AppDomain.CurrentDomain.BaseDirectory.ToString() + @"..\..\..\weather.dat");
            DailyWeather[] weatherRecords = extractorTool.Weather;

            /*//DE CE MA LASA AGHHH
            extractorTool.Weather[0] = new DailyWeather(0,0,0,0,0,0,0,"0",0,0,0,0,0,0,0,0);*/

            foreach (var item in weatherRecords)
            {
                Console.WriteLine("The day is:" + item.Day);
                Console.WriteLine("The temperature spread is:" + item.TemperatureSpread());
            }
            Console.WriteLine("Minimum spread is on day " + DailyWeather.minimumSpread(weatherRecords));

        }
    }
}
