namespace linq_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Fontes de dados
            List<int> numeros = new List<int>()
            {
                1,2,3,4,5,6,7,8,9,10
            };

            List<int> numerosDesordenados = new List<int>()
            {
                6,7,8,1,4,5,9,10,2,3
            };

            List<string> estados = new List<string>{
                "São Paulo", "Rio de Janeiro", "Minas Gerais", "Espirito Santo",
                "São Paulo", "Rio de Janeiro", "Minas Gerais", "São Paulo", "Rio de Grande do Sul"
            };

            List<string> estadosSul = new List<string>{
                "Santa Catarina", "Paraná", "Rio de Grande do Sul"
            };

            // Visualizar Dados Originais
            Console.WriteLine("Lista de Números Ordenados: " + string.Join(", ", numeros));

            Console.WriteLine("\nLista de Números Desordenados: " + string.Join(", ", numerosDesordenados));

            Console.WriteLine("\nLista de Estados: " + string.Join(", ", estados));

            // Select Simples
            var numerosAoCubo = numeros.Select(e => Math.Pow(e, 3));

            Console.WriteLine("\nTodos os Números elevados ao cubo: " + string.Join(", ", numerosAoCubo));

            // Select com Where (Filter)
            var numerosPares = from numero in numeros
                where numero%2 == 0
                select numero;

            Console.WriteLine("\nSomente os Números Pares: " + string.Join(", ", numerosPares));

            // Select com Where (Filter) - 2 critérios
            var estadosStartRorS = from estado in estados
                               where estado.StartsWith('R') || 
                                     estado.StartsWith('S')
                               select estado;

            Console.WriteLine("\nEstados que começam com as letras R e S: " + string.Join(", ", estadosStartRorS));

            // Select com Where (Filter) - Simulando Like
            var estadosContemRio = from estado in estados
                                   where estado.Contains("Rio")
                                   select estado.ToUpper();

            Console.WriteLine("\nEstados que contém a palvra Rio: " + string.Join(", ", estadosContemRio));

            // Ordenação
            var crescente = from numero in numerosDesordenados
                            orderby numero ascending
                            select numero;

            Console.WriteLine("\nOrdem Crescente: " + string.Join(", ", crescente));

            var decrescente = from numero in numerosDesordenados
                              orderby numero descending
                              select numero;

            Console.WriteLine("\nOrdem Decrescente: " + string.Join(", ", decrescente));

            // Select Distinct (sem dados repetidos)
            var estadosDistintos = from estado in estados
                                   .Distinct()
                                   orderby estado ascending
                                   select estado;
            
            Console.WriteLine("\nEstados sem repetições: " + string.Join(", ", estadosDistintos));

            // Contar (count)
            var contarEstados = estados.Count;

            Console.WriteLine("\nNúmero de Estados: " + contarEstados);

            var contarEstadosEndO = estados.Count( e => e.EndsWith('o'));

            Console.WriteLine("\nNúmero de Estados que terminam com a letra O: " + contarEstadosEndO);

            // Média
            var avgNumeros = numeros.Average();
            Console.WriteLine("\nMédia dos elementos da Lista Números: " + avgNumeros);

            // Recuperar Elemento
            var primeiroEstadoStartR = estados.First(e => e.StartsWith('R'));
            Console.WriteLine("\nPrimeiro Estado que começa com a letra R: " + primeiroEstadoStartR);

            // União com geração de um Array
            var uniaoEstados = estados.Union(estadosSul).ToArray();

            Console.WriteLine("\nListar dados do Array: \n");

            foreach(var estado in uniaoEstados)
            {
                Console.WriteLine(estado);
            }
        }
    }
}