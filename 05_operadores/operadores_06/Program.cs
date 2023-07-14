namespace operadores_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 10;
            int y = 5;
            bool proposicao_01;
            bool proposicao_02;
            bool resposta;

            proposicao_01 = x > y;
            Console.WriteLine("\nA proposicao_01 é: " + proposicao_01);

            proposicao_02 = x < y;
            Console.WriteLine("\nA proposicao_02 é: " + proposicao_02);

            Console.WriteLine("\n\nNegação\n");

            resposta = !proposicao_01;
            Console.WriteLine("\nA Negação da proposicao_01 é: " + resposta);

            resposta = !proposicao_02;
            Console.WriteLine("\nA Negação da proposicao_02 é: " + resposta);
        }
    }
}