
namespace Aula02FormasGeometricas
{
    class Program
    {
        public static void Main(String[] args)
        {
            Circulo circulo = new Circulo(5);
            circulo.Area();

            Retangulo retangulo = new Retangulo(8,5);
            retangulo.Area();

            Triangulo triangulo = new Triangulo(9,8);
            triangulo.Area();

        }
    }
}