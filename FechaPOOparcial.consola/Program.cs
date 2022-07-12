using System;
using FechaPOOparcial.entidades;

namespace FechaPOOparcial.consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var f1 = new Fecha(22,06,2022);
            var f2 = new Fecha(14, 06, 2022);
            var f3 = new Fecha(22, 06, 2022);
            Console.WriteLine(f1.ToString());
            Console.WriteLine(f1.MostrarConPalabras());
            Console.WriteLine($"La fecha {f1.ToString()} es {f1.Validador()}");
            if (f1 == f2)
            {
                Console.WriteLine($"{f1.ToString()} y {f2.ToString()} Son iguales");
            }else
            {
                Console.WriteLine($"{f1.ToString()} y {f2.ToString()} Son distintos");
            }

            if (f1 == f3)
            {
                Console.WriteLine($"{f1.ToString()} y {f3.ToString()} Son iguales");
            }
            else
            {
                Console.WriteLine($"{f1.ToString()} y {f3.ToString()} Son distintos");
            }
            //fecha no válida
            var f4 = new Fecha(30,02,2022);
            Console.WriteLine($"{f4.ToString()} es {f4.Validador()}");

            //conversión implícita
            Fecha f5 = "24/05/2022";
            Console.WriteLine(f5.MostrarConPalabras());
        }
    }
}
