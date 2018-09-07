using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HelloWorld;

namespace HelloWorldConsole
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(new ReturnObjectClass().ReturnString);
            Console.ReadKey(true);
        }
    }
}
