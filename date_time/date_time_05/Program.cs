namespace date_time_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTimeOffset dateOffset1, dateOffset2;
                       
            dateOffset1 = DateTimeOffset.Now;
            dateOffset2 = DateTimeOffset.UtcNow;

            Console.WriteLine(dateOffset1);
            Console.WriteLine(dateOffset2);

            Console.WriteLine(dateOffset2.Day);
            Console.WriteLine(dateOffset2.Month);
            Console.WriteLine(dateOffset2.Year);
            Console.WriteLine(dateOffset2.Hour);
            Console.WriteLine(dateOffset2.Minute);
            Console.WriteLine(dateOffset2.Second);
            Console.WriteLine(dateOffset2.DayOfWeek);
            Console.WriteLine(dateOffset2.DayOfYear);
        }
    }
}