namespace Aula02ContaBancaria
{
    class Program
    {
        public static void Main (string[] args){
            ContaCorrente conta1 = new ContaCorrente("Aline Oliveira");
            conta1.Depositar(6000);
            conta1.Sacar(3000);
            conta1.Extrato();


            Console.WriteLine("---------------");
            ContaPoupanca conta2 = new ContaPoupanca("Aline Oliveira");
            conta2.Depositar(10000);
            conta2.Sacar(3000);
            conta2.Extrato();

            Console.WriteLine("---------------");
            ContaInvestimento conta3 = new ContaInvestimento("Aline Oliveira");
            conta3.Depositar(1000);
            conta3.Sacar(3000);
            conta3.Extrato();


        }
    }
}
