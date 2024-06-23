using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Aula02ContaBancaria
{
    public abstract class ContaBancaria
    {
        public string Nome {get; private set;}
        public double Saldo {get; private set;}
        

        public ContaBancaria (string nome)
        {
            this.Nome = nome;
        }

        public void Depositar (double valor)
        {
            Saldo += valor;
        }
        public void Sacar (double valor)
        {
            if(Saldo > valor)
            {
                Saldo -= valor;
            } 
            else
            {
                Console.WriteLine("Você não possui saldo suficiente para realizar esta operação.");
            }
        }
        
    }
}