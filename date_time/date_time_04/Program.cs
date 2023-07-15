namespace date_time_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime dataAtual = new DateTime();
            dataAtual = DateTime.Now;

            DateTime dataEspecifica = new DateTime(2022, 12, 22, 14, 15, 00);

            Console.WriteLine(dataAtual);
            Console.WriteLine(dataEspecifica);

            Console.WriteLine("Diferença em dias: " + Convert.ToInt32(dataEspecifica.Subtract(dataAtual).TotalDays));
            Console.WriteLine("Diferença em horas: " + Convert.ToInt32(dataEspecifica.Subtract(dataAtual).TotalHours));
            Console.WriteLine("Diferença em minutos: " + Convert.ToInt32(dataEspecifica.Subtract(dataAtual).TotalMinutes));
            Console.WriteLine("Diferença em segundos: " + Convert.ToInt32(dataEspecifica.Subtract(dataAtual).TotalSeconds));
        }
    }
}