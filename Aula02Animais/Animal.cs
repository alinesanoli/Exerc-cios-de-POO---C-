using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AULA03ANIMAIS
{
    public abstract class Animal
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string Som { get; set; }

        public Animal (string nome, int idade, string som)
        {
            this.Nome = nome;
            this.Idade = idade;
            this.Som = som;
        }

        public abstract void Movimentar();





    }
}