namespace collections_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Cria a Collection List, do tipo Double, chamada notas e inicializa
            List<double> notas = new List<double>()
            {
                7.0,
                5.0,
                4.0,
                10.0
            };


            /* Mostra na tela todas as notas adicionadas.
               Observe que para exibir as notas utilizamos 
               o Laço foreach */
            Console.WriteLine("\nNotas cadastradas: ");

            foreach (double nota in notas)
            {
                Console.WriteLine(nota);
            }

            /*Adiciona uma nova Nota - duplicada */
            notas.Add(4.0);

            /**
             * Mostra na tela todas as notas, inclusive a 
             * nota duplicada que foi adicionada.
             */
            Console.WriteLine("\nNotas cadastradas: ");

            foreach(double nota in notas)
            {
                Console.WriteLine(nota);
            }

            /*Adiciona uma nova Nota na posição 2 da Lista */
            notas.Insert(2, 9.0);

            /**
             * Mostra na tela todas as notas, inclusive a 
             * nota 9.0 que foi adicionada na posição 2.
             */
            Console.WriteLine("\nNotas cadastradas: ");

            foreach (double nota in notas)
            {
                Console.WriteLine(nota);
            }

            /**
             * Mostra a posição (indice) de uma determinada nota. 
             * Caso existam 2 notas iguais será exibida a posição da primeira nota encontrada.
             */
            Console.WriteLine("\nA posição da nota 5 é: " + notas.IndexOf(5));

            // Mostra se uma determinada nota existe na lista
            Console.WriteLine("\nA nota 5 existe na lista? " + notas.Contains(5));

            // Mostra a nota inserida em uma determinada posição (indice)
            Console.WriteLine("\nNa posição 1 da lista, a nota é: " + notas[1]);

            // Altera a nota 5.0 para 6.0 e mostra que a alteração foi efetuada
            notas[notas.IndexOf(5)] = 6.0;
            Console.WriteLine("\nA nota 5 foi alterada para 6: ");

            foreach (double nota in notas)
            {
                Console.WriteLine(nota);
            }

            /**
             *  Apaga a nota 4.0 e mostra que a exclusão foi efetuada.
             *  Observe que apenas a primeira nota 4.0 foi apagada.
             */
              notas.Remove(4.0);
            Console.WriteLine("\nA nota 4 foi apagada: ");

            foreach (double nota in notas)
            {
                Console.WriteLine(nota);
            }

            // Exibe o tamanho da lista (numero de elementos)
            Console.WriteLine("\nO tamanho da lista é: " + notas.Count);

            // Limpa a lista e mostra que ela está vazia
            notas.Clear();
            Console.WriteLine("\nA lista está vazia: ");

            foreach (double nota in notas)
            {
                Console.WriteLine(nota);
            }

        }
    }
}