using System;

namespace Cw2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var parsedDate = DateTime.Parse("2020-03-09");
            var today = DateTime.Today;
            Console.WriteLine(parsedDate);
            Console.WriteLine(today.ToShortDateString());
        }
    }
}
