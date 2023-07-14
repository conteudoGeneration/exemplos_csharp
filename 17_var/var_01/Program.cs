namespace var_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var v1 = 120.23F;
            var v2 = 150.23M;
            var v3 = 'G';
            var v4 = "Generation";

            // Exibe o tipo das variáveis
            Console.WriteLine("Valor da variável 01 {0}, type {1}", v1, v1.GetType());
            Console.WriteLine("Valor da variável 02 {0}, type {1}", v2, v2.GetType());
            Console.WriteLine("Valor da variável 03 {0}, type {1}", v3, v3.GetType());
            Console.WriteLine("Valor da variável 04 {0}, type {1}", v4, v4.GetType());

        }
    }
}