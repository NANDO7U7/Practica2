using System;

namespace app7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un numero");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese un numero");
            int num2 = int.Parse(Console.ReadLine());
            var multiplicacion = num1 * num2;
            Console.WriteLine("La multiplicacion de los numero es: {0}", multiplicacion);
        }
    }
}
