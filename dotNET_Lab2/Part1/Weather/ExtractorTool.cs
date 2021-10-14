using System;
using System.IO;

namespace Lab2.Weather
{
    class ExtractorTool
    {
        public DailyWeather[] Weather { get; private set; }
        private readonly string fileName;

        public ExtractorTool(string fileName)
        {
            this.fileName = fileName;
            Weather = ExtractInfo();
        }

        private DailyWeather[] ExtractInfo()
        {
            string[] lines = File.ReadAllLines(fileName);

            DailyWeather[] weatherInfo = new DailyWeather[lines.Length - 2];

            for (int i = 1; i < lines.Length - 1; i++)
            {
                var elements = lines[i].Split((char[])null, StringSplitOptions.RemoveEmptyEntries);
                try
                {
                    weatherInfo[i - 1] = new DailyWeather(Int32.Parse(elements[0]),
                        Decimal.Parse(elements[1]),
                        Decimal.Parse(elements[2]),
                        Decimal.Parse(elements[3]),
                        Int32.Parse(elements[4]),
                        Decimal.Parse(elements[5]),
                        Decimal.Parse(elements[6]),
                        elements[7],
                        Int32.Parse(elements[8]),
                        Decimal.Parse(elements[9]),
                        Int32.Parse(elements[10]),
                        Int32.Parse(elements[11]),
                        Decimal.Parse(elements[12]),
                        Int32.Parse(elements[13]),
                        Int32.Parse(elements[14]),
                        Decimal.Parse(elements[15]));
                }
                catch (FormatException)
                {
                    Console.WriteLine("Unable to parse weather.");
                }
            }
            return weatherInfo;
        }
        
    }
}
