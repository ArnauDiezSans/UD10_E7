using System;

namespace UD10_E7
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Inserta el valor a:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Inserta el valor b:");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Inserta el valor c:");
            int c = Convert.ToInt32(Console.ReadLine());
            Raiz abc = new Raiz(a, b, c);
            abc.ToString();
            Console.WriteLine(abc.Tiene1raiz());
            Console.WriteLine(abc.Tiene2raices());
            abc.ObtenerResultados();
        }
    }
}
