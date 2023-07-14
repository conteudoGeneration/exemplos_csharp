namespace repeticao_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero, contador;
            
            Console.WriteLine("Digite a Tabuada que você deseja calcular: ");
            numero = Convert.ToInt32(Console.ReadLine());

            for (contador = 1; contador <= 10; contador++)
            {
                Console.WriteLine($"{numero} x {contador} = {numero * contador}");
            }
        }
    }
}