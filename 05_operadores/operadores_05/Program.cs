namespace operadores_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 10;
            int y = 5;
            int z = 20;
            int w = 5;
            bool resposta;

            resposta = x > y;
            Console.WriteLine("O valor de x é maior do que o valor de y? " + resposta);

            resposta = z >= y;
            Console.WriteLine("\nO valor de z é maior ou igual ao valor de y? " + resposta);

            resposta = x < z;
            Console.WriteLine("\nO valor de x é menor do que o valor de z? " + resposta);

            resposta = z <= w;
            Console.WriteLine("\nO valor de z é menor ou igual ao valor de w? " + resposta);

            resposta = x == z;
            Console.WriteLine("\nO valor de x é igual ao valor de z? " + resposta);

            resposta = z != w;
            Console.WriteLine("\nO valor de z é diferente do valor de w? " + resposta);
        }
    }
}