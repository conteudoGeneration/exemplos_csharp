namespace date_time_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime data1 = new DateTime();
            Console.WriteLine(data1);

            DateTime dataAtual1 = new DateTime();
            dataAtual1 = DateTime.Now;

            DateTime dataAtual2 = new DateTime();
            dataAtual2 = DateTime.Today;

            DateTime dataAtual3 = new DateTime();
            dataAtual3 = DateTime.UtcNow;

            Console.WriteLine(dataAtual1);
            Console.WriteLine(dataAtual2);
            Console.WriteLine(dataAtual3);

            DateTime dataEspecifica = new DateTime(2022, 12, 22, 14, 15, 00);
            Console.WriteLine(dataEspecifica);

            Console.WriteLine(dataEspecifica.Day);
            Console.WriteLine(dataEspecifica.Month);
            Console.WriteLine(dataEspecifica.Year);
            Console.WriteLine(dataEspecifica.Hour);
            Console.WriteLine(dataEspecifica.Minute);
            Console.WriteLine(dataEspecifica.Second);
            Console.WriteLine(dataEspecifica.DayOfWeek);
            Console.WriteLine(dataEspecifica.DayOfYear);

        }
    }
}