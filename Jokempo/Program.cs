using System;
using System.Collections.Generic;

class Program
{
    // Dicionário para guardar as estatísticas de vários jogadores
    static Dictionary<string, (int vitorias, int derrotas, int empates)> jogadores = new();
    static string jogadorAtual = "";

    static void Main()
    {
        // Permite a exibição correta dos emojis no console
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        if (!Apresentacao())
        {
            Console.WriteLine("\n👋 Tudo bem! Até a próxima.");
            return;
        }

        jogadorAtual = ObterNomeJogador();
        bool executando = true;

        // Loop principal do jogo
        while (executando)
        {
            JogarPartida();
            executando = MenuPosJogo();
        }

        ImprimirRelatorioFinal();
    }

    /* ========================== MÉTODOS ========================== */

    static bool Apresentacao()
    {
        Console.WriteLine("😀 Olá! Bem-vindo ao jogo de Jokempo!");
        Console.WriteLine("Aqui, você pode desafiar a mim, o computador, para uma partida emocionante de Pedra, Papel e Tesoura.");
        Console.WriteLine("Vamos ver quem tem mais sorte e habilidade! Preparado para jogar?");
        Console.WriteLine("1 - Sim");
        Console.WriteLine("0 - Não");

        char resposta = Console.ReadKey(true).KeyChar;

        while (resposta != '1' && resposta != '0')
        {
            Console.WriteLine("\nOpção inválida. Digite 1 ou 0:");
            resposta = Console.ReadKey(true).KeyChar;
        }

        return resposta == '1';
    }

    static string ObterNomeJogador()
    {
        Console.WriteLine("\nDigite o seu nome: ");
        string nome = Console.ReadLine()?.Trim();

        if (jogadores.ContainsKey(nome))
        {
            Console.WriteLine($"⚠️ O jogador '{nome}' já existe. Deseja usar este perfil? (S/N)");
            char resp = Console.ReadKey(true).KeyChar;

            if (char.ToUpper(resp) != 'S')
            {
                return ObterNomeJogador();
            }
            Console.WriteLine($"\nLogado como: {nome}");
        }
        else
        {
            jogadores[nome] = (0, 0, 0);
            Console.WriteLine($"\nNovo perfil criado: {nome}");
        }

        return nome;
    }

    static void JogarPartida()
    {
        Console.WriteLine($"\n---- Turno de {jogadorAtual} ----");
        Console.WriteLine("Escolha uma opção: \n0 - Pedra ✊ \n1 - Papel ✋ \n2 - Tesoura ✌: ");

        char escolha;
        do
        {
            escolha = Console.ReadKey(true).KeyChar;
            if (escolha != '0' && escolha != '1' && escolha != '2')
            {
                Console.WriteLine("\nOpção inválida. Tente novamente (0, 1 ou 2): ");
            }
        } while (escolha != '0' && escolha != '1' && escolha != '2');

        int escolhaJogador = int.Parse(escolha.ToString());
        int escolhaPc = new Random().Next(3);

        MostrarEscolhas(escolhaJogador, escolhaPc);
        CalcularResultado(escolhaJogador, escolhaPc);
    }

    static void MostrarEscolhas(int jogador, int pc)
    {
        // Usando um array simples para traduzir o número para a string com emoji
        string[] opcoes = { "Pedra ✊", "Papel ✋", "Tesoura ✌" };
        Console.WriteLine($"\nVocê escolheu {opcoes[jogador]}!");
        Console.WriteLine($"Eu escolhi {opcoes[pc]}!");
    }

    static void CalcularResultado(int jogador, int pc)
    {
        var status = jogadores[jogadorAtual];

        if (jogador == pc)
        {
            Console.WriteLine("\n😀 Legal! Nós empatamos!");
            jogadores[jogadorAtual] = (status.vitorias, status.derrotas, status.empates + 1);
        }
        else if ((jogador == 0 && pc == 2) || (jogador == 1 && pc == 0) || (jogador == 2 && pc == 1))
        {
            Console.WriteLine("\n😀 Parabéns! Você venceu.");
            jogadores[jogadorAtual] = (status.vitorias + 1, status.derrotas, status.empates);
        }
        else
        {
            Console.WriteLine("\n😀 Haha, eu venci! Não foi dessa vez.");
            jogadores[jogadorAtual] = (status.vitorias, status.derrotas + 1, status.empates);
        }
    }

    static bool MenuPosJogo()
    {
        while (true)
        {
            Console.WriteLine("\nO que você deseja fazer agora?");
            Console.WriteLine("1 - Jogar Novamente");
            Console.WriteLine("2 - Ver Estatísticas do Jogador Atual");
            Console.WriteLine("3 - Trocar Jogador");
            Console.WriteLine("4 - Resetar Estatísticas do Jogador Atual");
            Console.WriteLine("0 - Sair");

            char opcao = Console.ReadKey(true).KeyChar;

            switch (opcao)
            {
                case '1':
                    return true; // Mantém o loop principal rodando
                case '2':
                    ImprimirEstatisticas(jogadorAtual);
                    break; // Exibe e volta para este mesmo menu
                case '3':
                    jogadorAtual = ObterNomeJogador();
                    return true; // Volta pro jogo com nome novo
                case '4':
                    jogadores[jogadorAtual] = (0, 0, 0);
                    Console.WriteLine($"\nEstatísticas de {jogadorAtual} resetadas com sucesso!");
                    break;
                case '0':
                    return false; // Quebra o loop principal e encerra
                default:
                    Console.WriteLine("\nOpção inválida. Tente novamente.");
                    break;
            }
        }
    }

    static void ImprimirEstatisticas(string nome)
    {
        var s = jogadores[nome];
        Console.WriteLine($"\n📊 Estatísticas de {nome}:");
        Console.WriteLine($"Vitórias: {s.vitorias} | Derrotas: {s.derrotas} | Empates: {s.empates}");
    }

    static void ImprimirRelatorioFinal()
    {
        Console.WriteLine("\n=========================================");
        Console.WriteLine("--- Relatório Final dos Jogadores ---");
        foreach (var jogador in jogadores)
        {
            Console.WriteLine($"Jogador: {jogador.Key} | {jogador.Value.vitorias} Vitórias - {jogador.Value.derrotas} Derrotas - {jogador.Value.empates} Empates");
        }
        Console.WriteLine("=========================================");
        Console.WriteLine("\n👋 Tchau! Até a próxima!");
    }
}