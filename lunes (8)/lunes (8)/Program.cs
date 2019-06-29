using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lunes__8_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese altira");
            Int32 A = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese la base ");
            Int32 b = Convert.ToInt32(Console.ReadLine());
            Areas area = new Areas(b, A);
            Console.WriteLine(String.Format("La altura es (0) y la base {1}", area, Altura));
            Console.ReadLine();
            Console.WriteLine("El area del rectangulo"+ area.Rectangulo());
            Console.WriteLine("El area del triangulo"+ area.Triangulo());
             Console.ReadLine();
           // Areas a = new Areas();
           // Console.ReadLine();
        }
    }
}
