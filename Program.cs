using System;
using System.Linq;

namespace LINQ_Examples
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] strArray = new string[] { "one", "two", "three", "four", "five", "six", "seven"};

            var NumberOfElements = strArray.Count();

            Console.WriteLine(NumberOfElements);
        }
    }
}
