using static System.Runtime.InteropServices.JavaScript.JSType;

namespace repeticao_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char continua = 'S';
            int numero1, numero2, resultado;

            while (continua != 'N')
            {
                Console.WriteLine("Digite o primeiro valor: ");
                numero1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Digite o segundo valor: ");
                numero2 = Convert.ToInt32(Console.ReadLine());

                resultado = numero1 + numero2;

                Console.WriteLine("O resultado da soma é: " + resultado);

                Console.WriteLine("\n++++++++++++++++MENU++++++++++++++++++");
                Console.WriteLine("\nDeseja somar dois valores?");
                Console.WriteLine("\nDigite S para Continuar OU N para Sair: ");

                continua = char.ToUpper(Console.ReadKey().KeyChar);
                
                Console.WriteLine("++++++++++++++++++++++++++++++++++");
            }
        }
    }
}