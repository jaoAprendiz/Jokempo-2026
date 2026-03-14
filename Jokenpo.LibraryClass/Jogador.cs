using System;

namespace Jokenpo.Core
{
    public class Jogador
    {
        public string Nome { get; set; }
        public int Vitorias { get; set; }
        public int Derrotas { get; set; }
        public int Empates { get; set; }

        public Jogador(string nome)
        {
            Nome = nome;
            Vitorias = 0;
            Derrotas = 0;
            Empates = 0;
        }

        public void ResetarEstatisticas()
        {
            Vitorias = 0;
            Derrotas = 0;
            Empates = 0;
        }
    }
}