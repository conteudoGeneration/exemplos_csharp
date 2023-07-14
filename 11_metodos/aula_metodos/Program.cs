using aula_metodos.Calculo;

namespace aula_metodos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float numero1, numero2;

            Console.WriteLine("Digite o primeiro numero: ");
            numero1 = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Digite o segundo numero: ");
            numero2 = Convert.ToSingle(Console.ReadLine());

            // Exibe o Resultado de cada Operação Matemática:
            Console.WriteLine("Soma = " + Calculadora.Somar(numero1, numero2));
            Console.WriteLine("Subtração = " + Calculadora.Subtrair(numero1, numero2));
            Console.WriteLine("Multiplicação = " + Calculadora.Multiplicar(numero1, numero2));
            Console.WriteLine("Divisão = " + Calculadora.Dividir(numero1, numero2));

        }
    }
}