namespace array_08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] vetorInteiros = { 1, 2, 3, 4, 5, 10, 7, 6, 9, 8 };

            //Ordena o Vetor 
            Array.Sort(vetorInteiros);

            Console.WriteLine("\nVetor Ordenado");

            for (int indice = 0; indice < vetorInteiros.Length; indice++)
            {
                Console.WriteLine(vetorInteiros[indice]);
            }

            Console.WriteLine("\nO elemento 10 Existe? Qual é a posição?");

            int posicao = Array.BinarySearch(vetorInteiros, 10);

            // Se a posição for positiva = Encontrou
            if (posicao >= 0)
                Console.WriteLine("\nO elemento foi Encontrado e está na Posição: " + posicao);

        else
                Console.WriteLine("\nElemento não encontrado!");

        }
    }
}