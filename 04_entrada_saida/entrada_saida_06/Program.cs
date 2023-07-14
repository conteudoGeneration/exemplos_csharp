namespace entrada_saida_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte bit;
            short valor;
            int quantidade;
            long identificador;
            float altura;
            double area;
            decimal preco;
            char? tipo;
            bool resposta;
            string? palavra;

            Console.WriteLine("Digite um valor do tipo Byte: ");
            bit = Convert.ToByte(Console.ReadLine());
            Console.WriteLine("O valor byte digitado foi: " + bit);

            Console.WriteLine("\nDigite um valor do tipo Short: ");
            valor = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("O valor short digitado foi: " + valor);

            Console.WriteLine("\nDigite um valor do tipo Int: ");
            quantidade = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("O valor inteiro digitado foi: " + quantidade);

            Console.WriteLine("\nDigite um valor do tipo Long: ");
            identificador = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("O valor long digitado foi: " + identificador);

            Console.WriteLine("\nDigite um valor do tipo Float: ");
            altura = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("O valor float digitado foi: " + altura);

            Console.WriteLine("\nDigite um valor do tipo Double: ");
            area = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("O valor double digitado foi: " + area);

            Console.WriteLine("\nDigite um valor do tipo Decimal: ");
            preco = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("O valor decimal digitado foi: " + preco);

            Console.WriteLine("\nDigite um valor do tipo Char: ");
            tipo = Console.ReadKey().KeyChar;
            Console.WriteLine("\nO valor char digitado foi: " + tipo);

            Console.WriteLine("\nDigite um valor do tipo Bool: ");
            resposta = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine("O valor boolean digitado foi: " + resposta);

            Console.WriteLine("\nDigite um valor do tipo string: ");
            palavra = Console.ReadLine();
            Console.WriteLine("O valor string digitado foi: " + palavra);

        }
    }
}