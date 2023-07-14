using System.Collections.Generic;

namespace collections_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Cria a Collection Hashset, do tipo string, chamada frutas e inicializa
            HashSet<string> setFrutas = new HashSet<string>()
            {
                "Abacate",
                "Banana",
                "Jaboticaba",
                "Kiwi",
                "Maçã",
                "Morango",
                "Pêra",
                "Jaboticaba"
            };

            /* Mostra na tela todas as frutas adicionadas.
               Observe que para exibir as frutas utilizamos 
               o Laço foreach */

            Console.WriteLine("\nFrutas cadastradas: ");

            foreach (string fruta in setFrutas)
            {
                Console.WriteLine(fruta);
            }

            /*Adiciona novas Frutas*/
            setFrutas.Add("Kiwi");
            setFrutas.Add("Pitaya");
            setFrutas.Add("Amora");
            setFrutas.Add(null);
            setFrutas.Add("Caju");

            /**
             * Mostra os dados armazenados na Collection HashSet Observe 
             * que a fruta repetida não foi inserida novamente
             */
            Console.WriteLine("\nFrutas cadastradas: ");

            foreach (string fruta in setFrutas)
            {
                Console.WriteLine(fruta);
            }

            // Verifica se um elemento está armazenado na Collection HashSet
            Console.WriteLine("\nExiste a fruta Kiwi? " + setFrutas.Contains("Kiwi"));

            // Remove um elemento da Collection
            setFrutas.Remove("Kiwi");
            
            Console.WriteLine("\nKiwi foi removida!");

            foreach (string fruta in setFrutas)
            {
                Console.WriteLine(fruta);
            }

            // Verifica após a remoção se o elemento ainda existe na Collection HashSet
            Console.WriteLine("\nExiste a fruta Kiwi na Collection? " + setFrutas.Contains("Kiwi"));

            // Limpa a Collection HashSet
            setFrutas.Clear();
            Console.WriteLine("\nTodos os itens foram removidos da Collection HashSet!");

        }
    }
}