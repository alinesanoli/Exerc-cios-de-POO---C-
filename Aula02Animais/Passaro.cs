using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace AULA03ANIMAIS
{
    public class Passaro : Animal
    {
        public int VelocidadeDoVoo { get; private set; }
        public string Especie {get; set;}
        public Passaro (string nome, int idade, string som, int velocidadeDoVoo, string especie) : base (nome, idade, som)
        {
            this.VelocidadeDoVoo = velocidadeDoVoo;
            this.Especie = especie;
        }

        public override void Movimentar()
        {
           Console.WriteLine("O passaro está voando");
        }

        public void VelocidadeDoMovimento(){
            Console.WriteLine($"O passaro da espécie {Especie} voa a uma velocidade de {VelocidadeDoVoo} km/h");
        }

        
    }
}