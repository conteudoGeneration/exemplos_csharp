namespace operadores_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 4;
            int y = 2;
            int z = 1;

            z = y;
            Console.WriteLine("Atribuição simples (z = y): " + z);

            x += y;
            Console.WriteLine("\nAtribuição com soma (x = x + y): " + x);

            x -= z;
            Console.WriteLine("\nAtribuição com subtração (x = x - z): " + x);

            x *= y;
            Console.WriteLine("\nAtribuição com multiplicação (x = x * y): " + x);

            x /= y;
            Console.WriteLine("\nAtribuição com divisão (x = x / y): " + x);

            x %= y;
            Console.WriteLine("\nAtribuição com o Módulo (x = x % y): " + x);
        }
    }
}