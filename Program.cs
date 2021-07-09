using System;

namespace Eje21
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el dia de la semana sin acentos: ");
            string dia = Console.ReadLine().ToLower();
            switch (dia)
            {
                case "lunes":
                case "martes":
                case "miercoles":
                case "jueves":
                case "viernes":
                    Console.WriteLine("Día laboral.");
                    break;
                case "sabado":
                case "domingo":
                    Console.WriteLine("Día no laboral");
                    break;
                default:
                    Console.WriteLine("Día de la semana no existe");
                    break;

            }
        }
    }
}
