using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GAZ.CSCource.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string line;
            while ((line = Console.ReadLine()) != null)
            {
                // Format the data
                line = line.Replace(",", " y:");
                line = "x:" + line;
                Console.WriteLine(line);
            }
        }
    }
}
