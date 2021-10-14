using System;
using System.IO;

namespace Part2
{
    class Import
    {
        public Football[] data { get; set; }
        public string path;

        public Import(string pth)
        {
            path = pth;
            data = Process(); 
        }

        public Football[] Process()
        {
            string[] lines = File.ReadAllLines(path);

            Football[] info = new Football[lines.Length];

            for (int i = 1; i < lines.Length; i++)
            {
                var elements = lines[i].Split((char[])null, StringSplitOptions.RemoveEmptyEntries);

                if (!elements[0].Contains("-------------"))
                {
                    info[i] = new Football(elements[1], elements[6], elements[8]);
                }
            }

            return info;
        }

    }
}
