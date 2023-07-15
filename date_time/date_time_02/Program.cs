namespace date_time_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime Data = DateTime.Now;

            Console.WriteLine("(d) Data Abreviada: . . . . . . . . . . {0:d}", Data);
            Console.WriteLine("(D) Data Completa:  . . . . . . . . . . {0:D}", Data);
            Console.WriteLine("(t) Hora Abreviada: . . . . . . . . . . {0:t}", Data);
            Console.WriteLine("(T) Hora Completa:  . . . . . . . . . . {0:T}", Data);
            Console.WriteLine("(f) Data Completa / Hora Abreviada: . . {0:f}", Data);
            Console.WriteLine("(F) Data e Hora Completa: . . . . . . . {0:F}", Data);
        }
    }
}