namespace operadores_01
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int x = 4;
            int y = 2;
            int z = 3;
            int w = -5;

            Console.WriteLine("Soma (4+2): " + (x + y));
            Console.WriteLine("\nSoma com numero negativo (4 + (-5)): " + (x + w));
            Console.WriteLine("\nSubtração (4-2): " + (x - y));
            Console.WriteLine("\nMultiplicação (4*2): " + (x * y));
            Console.WriteLine("\nDivisão (4/2): " + (x / y));
            Console.WriteLine("\nMódulo (resto da divisão): " + (x % 2));
            Console.WriteLine("\nMódulo (resto da divisão): " + (z % 2));

            Console.WriteLine("\nResultado da operação x + y * z: " + (x + y * z)); 
            Console.WriteLine("\nResultado da operação (x + y) * z: " + ((x + y) * z));
        }
    }
}

