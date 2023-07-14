namespace datastruct_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<int> fila = new Queue<int>();

            for (int i = 1; i <= 10; i++)
                fila.Enqueue(i);

            Console.WriteLine("\nExibir todos os Elementos da fila: ");

            foreach (int item in fila)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\nRemover Elemento: " + fila.Dequeue());

            Console.WriteLine("\nExibir todos os Elementos da fila: ");

            foreach (int item in fila)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\nAdicionar Elemento 11: ");
            
            fila.Enqueue(11);

            Console.WriteLine("\nExibir todos os Elementos da fila: ");

            foreach (int item in fila)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\nExibir o Primeiro Elemento da fila: " + fila.Peek());

            Console.WriteLine("\nExibir o Tamanho da fila: " + fila.Count);

            Console.WriteLine("\nChecar se o Elemento 4 existe na fila? " + fila.Contains(4));

            Console.WriteLine("\nExibir todos os Elementos da fila:");

            foreach (int item in fila)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\nLimpar a fila");
            fila.Clear();

            Console.WriteLine("\nExibir todos os Elementos da fila:");

            foreach (int item in fila)
            {
                Console.WriteLine(item);
            }

        }
    }
}