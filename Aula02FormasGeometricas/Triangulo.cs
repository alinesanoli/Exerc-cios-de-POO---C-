using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula02FormasGeometricas
{
    public class Triangulo : FormaGeometrica
    {
        private double Largura;
        private double Altura;
        public Triangulo(double largura, double altura)
        {
            this.Altura = altura;
            this.Largura = largura;
        }
        public override void Area()
        {
            Console.WriteLine($"A Área do triângulo é {Largura * Altura / 2}");
        }  
    }
}