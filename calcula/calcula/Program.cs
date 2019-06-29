using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calcula
{
    class Program
    {
        static void Main(string[] args)
        {
            Int32 a,i, b;
            i = 1;
            Console.WriteLine("Suma de dos numeros");

            a =Convert.ToInt32 (Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(a +b);
            Console.ReadKey();

            Console.WriteLine("resta de dos numeros");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(a - b);
            Console.ReadKey();
            Console.WriteLine("tabla de multiplicar del numero");
            a = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i < 11;i++ )

                Console.WriteLine(a*i);
            Console.ReadKey();

            Console.WriteLine("multiplicacion de dos numeros");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(a * b);
            Console.ReadKey();

            Console.WriteLine("division   de dos numeros");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(a / b);
            Console.ReadKey();

        }
    }
}
