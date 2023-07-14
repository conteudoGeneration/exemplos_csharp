namespace repeticao_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string? nome;
            int contador;

            for (contador = 1; contador < 4; contador++)
            {
                Console.WriteLine($"\nDigite o {contador}º nome: ");
                nome = Console.ReadLine();
                Console.WriteLine($"O {contador}º nome digitado foi: {nome}");
            }
        }
    }
}