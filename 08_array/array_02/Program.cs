namespace array_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] vetorstring = { "Boxer", "Pastor Alemão", "Pinscher", "Husky Siberiano", "Corgi" };

            for (int indice = 0; indice < 5; indice++)
            {
                Console.WriteLine($"{indice + 1}º elemento: {vetorstring[indice]}");
            }
        }
    }
}