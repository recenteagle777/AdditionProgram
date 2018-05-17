using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdditionProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0, y = 0;
            Program n = new Program();
            n.inputMethod(out x, out y);
            Console.WriteLine("Addition of two integers are: {0}", x+y);
            Console.ReadKey();
        }

        public void inputMethod(out int a, out int b)
        {
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            
        }
    }
}
