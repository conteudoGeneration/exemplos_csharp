namespace condicionais_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int idade = 18;
            bool carteiraM = true;

            if (idade >= 18 && carteiraM == true)
            {
                Console.WriteLine("Você pode dirigir.");
            }
        }
    }
}