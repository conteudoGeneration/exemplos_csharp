namespace array_16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[,] alunes = { { "Felipe", "Jonas", "Julia" }, { "Mariana", "Carlos", "Juliana" }, { "Augusto", "Sabrina", "Julius" } };

            foreach (string alune in alunes)
            {

                Console.WriteLine(alune);

            }
        }
    }
}