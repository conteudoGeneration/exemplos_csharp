namespace metodos_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int resultado;

            resultado = Somar(2, 2);

            Console.WriteLine("O Resultado da soma é: " + resultado);
        }

        static int Somar(int numero1, int numero2)
        {
            return numero1 + numero2;
        }

    }
}