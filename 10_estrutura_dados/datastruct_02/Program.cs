using System.Linq;

namespace datastruct_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<string> pilha = new Stack<string>();

            pilha.Push("1º - Prato Verde");
            pilha.Push("2º - Prato Azul");
            pilha.Push("3º - Prato Branco");
            pilha.Push("4º - Prato Amarelo");
            pilha.Push("5º - Prato Vermelho");

            Console.WriteLine("\nElementos da Pilha: ");

            foreach (string item in pilha)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\nRetirar elemento: " + pilha.Pop());

            Console.WriteLine("\nElementos da Pilha: ");

            foreach (string item in pilha)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\nRetirar elemento: " + pilha.Pop());

            Console.WriteLine("\nElementos da Pilha: ");

            foreach (string item in pilha)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\nElemento no topo da Pilha: " + pilha.Peek());

            Console.WriteLine("\nAdicionar Elemento: Prato Roxo");
            pilha.Push("Prato Roxo");

            Console.WriteLine("\nElementos da Pilha: ");

            foreach (string item in pilha)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\nTamanho da Pilha: " + pilha.Count);

            Console.WriteLine("\nO Elemento Prato Verde existe na Pilha? " + pilha.Contains("1º - Prato Verde"));

            Console.WriteLine("\nLimpar a Pilha");

            pilha.Clear();

            Console.WriteLine("\nElementos da Pilha: ");

            foreach (string item in pilha)
            {
                Console.WriteLine(item);
            }

        }
    }
}