using System.Runtime.ConstrainedExecution;

namespace exceptions_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int dividendo = 0;
            int divisor = 0;

            Console.WriteLine("Digite o Dividendo: ");
            dividendo = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o Divisor: ");
            divisor = Convert.ToInt32(Console.ReadLine());

            Dividir(dividendo, divisor);
        }

        public static void Dividir(int dividendo, int divisor)
        {
            Console.WriteLine("Divisão = " + (dividendo / divisor));
        }

    }
}