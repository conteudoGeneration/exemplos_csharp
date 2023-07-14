namespace operadores_08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 10;
            int y = 5;
            bool proposicao_01;
            bool proposicao_02;
            bool proposicao_03;
            bool proposicao_04;
            bool resposta;

            proposicao_01 = x > y;
            Console.WriteLine("\nA proposicao_01 é: " + proposicao_01);

            proposicao_02 = x < y;
            Console.WriteLine("\nA proposicao_02 é: " + proposicao_02);

            proposicao_03 = x != y;
            Console.WriteLine("\nA proposicao_03 é: " + proposicao_03);

            proposicao_04 = x == y;
            Console.WriteLine("\nA proposicao_04 é: " + proposicao_04);

            Console.WriteLine("\n\nDisjunção\n");

            resposta = proposicao_01 || proposicao_03;
            Console.WriteLine("\nproposicao_01 ou proposicao_03: " + resposta);

            resposta = proposicao_01 || proposicao_02;
            Console.WriteLine("\nproposicao_01 ou proposicao_02: " + resposta);

            resposta = proposicao_03 || proposicao_04;
            Console.WriteLine("\nproposicao_03 ou proposicao_04: " + resposta);

            resposta = proposicao_02 || proposicao_04;
            Console.WriteLine("\nproposicao_02 ou proposicao_04: " + resposta);
        }
    }
}