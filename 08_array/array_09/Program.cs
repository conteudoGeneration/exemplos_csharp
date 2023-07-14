namespace array_09
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[,] matrizInteiros = { { 10, 15, 35 }, { 70, 120, 140 }, { 50, 100, 150 } };

            for (int indiceLinha = 0; indiceLinha < 3; indiceLinha++)
            {
                for (int indiceColuna = 0; indiceColuna < 3; indiceColuna++)
                {
                    Console.WriteLine(
                        $"O valor armazenado na posição [{indiceLinha},{indiceColuna}] é: {matrizInteiros[indiceLinha, indiceColuna]}");

                }
            }
        }
    }
}