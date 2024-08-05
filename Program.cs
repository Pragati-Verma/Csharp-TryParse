using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] values = { "12.3", "45", "ABC", "11", "DEF" };
            // if string, contatenate it to 'message'
            // if numeric, add it to 'total'
            double total = 0;
            string message = "";
            double result = 0;
            foreach(var value in values) 
            {
                if (double.TryParse(value, out result))
                    total += result;
                else
                    message += value;
            }
            //Message: ABCDEF
            // Total: 68.3
            Console.WriteLine($"Message: {message}\nTotal: {total}");
            Console.ReadLine();
        }
    }
}
