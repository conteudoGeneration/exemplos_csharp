namespace condicionais_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1 = 4, n2 = 3, n3 = 4;

            if (n1 < 5)
            {
                Console.WriteLine("O número 1 é menor do que 5.");
            }

            if (n1 < n2)
            {
                Console.WriteLine("O número 1 é menor do que o número 2.");
            }

            if (n1 == n3)
                Console.WriteLine("O número 1 e o número 3 são iguais.");
        }
    }
}