using System.Diagnostics;

namespace SleepDown
{
    class Program
    {
        static void Main()
        {
            string? entrada;
            int minutos;
            Console.WriteLine("¿En cuanto tiempo quieres que se apague el dispositivo?");
            do
            {
                entrada = Console.ReadLine();
                if (!int.TryParse(entrada, out minutos))
                {
                    Console.WriteLine("Profavor introdusca un valor numerico");
                }
            } while (minutos <= 0);

            Console.Clear();
            Console.WriteLine($"El dispositivo se apagara en {minutos} minutos");
            Process.Start("sudo", $"shutdown -h +{minutos}");

            string? cancelar;
            do
            {
                Console.WriteLine("Si quieres cancelar escribe o pega -cancelar-");
                cancelar = Console.ReadLine()?.ToLower();
            } while (cancelar != "cancelar");
            Process.Start("sudo", "killall shutdown");
        }
    }
}
