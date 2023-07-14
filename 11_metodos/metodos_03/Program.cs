namespace metodos_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float numero1 = 0, numero2 = 0;

            Console.WriteLine("Digite o primeiro numero: ");
            numero1 = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Digite o segundo numero: ");
            numero2 = Convert.ToSingle(Console.ReadLine());

            // Exibe o Resultado de cada Operação Matemática:
            Console.WriteLine("Soma = " + Somar(numero1, numero2));
            Console.WriteLine("Subtração = " + Subtrair(numero1, numero2));
            Console.WriteLine("Multiplicação = " + Multiplicar(numero1, numero2));
            Console.WriteLine("Divisão = " + Dividir(numero1, numero2));

            // Executa o Método void turma()
            Turma();

            // Executa o Método float soma() com valores inseridos de forma direta
            Console.WriteLine("\nSoma de valores inseridos de forma direta = " + Somar(10.0F, 5.0F));

        }

        // Método soma com 2 parâmetros float
        static float Somar(float numero1, float numero2)
        {
            return numero1 + numero2;
        }

        // Método subtracao com 2 parâmetros float
        static float Subtrair(float numero1, float numero2)
        {
            return numero1 - numero2;
        }

        // Método multiplicacao com 2 parâmetros float
        static float Multiplicar(float numero1, float numero2)
        {
            return numero1 * numero2;
        }

        // Método divisao com 2 parâmetros float
        static float Dividir(float numero1, float numero2)
        {
            return numero1 / numero2;
        }

        // Método turma() do tipo void
        static void Turma()
        {
            Console.WriteLine("\nCalculadora da Turma!!!!");
        }
    }
}