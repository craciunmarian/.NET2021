using System;

namespace Extension
{
    public static class Extension
    {
        public static string[] SplitWords(this string str)
        {
            return str.Split(new char[] { ' ', '.', ',' }, StringSplitOptions.RemoveEmptyEntries);
        }
    }
}
