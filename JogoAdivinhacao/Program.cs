
class Program 
{
    public static void Main(String[] args)
    {
        Random random = new Random();
        
        Console.WriteLine("Bem-vindas(os) ao jogo da adivinhação. Neste jogo você terá 3 tentativas para adivinhar qual número foi sorteado a partir do intervalo que você inseriu. \nBoa sorte!!");
    
        int numeroMinimo = 0;
        int numeroMaximo = 0;

        Console.Write("Insira o número mínimo: ");
        string? inserirMin = Console.ReadLine();
        if (string.IsNullOrEmpty(inserirMin) || !int.TryParse(inserirMin, out numeroMinimo))
        {
            Console.WriteLine("Entrada inválida para o número mínimo");
            return;
        }

        Console.Write("Insira o número máximo: ");
        string? inserirMax = Console.ReadLine();
        if (string.IsNullOrEmpty(inserirMax) || !int.TryParse(inserirMax, out numeroMaximo))
        {
            Console.WriteLine("Entrada inválida para o número máximo");
        }


        int numeroAleatorio = random.Next(numeroMinimo,numeroMaximo + 1);

        int numeroTestado = 0;
        int numeroVezes = 3;

        while (numeroTestado != numeroAleatorio )
        {
            Console.WriteLine($"Insira um número entre {numeroMinimo} e {numeroMaximo}");
            string? numTestado = Console.ReadLine();
            if(string.IsNullOrEmpty(numTestado) || !int.TryParse(numTestado, out numeroTestado))
            {
                Console.WriteLine("Você inseriu um número inválido");
            }
            
            if(numeroTestado >= numeroMinimo && numeroTestado <= numeroMaximo)
            {
                if(numeroTestado == numeroAleatorio)
                {
                    
                    Console.WriteLine($"Parabéns!! Você acertou! O número é {numeroAleatorio}");
                    break;
                }else
                {
                    --numeroVezes;
                    if(numeroVezes > 0)
                    {
                        
                        Console.WriteLine($"Você errou! Você ainda possui {numeroVezes} tentativas");
                    }
                    else
                    {
                        Console.WriteLine($"Você esgotou todas as suas tentativas");
                        return;
                    }
                
                }
            }else
            {
                Console.WriteLine("O valor que você inseriu está fora do intervalo do sorteio");
            }
                        
        }

    }
}