namespace array_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] vetor_cachorros = { "Boxer", "Pastor Alemão", "Pinscher", "Husky Siberiano", "Corgi" };

            Console.WriteLine("Itens dentro do vetor: \n");

            for (int indice = 0; indice < vetor_cachorros.Length; indice++)
            {
                Console.WriteLine(vetor_cachorros[indice]);
            }

            Console.WriteLine("\nO tamanho do seu vetor é: " + vetor_cachorros.Length);
        }
    }
}