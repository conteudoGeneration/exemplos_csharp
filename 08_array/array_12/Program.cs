namespace array_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int soma = 0;
            int[] vetorSoma = new int[4]; // Cria um vetor de 4 posições
            int[,] matrizInteiros = new int[5, 4]; // Cria uma Matriz 5x4

            // Insere os dados na matriz
            for (int linha = 0; linha < matrizInteiros.GetLength(0); linha++)
            {
                for (int coluna = 0; coluna < matrizInteiros.GetLength(1); coluna++)
                {

                    Console.WriteLine(
                        $"Digite um valor para a posição [{linha}, {coluna}]: ");
                    matrizInteiros[linha, coluna] = Convert.ToInt32(Console.ReadLine());
                }
            }

            /*Como o Objetivo é somar as Colunas, os índices foram invertidos
              porque o precisamos percorrer coluna a coluna para processarmos 
              a soma, ao invés de percorrermos as linhas.
              Como o número de linhas é diferente do número de colunas, 
              precisamos inverter os índices para evitar o erro no limite do índice.*/
            for (int coluna = 0; coluna < matrizInteiros.GetLength(1); coluna++)
            {
                for (int linha = 0; linha < matrizInteiros.GetLength(0); linha++)
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
            for (int coluna = 0; coluna < vetorSoma.Length; coluna++)
            {
                Console.WriteLine(
                    $"Soma de todos os elementos da coluna ({coluna + 1}) é: {vetorSoma[coluna]}");
            }
        }
    }
}