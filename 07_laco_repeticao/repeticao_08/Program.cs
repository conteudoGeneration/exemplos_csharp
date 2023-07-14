using static System.Runtime.InteropServices.JavaScript.JSType;

namespace repeticao_08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double numero1, numero2;
            int operacao;
            char continua = 'S';

            do
            {
                Console.WriteLine("*****************************************************");
                Console.WriteLine("                                                     ");
                Console.WriteLine("             Calculadora                             ");
                Console.WriteLine("                                                     ");
                Console.WriteLine("            1 - Soma                                 ");
                Console.WriteLine("            2 - Subtração                            ");
                Console.WriteLine("            3 - Multiplicação                        ");
                Console.WriteLine("            4 - Divisão                              ");
                Console.WriteLine("                                                     ");
                Console.WriteLine("*****************************************************");

                Console.WriteLine("\nDigite o primeiro número: ");
                numero1 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Digite o segundo número: ");
                numero2 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Digite a operação (1-4): ");
                operacao = Convert.ToInt32(Console.ReadLine());

                switch (operacao)
                {
                    case 1:
                        Console.WriteLine($"{numero1} + {numero2} = {numero1 + numero2}");
                        break;
                    case 2:
                        Console.WriteLine($"{numero1} - {numero2} = {numero1 - numero2}");
                        break;
                    case 3:
                        Console.WriteLine($"{numero1} x {numero2} = {numero1 * numero2}");
                        break;
                    case 4:
                        Console.WriteLine($"{numero1} / {numero2} = {numero1 / numero2}");
                        break;
                    default:
                        Console.WriteLine("Operação Inválida!");
                        break;
                }

                Console.WriteLine("\nDigite S para Continuar OU N para Sair: ");

                continua = char.ToUpper(Console.ReadKey().KeyChar);

            } while (continua == 'S');
        }
    }
}