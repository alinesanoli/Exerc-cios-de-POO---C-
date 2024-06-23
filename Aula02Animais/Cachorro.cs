using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AULA03ANIMAIS;

namespace AULA03ANIMAIS
{
    public class Cachorro : Animal
    {
        public string Cor { get; set; }
        public Cachorro (string nome, int idade, string som, string cor) : base(nome, idade, som)
        {
            this.Cor = cor;
        }

        public override void Movimentar()
        {
            Console.WriteLine("O cachorro está correndo");
        }

        public void Latir(){
            Console.WriteLine("Au au au");
        }
    }
}