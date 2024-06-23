using System;
using System.Collections.Generic;
using System.Dynamic;
using System.IO.Pipes;
using System.Linq;
using System.Threading.Tasks;

namespace curso_ATOS_CSharp
{
    public abstract class Anime
    {
        public string Nome {get; set;}
        public int AnoCriacao {get; set;}
        public int Episodios {get; set;}
        public string Status {get; set;}

        public Anime (string nome, int anoCriacao, int episodios, string status){
            this.Nome = nome;
            this.AnoCriacao = anoCriacao;
            this.Episodios = episodios;
            this.Status = status;
        }

        public abstract void AssistirEpisodio();

        public abstract void AvaliacaoAnime(double avalicao);

    
    }
}