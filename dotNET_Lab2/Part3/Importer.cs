using System;
using System.IO;

namespace Lab2.net
{
    class Importer
    {
        public Data[] DataList { get; private set; }
        private readonly string fileName;

        public Importer(string fileName, int index1, int index2, int index3)
        {
            this.fileName = fileName;
            DataList = ExtractInfo(index1, index2, index3);
        }

        private Data[] ExtractInfo(int index1, int index2, int index3)
        {
            string[] lines = File.ReadAllLines(Path.Combine(Directory.GetCurrentDirectory(), fileName));

            Data[] info = new Data[lines.Length - 2];

            int k = 0;

            for (int i = 1; i < lines.Length; i++)
            {
                var elements = lines[i].Split((char[])null, StringSplitOptions.RemoveEmptyEntries);

                if (!elements[0].Contains("-----------") && !elements[0].Contains("mo"))
                {
                    try
                    {
                        info[k++] = new Data(elements[index1], elements[index2], elements[index3]);
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Unable to parse weather.");
                    }
                }
            }

            return info;
        }

    }
}

