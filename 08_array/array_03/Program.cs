namespace array_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] vetorInteiros = new int[5];
  
            for (int indice = 0; indice < 5; indice++)
            {
                Console.WriteLine("Digite o " + (indice + 1) + "º Número: ");
                vetorInteiros[indice] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("\nOs números digitados foram: \n");

            for (int indice = 0; indice < 5; indice++)
            {
                Console.WriteLine($"{indice + 1}º número: {vetorInteiros[indice]}");
            }
        }
    }
}