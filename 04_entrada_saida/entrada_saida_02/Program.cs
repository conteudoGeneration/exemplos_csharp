namespace entrada_saida_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte bit = 127;
            short valor = 254;
            int quantidade = 1000;
            long identificador = 10000L;
            float altura = 25.4F;
            double area = 45.4567D;
            decimal preco = 58.45M;
            char tipo = 'A';
            bool resposta = true;
            string palavra = "Generation";

            Console.WriteLine(bit);
            Console.WriteLine(valor);
            Console.WriteLine(quantidade);
            Console.WriteLine(identificador);
            Console.WriteLine(altura);
            Console.WriteLine(area);
            Console.WriteLine(preco);
            Console.WriteLine(tipo);
            Console.WriteLine(resposta);
            Console.WriteLine(palavra);
        }
    }
}