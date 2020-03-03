using System;

namespace Aula_4
{
    public abstract class Carro: MeioTransporte
    {
        public string Cor { get; set; }
        public string Chassi { get; set; }
        public object roda { get; set; }
        public object Parabrisa { get; set; }
        public object Chave { get; set; }

        public Carro()
        {

        }

        public void ligar()
        {
        }

        public Carro(object chave)
        {
        }

        public override void Andar()
        {
            this.roda = "andou!";
            base.Ligar();
        }

        



    }
}
