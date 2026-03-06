using System;
using System.Diagnostics;
namespace SleepDown
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("¿En cuanto tiempo quieres que se apague el dispositivo?");
            string entrada = Console.ReadLine();
            while (!int.TryParse(entrada, out int minutos))
            {
                Console.WriteLine("Porfavor introduce un valor numerico");
                entrada = Console.ReadLine();
            }
            ;
            Console.Clear();
            Console.WriteLine("El dispositivo se apagara en " + entrada + " minutos");
            Process.Start("shutdown", "+" + entrada);

            Console.WriteLine("Si quieres cancelar escribe o pega -cancelar- ");
            string cancelar = Console.ReadLine().ToLower();
            while (cancelar != "cancelar")
            {
                Console.Clear();
                Console.WriteLine("Si quieres cancelar escribe o pega -cancelar-");
                cancelar = Console.ReadLine().ToLower();
            }
            ;
            Process.Start("shutdown", "-c");

        }
    }
}
