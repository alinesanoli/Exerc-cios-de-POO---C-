
using System.Collections;

class Program
{
    public static void Main(String[] args)
    {
        double celsius = 0;
        double fahrenheit = 0;

        Console.WriteLine("Conversor de temperatura: Celsius e Fahrenheit");

        Console.WriteLine("1 - Para converter de Celsius para Fahrenheit. \n2 - Para converter de Fahrenheit para Celsius.");
        int opcao = int.Parse(Console.ReadLine());


        switch(opcao)
        {
            case 1:
            Console.WriteLine("Insira a temperatura em Celsius: ");
            celsius = double.Parse(Console.ReadLine());
            fahrenheit = (celsius * 1.8) + 32;
            Console.WriteLine($"A temperatura em Fahrenheit é {fahrenheit}");
            break;

            case 2:
            Console.WriteLine("Insira a temperatura em fahrenheit: ");
            fahrenheit = double.Parse(Console.ReadLine());
            celsius = (fahrenheit - 32) / 1.8;
            Console.WriteLine($"A temperatura em Celsius é {celsius}");
            break;

            default:
            Console.WriteLine("Nenhuma das opções válidas foi inserida");
            break;
        }
    }
}
