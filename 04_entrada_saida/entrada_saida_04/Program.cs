namespace entrada_saida_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte bit = 127;
            short valor = 254;
            int quantidade = 1000;
            long identificador = 10000L;
            float altura = 25.40F;
            double area = 45.4567D;
            decimal preco = 58.45M;
            char tipo = 'A';
            bool resposta = true;
            string palavra = "Generation";

            Console.WriteLine("Variável do tipo Bit:\t\t{0:G}", bit);
            Console.WriteLine("Variável do tipo Short:\t\t{0:G}", valor);
            Console.WriteLine("Variável do tipo Int:\t\t{0:G}", quantidade);
            Console.WriteLine("Variável do tipo Long:\t\t{0:G}", identificador);
            Console.WriteLine("Variável do tipo Float:\t\t{0:F1}", altura);
            Console.WriteLine("Variável do tipo Double:\t{0:E}", area);
            Console.WriteLine("Variável do tipo Decimal:\t{0:C}", preco);
            Console.WriteLine("Variável do tipo Char:\t\t{0:G}", tipo);
            Console.WriteLine("Variável do tipo Bool:\t\t{0:G}", resposta);
            Console.WriteLine("Variável do tipo String:\t{0:G}", palavra);
        }
    }
}