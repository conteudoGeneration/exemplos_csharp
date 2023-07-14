namespace conversao_tipos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string numeroInteiro = "123";

            string numeroReal = "567,45";

            Console.WriteLine("Soma das Strings: " + numeroInteiro + numeroReal);

            var num1 = Convert.ToInt32(numeroInteiro);
            var num2 = Convert.ToSingle(numeroReal);

            Console.WriteLine("Soma das Strings Convertidas: " + (num1 + num2));

        }
    }
}