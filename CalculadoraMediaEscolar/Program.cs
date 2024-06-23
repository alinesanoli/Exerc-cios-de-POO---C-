
class Program 
{
    public static void Main(String[] args)
    {
        
        double[] notas = new double[4];
        double media = 0;
        double soma = 0;

        Console.WriteLine("Cálculo da média escolar");

        Console.Write("Insira o nome do aluno: ");
        string nome = Console.ReadLine();



        for(int i = 0; i < 4; i++){
            while(true)
           {
                Console.WriteLine($"Insira a nota {i+1} da(o) aluna(o) {nome}: ");
                double nota = double.Parse(Console.ReadLine());


                if(nota > 0.0 && nota <= 10.0)
                {
                    notas[i] = nota;
                    break;
                   
                }
                else
                {
                    Console.WriteLine("A nota deve estar entre 0 e 10. Por favor, insira a nota novamente: ");
                }
           }
      

        }
         
        foreach(double nota in notas)
        {
            soma = soma + nota;
        }

        media = soma / 4;
        //Console.WriteLine(soma);
        if(media >= 7)
        {
            Console.WriteLine($"A(o) aluna(o) {nome} foi aprovada(o) com a média {media}.");
        }
        else if (media < 7 || media > 5)
        {
            Console.WriteLine($"A(o) aluna(o) {nome} está de recuperação com a média {media}.");
        }
        else
        {
            Console.WriteLine($"A(o) aluna(o) {nome} está de reprovada(o) com a média {media}.");
        }

        
        
    }
}
