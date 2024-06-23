using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.ConstrainedExecution;
using System.Threading.Tasks;

namespace Aula02FormasGeometricas
{
    public class Circulo : FormaGeometrica
    {
        private double Raio;
        public Circulo(double raio)
        {
            this.Raio = raio;
        }
        public override void Area()
        {
            Console.WriteLine($"A área do círculo é {Math.PI * Raio * Raio}");
        }
       
    }
}