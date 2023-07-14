namespace interface_01
{
    public class Program
    {
        static void Main(string[] args)
        {
            Triatleta triatleta = new Triatleta("Kelvyn");

            triatleta.Aquecer();
            triatleta.Nadar();
            triatleta.Pedalar();
            triatleta.Correr();
            triatleta.Cansou();

        }
    }
}