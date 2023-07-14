using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace excecao_simples
{
    public class ExcecaoSimples : Exception
    {
        public ExcecaoSimples(string message) : base(message)
        {
            Console.WriteLine("Exceção definida pelo Usuário!");
        }
    }
}
