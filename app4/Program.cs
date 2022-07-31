using System;

namespace app4
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Ingrese su nombre");
            int name = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese su edad");
            int edad = int.Parse(Console.ReadLine());
         
            Console.WriteLine("Su Nombre es: {1} t tiene {0} años de edad",edad,name);

        }
    }
}
