using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace heranca_01
{
    public class Transporte
    {
        private int capacidade;

        public Transporte(int capacidade)
        {
            this.capacidade = capacidade;
        }

        public Transporte()
        {
        }

        public int GetCapacidade()
        {
            return capacidade;
        }

        public void SetCapacidade(int capacidade)
        {
            this.capacidade = capacidade;
        }

        public virtual void Visualizar()
        {

            Console.WriteLine("\n\n************************************************************");
            Console.WriteLine("Dados do Meio de Transporte:");
            Console.WriteLine("****************************************************************");
            Console.WriteLine("Capacidade (número de passageiros: " + this.capacidade);

        }
    }
}
