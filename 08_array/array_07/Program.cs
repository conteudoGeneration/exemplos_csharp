namespace array_07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] grupoA = { "Amanda", "Elen", "Vinicius" };
            string[] grupoB = { "Samantha", "Letícia", "Alan" };

            Console.WriteLine("Os Arrays são iguais? ");

            if (Array.Equals(grupoA, grupoB))
            {
                Console.WriteLine("Sim, são iguais.");
            }
            else
            {
                Console.WriteLine("Não, são diferentes.");
            }
        }
    }
}