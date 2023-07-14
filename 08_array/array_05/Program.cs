namespace array_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] array_nomes = { "Samantha", "Amanda", "Vinicius", "Cauê", "Leonardo" };

            Array.Sort(array_nomes);

            Console.WriteLine("Array em Ordem Crescente \n");
            for (int indice = 0; indice < array_nomes.Length; indice++)
            {
                Console.WriteLine(array_nomes[indice]);
            }

           Array.Reverse(array_nomes);

            Console.WriteLine("\nArray em Ordem Decrescente \n");
            for (int indice = 0; indice < array_nomes.Length; indice++)
            {
                Console.WriteLine(array_nomes[indice]);
            }

        }
    }
}