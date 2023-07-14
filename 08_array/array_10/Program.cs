namespace array_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] matrizInteiros = new int[3, 3];

            for (int linha = 0; linha < 3; linha++)
            {
                for (int coluna = 0; coluna < 3; coluna++)
                {
                    Console.WriteLine(
                        $"Digite um valor para a posição [{linha}, {coluna}]: ");
                    matrizInteiros[linha, coluna] = Convert.ToInt32(Console.ReadLine());
                }
            }

            for (int linha = 0; linha < 3; linha++)
            {
                for (int coluna = 0; coluna < 3; coluna++)
                {
                    Console.WriteLine(
                        $"O valor armazenado na posição [{linha}, {coluna}] é: " +
                        $"{matrizInteiros[linha, coluna]}");
                }
            }
        }
    }
}