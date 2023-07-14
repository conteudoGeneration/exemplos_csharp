namespace condicionais_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float nota1, nota2, media;

            Console.WriteLine("Digite a primeira nota: ");
            nota1 = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Digite a segunda nota: ");
            nota2 = Convert.ToSingle(Console.ReadLine());

            media = (nota1 + nota2) / 2;

            if (media >= 6)
            {
                Console.WriteLine("Parabéns, você foi aprovade!");
            }
            else if (media == 5)
            {
                Console.WriteLine("Alune de exame!");
            }
            else
            {
                Console.WriteLine("Infelizmente você foi reprovade...");
            }
        }
    }
}