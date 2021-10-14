using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part2
{
    class Football
    {
        public string team, F, A;

        public Football(string s1, string s2, string s3)
        {
            team = s1;
            F = s2;
            A = s3;
        }

        public int AbsDif()
        {
            return Math.Abs(Int32.Parse(F) - Int32.Parse(A));
        }

        public static string Find(Football[] arr)
        {
            int min = arr[1].AbsDif();
            string name = arr[1].team;

            foreach (var item in arr)
            {
                if (item != null && item.AbsDif() < min)
                {
                    min = item.AbsDif();
                    name = item.team;
                }
            }

            return name;
        }
    }
}
