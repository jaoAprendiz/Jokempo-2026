# ✊✋✌️ Jogo Jokempo (Pedra, Papel e Tesoura) em C#

## 💡 Sobre o Projeto
Este projeto é um fork da atividade da disciplina de C# / Desenvolvimento de Software. O objetivo principal foi refatorar e expandir um jogo clássico de Jokempo (Pedra, Papel e Tesoura) executado via console. 

A aplicação foi construída aplicando conceitos fundamentais da Engenharia de Software, incluindo a modularização do código em métodos com responsabilidades únicas, validação robusta de entrada de dados e a utilização de Dicionários (`Dictionary`) para gerenciar múltiplos perfis de jogadores simultaneamente, registrando suas respectivas estatísticas ao longo das partidas. O código final é fruto da mescla das melhores lógicas e interações desenvolvidas pela equipe.

## 🚀 Funcionalidades Adicionadas (Features)
Atendendo aos requisitos da atividade e implementando melhorias de usabilidade, o sistema conta com:

* **Modularização:** Lógica central dividida em métodos específicos (`Apresentacao`, `ObterNomeJogador`, `JogarPartida`, etc.) para facilitar a leitura e manutenção do código.
* **Sistema de Múltiplos Jogadores:** Permite alternar entre diferentes jogadores a qualquer momento.
* **Gravação de Estatísticas:** Acompanhamento em tempo real de vitórias, derrotas e empates de cada jogador.
* **Validação de Dados:** Estruturas de repetição (loops) que protegem o programa contra entradas inválidas (letras onde deveriam ser números) ou nulas.
* **Menu Interativo Pós-Jogo:** Um menu de navegação que permite ao usuário:
  * Jogar novamente
  * Visualizar o placar individual
  * Trocar de jogador
  * Resetar as estatísticas do jogador atual
  * Sair do jogo e visualizar o relatório final da sessão

## 🛠️ Tecnologias e Bibliotecas Utilizadas
* **Linguagem:** C# (.NET)
* **Namespace `System`:** Utilizado para manipulação de entrada e saída no console (`Console.WriteLine`, `Console.ReadLine`), conversões e geração de números aleatórios (`Random`).
* **Namespace `System.Collections.Generic`:** Utilizado para a estrutura de dados `Dictionary<TKey, TValue>`, que foi fundamental para atrelar o nome (string) de cada jogador às suas respectivas estatísticas (tupla de inteiros).

## 👥 Integrantes do Grupo
* João Victor Soave - RM557595
* Maria Alice Freitas Araújo - RM557516
* Ianny Raquel Ferreira de Souza - RM559096

## 💻 Como Executar
1. Clone este repositório em sua máquina local.
2. Abra o projeto em uma IDE compatível com C# (como Visual Studio ou VS Code).
3. Execute o projeto no terminal.
> **Nota:** Recomenda-se o uso do Windows Terminal ou terminais integrados de IDEs modernas para a correta renderização dos emojis no console.
