namespace condicionais_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcao;
            
            Console.WriteLine("# ## ### #### #########   Menu   ########## #### ### ## #");
            Console.WriteLine("\n--Digite 1 para ver Indicação de um Livro--");
            Console.WriteLine("--Digite 2 para ver ler uma Frase Motivacional--");
            Console.WriteLine("--Digite 3 para receber uma Indicação de música--");
            
            opcao = Convert.ToInt32(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    Console.WriteLine("Livro: O Alquimista");
                    break;
                case 2:
                    Console.WriteLine(
                        "Frase motivacional: Se você cair, levante! Não dá para andar deitado.");
                    break;
                case 3:
                    Console.WriteLine("Música: AURORA - No Cure For Me.");
                    break;
            }
        }
    }
}