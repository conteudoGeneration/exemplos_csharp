namespace repeticao_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int resultado, numero, contador = 1;

            while (contador < 4)
            {
                Console.WriteLine($"Digite o {contador}º número:");
                numero = Convert.ToInt32(Console.ReadLine());

                resultado = numero * 3;

                Console.WriteLine($"{numero} x 3 = {resultado}");

                Console.WriteLine("\n++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++\n");

                contador++;
            }

            Console.WriteLine("\t\t_________Fim do programa_________");
        }
    }
}