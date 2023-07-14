namespace array_13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int soma = 0;
            int[] vetorSoma = new int[4]; // Cria um vetor de 4 posições
            int[,] matrizInteiros = new int[4, 4]; // Cria uma Matriz 4x4

            // Insere os dados na matriz
            for (int linha = 0; linha < 4; linha++)
            {
                for (int coluna = 0; coluna < 4; coluna++)
                {

                    Console.WriteLine(
                        $"Digite um valor para a posição [{linha}, {coluna}]: ");
                    matrizInteiros[linha, coluna] = Convert.ToInt32(Console.ReadLine());
                }
            }

            for (int coluna = 0; coluna < 4; coluna++)
            {
                for (int linha = 0; linha < 4; linha++)
                {

                    // Armazena a soma dos elementos da coluna na variável 
                    soma += matrizInteiros[linha, coluna];
                }

                // Guarda a soma no vetor auxiliar
                vetorSoma[coluna] = soma;

                // Zera a variável soma, para receber a soma dos elementos da próxima coluna
                soma = 0;
            }

            // Mostra na tela o resultado da soma dos elementos de cada coluna da Matriz
            for (int coluna = 0; coluna < 4; coluna++)
            {
                Console.WriteLine(
                    $"Soma de todos os elementos da coluna ({coluna + 1}) é: {vetorSoma[coluna]}");
            }
        }
    }
}