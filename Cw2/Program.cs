using System;
using System.Collections.Generic;
using System.IO;

namespace Cw2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var csvPath = "data.csv";
            //var csvPath = @"C:\Users\Tuan Viet\Desktop\dane.csv";
            var resultPath = "result.xml";
            var format = "xml";

            var lines = File.ReadLines(csvPath);
            var sw = new StreamWriter("log.txt");
            var hs = new HashSet<Student>();
            
            if (args.Length == 3)
            {
                csvPath = args[0];
                resultPath = args[1];
                format = args[2];
            }


            foreach (string line in lines)
            {
                string[] data = line.Split(",");
                if(data.Length == 9)
                {
                    foreach (string item in data)
                    {
                        if (string.IsNullOrEmpty(item))
                        {
                            sw.WriteLine(line);
                        }
                        else
                        {
                            var student = new Student()
                            {
                                fName = data[0],
                                lName = data[1],
                                studName = data[2],
                                stuMode = data[3],
                                index = data[4],
                                dateBirth = data[5],
                                email = data[6],
                                mom = data[7],
                                dad = data[8]
                            };

                            if (!hs.Contains(student))
                            {
                                hs.Add(student);
                            }
                        }
                    }
                }
                else
                {
                    sw.WriteLine(line);
                }
            }
            sw.Close();

            foreach (var item in hs)
            {
                Console.WriteLine(item);
            }
            //var parsedDate = DateTime.Parse("2020-03-09");
            //var today = DateTime.Today;
            //Console.WriteLine(parsedDate);
            //Console.WriteLine(today.ToShortDateString());

        }

    }
}
