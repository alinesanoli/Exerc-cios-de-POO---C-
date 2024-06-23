using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula02ContaBancaria
{
    public class ContaPoupanca : ContaBancaria
    {

        public ContaPoupanca (string nome) : base (nome)
        {
        }


        public void Extrato()
        {
            Console.WriteLine($"Olá {Nome}, o saldo atual da sua conta poupança é de {Saldo}");
        }
    }
}
