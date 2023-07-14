namespace operadores_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string texto01 = "Generation";
            string texto02 = "Brasil";
            string texto03 = " ";
            int ano = 2008;

            Console.WriteLine("Concatenar texto01 e texto02: " + texto01 + texto02);
            Console.WriteLine("\nConcatenar texto02 e texto01: " + texto02 + texto01);
            Console.WriteLine("\nConcatenar texto01, texto03 e texto02: " + texto01 + texto03 + texto02);

            Console.WriteLine($"\nO primeiro filme do Homem de Ferro foi lançado em {ano}");
        }
    }
}