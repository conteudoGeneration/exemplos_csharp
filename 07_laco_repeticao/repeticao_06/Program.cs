namespace repeticao_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero, resultado, contador = 3;

            while (contador <= 2)
            {
                Console.WriteLine("\nDigite um número inteiro: ");
                numero = Convert.ToInt32(Console.ReadLine());

                resultado = numero * 5;

                Console.WriteLine("\nO resultado da multiplicação é: " + resultado);
            }
        }
    }
}