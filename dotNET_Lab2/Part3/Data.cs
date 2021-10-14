using System;

namespace Lab2.net
{
    class Data
    {
        public string name;
        public string col1;
        public string col2;

        public Data(string n, string c1, string c2)
        {
            name = n;
            col1 = c1;
            col2 = c2;
        }

        public int AbsDif()
        {
            return Math.Abs(Int32.Parse(col1) - Int32.Parse(col2));
        }

        public static string FindMin(Data[] info)
        {
            int min = info[0].AbsDif();
            string name = info[0].name;

            foreach (var item in info)
            {
                if(item != null && item.AbsDif() < min)
                {
                    min = item.AbsDif();
                    name = item.name;
                }
            }

            return name;
        }
    }
}
