namespace exceptions_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int idade;
            bool loop = true;

            do
            {

                try
                {

                    Console.WriteLine("\nDigite uma idade: ");
                    idade = Convert.ToInt32(Console.ReadLine());

                    ValidarIdade(idade);

                    loop = false;

                }
                catch (ArithmeticException)
                {
                    Console.WriteLine("\nDigite um número inteiro maior ou igual a 18!");
                }

            } while (loop);
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