namespace date_time_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime dataEspecifica = new DateTime(2022, 12, 22, 14, 15, 00);
            Console.WriteLine("Data e Hora: " + dataEspecifica);

            Console.WriteLine("Adicionar 2 anos: " + dataEspecifica.AddYears(2));
            Console.WriteLine("Adicionar 2 meses: " + dataEspecifica.AddMonths(2));
            Console.WriteLine("Adicionar 2 dias: " + dataEspecifica.AddDays(2));
            Console.WriteLine("Adicionar 2 horas: " + dataEspecifica.AddHours(2));
            Console.WriteLine("Adicionar 2 minutos: " + dataEspecifica.AddMinutes(2));
            Console.WriteLine("Adicionar 2 segundos: " + dataEspecifica.AddSeconds(2));

        }
    }
}