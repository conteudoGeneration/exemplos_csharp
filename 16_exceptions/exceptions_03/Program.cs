namespace exceptions_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int idade;

            Console.WriteLine("\nDigite uma idade: ");
            idade = Convert.ToInt32(Console.ReadLine());

            ValidarIdade(idade);
        }

        public static void ValidarIdade(int idade)
        {

            if (idade < 18)
                throw new ArithmeticException("A Pessoa não pode dirigir!!");
            else
                Console.WriteLine("A Pessoa pode dirigir!!");

        }
    }
}