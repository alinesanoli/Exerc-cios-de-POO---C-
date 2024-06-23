using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace curso_ATOS_CSharp
{
    public class Shounen : Anime
    {   
        public int ClassificaoIdade {get; set;}
        public double Avaliacao {get; private set;}
        public Shounen(string nome, int anoCriacao, int episodios, string status, int classificaoIdade) : base(nome, anoCriacao, episodios, status)
        {
            this.ClassificaoIdade = classificaoIdade;

        }

        public override void AssistirEpisodio(){
            Console.WriteLine("Assistindo episodio x...");
        }
        public override void AvaliacaoAnime(double avaliacao){
            this.Avaliacao = avaliacao;
            Console.WriteLine($"A nota do anime {this.Nome} é: {Avaliacao}");
        }

        
    }
}