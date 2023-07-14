namespace array_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] vetorInteiros = { 3, 2, 1, 6, 5, 10, 7, 4, 9, 8 };

            Console.WriteLine("Elemento na posição 7: " + Array.IndexOf(vetorInteiros, 7));

            Console.WriteLine("Elemento na posição 2: " + Array.IndexOf(vetorInteiros, 2));

        }
    }
}