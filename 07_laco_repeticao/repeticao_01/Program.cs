namespace repeticao_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string? nome1, nome2, nome3;
            
            Console.WriteLine("Digite o 1º nome: ");
            nome1 = Console.ReadLine();
            Console.WriteLine($"O 1º nome digitado foi: {nome1}");

            Console.WriteLine("\nDigite o 2º nome: ");
            nome2 = Console.ReadLine();
            Console.WriteLine($"O 2º nome digitado foi: {nome2}");

            Console.WriteLine("\nDigite o 3º nome: ");
            nome3 = Console.ReadLine();
            Console.WriteLine($"O 3º nome digitado foi: {nome3}");
        }
    }
}