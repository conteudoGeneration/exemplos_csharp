namespace entrada_saida_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("(C) Valor Monetário: . . . . . . . . . {0:C}", 123.45);
            Console.WriteLine("(F) Valor Float ou Double: . . . . . . {0:F}", 123.45);
            Console.WriteLine("(E) Valor Científico:  . . . . . . . . {0:E}", 123.45);
            Console.WriteLine("(P) Valor Porcentagem: . . . . . . . . {0:P}", 123.45);
            Console.WriteLine("(X) Valor Hexadecimal: . . . . . . . . {0:X}", 123);

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
