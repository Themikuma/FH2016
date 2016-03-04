using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture1
{
    class Program
    {
        static void Main(string[] args)
        {
            sbyte a = 0;
            for (sbyte i = 0; i < 128; i++)
            {
                System.Threading.Thread.Sleep(60);
                Console.WriteLine(i);
            }
        }
    }
}
