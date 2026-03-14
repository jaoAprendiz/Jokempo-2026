using System;

namespace Jokenpo.Core
{
    public class JogoJokenpo
    {
        private Random random = new Random();

        public int GerarEscolhaComputador()
        {
            return random.Next(3);
        }

        public string TraduzirEscolha(int escolha)
        {
            string[] opcoes = { "Pedra ✊", "Papel ✋", "Tesoura ✌" };
            return opcoes[escolha];
        }

        public string CalcularResultado(int jogador, int pc)
        {
            if (jogador == pc)
                return "Empate";

            if ((jogador == 0 && pc == 2) ||
                (jogador == 1 && pc == 0) ||
                (jogador == 2 && pc == 1))
                return "Jogador";

            return "Computador";
        }

        public void AtualizarEstatisticas(Jogador jogador, string resultado)
        {
            if (resultado == "Jogador")
                jogador.Vitorias++;

            else if (resultado == "Computador")
                jogador.Derrotas++;

            else
                jogador.Empates++;
        }
    }
}