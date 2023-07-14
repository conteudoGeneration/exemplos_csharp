using System.Runtime.ConstrainedExecution;

namespace exceptions_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int dividendo = 0;
            int divisor = 0;
            bool loop = true;

            do
            {

                try
                {
                    Console.WriteLine("Digite o Dividendo: ");
                    dividendo = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Digite o Divisor: ");
                    divisor = Convert.ToInt32(Console.ReadLine());

                    Dividir(dividendo, divisor);

                    loop = false;

                }
                catch (FormatException e)
                {
                    Console.Error.WriteLine("\nExceção: " + e);
                    Console.WriteLine("\nDigite valores inteiros!");
                }
                catch (DivideByZeroException e)
                {
                    Console.Error.WriteLine("\nExceção: " + e);
                    Console.WriteLine("\nDigite Numeros inteiros positivos!");
                }
                finally
                {
                    Console.WriteLine("\nSempre serei executada!\n");
                }

            } while (loop);
        }

        public static void Dividir(int dividendo, int divisor)
        {
            Console.WriteLine("Divisão = " + (dividendo / divisor));
        }
    }
}