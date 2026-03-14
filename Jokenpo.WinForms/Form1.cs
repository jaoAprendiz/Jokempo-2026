using System;
using System.Windows.Forms;
using Jokenpo.Core;

namespace Jokenpo.WinForms
{
    public partial class Form1 : Form
    {
        JogoJokenpo jogo = new JogoJokenpo();
        Jogador jogador;

        public Form1()
        {
            InitializeComponent();

            string nome = Microsoft.VisualBasic.Interaction.InputBox(
                "Digite seu nome:", "Jogador");

            if (string.IsNullOrWhiteSpace(nome))
                nome = "Jogador";

            jogador = new Jogador(nome);

            labelJogador.Text = "Jogador: " + jogador.Nome;
        }

        private void Jogar(int escolhaJogador)
        {
            int escolhaPc = jogo.GerarEscolhaComputador();

            string jogadorEscolha = jogo.TraduzirEscolha(escolhaJogador);
            string pcEscolha = jogo.TraduzirEscolha(escolhaPc);

            string resultado = jogo.CalcularResultado(escolhaJogador, escolhaPc);

            jogo.AtualizarEstatisticas(jogador, resultado);

            labelEscolhaJogador.Text = "Você: " + jogadorEscolha;
            labelEscolhaPC.Text = "PC: " + pcEscolha;

            if (resultado == "Empate")
                labelResultado.Text = "Empate! 🤝";

            else if (resultado == "Jogador")
                labelResultado.Text = "Você venceu! 🎉";

            else
                labelResultado.Text = "Computador venceu! 🤖";

            AtualizarPlacar();
        }

        private void AtualizarPlacar()
        {
            labelPlacar.Text =
                $"Vitórias: {jogador.Vitorias}  " +
                $"Derrotas: {jogador.Derrotas}  " +
                $"Empates: {jogador.Empates}";
        }

        private void btnPedra_Click(object sender, EventArgs e)
        {
            Jogar(0);
        }

        private void btnPapel_Click(object sender, EventArgs e)
        {
            Jogar(1);
        }

        private void btnTesoura_Click(object sender, EventArgs e)
        {
            Jogar(2);
        }

        private void btnResetar_Click(object sender, EventArgs e)
        {
            jogador.ResetarEstatisticas();
            AtualizarPlacar();
        }
    }
}