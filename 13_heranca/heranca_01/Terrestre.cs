using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace heranca_01
{
    public class Terrestre: Transporte
    {
        private int numeroRodas;
        protected float velocidade;

        public Terrestre(int capacidade, int numeroRodas, float velocidade): base(capacidade)
        {
            this.numeroRodas = numeroRodas;
            this.velocidade = velocidade;
        }

        public int GetNumeroRodas()
        {
            return numeroRodas;
        }

        public void SetNumeroRodas(int numeroRodas)
        {
            this.numeroRodas = numeroRodas;
        }

        public float GetVelocidade()
        {
            return velocidade;
        }

        public void SetVelocidade(float velocidade)
        {
            this.velocidade = velocidade;
        }

        public override void Visualizar()
        {

            base.Visualizar();
            Console.WriteLine("Número de rodas: " + this.numeroRodas);
            Console.WriteLine("Velocidade: " + this.velocidade);

        }
    }
}
