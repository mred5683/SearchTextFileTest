using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SearchTextFileTest
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<List<string>> groups = new List<List<string>>();
            //List<string> current = null;
            //foreach (var line in File.ReadAllLines("C:\\users\\nash\\desktop\\Student Records.txt"))
            //{
            //    if (line.Contains("66846") && current == null)
            //        current = new List<string>();
            //    else if (line.Contains("66846") && current != null)
            //    {
            //        groups.Add(current);
            //        current = null;
            //    }
            //    if (current != null)
            //        current.Add(line);
            //}
            //Console.WriteLine();
            List<string> found = new List<string>();
            string line;
            using (StreamReader file = new StreamReader("c:\\users\\nash\\desktop\\student records.txt"))
            {
                while ((line = file.ReadLine()) != null)
                {
                    if (line.Contains("66846"))
                    {
                        found.Add(line);
                        Console.WriteLine(line);
                    }
                }
            }
        }
    }
}
