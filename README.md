# ✊✋✌️ Jogo Jokenpo (Pedra, Papel e Tesoura) em C#

## 💡 Sobre o Projeto
Este projeto é um fork de uma atividade da disciplina de C# / Desenvolvimento de Software. Inicialmente, o jogo foi desenvolvido para execução via console, aplicando conceitos fundamentais de programação e engenharia de software.

Posteriormente, o projeto foi evoluído com uma interface gráfica utilizando Windows Forms e com a separação da lógica do jogo em uma Class Library, seguindo boas práticas de arquitetura e organização de código.

O objetivo foi tornar o sistema mais modular, reutilizável e com melhor experiência para o usuário.

--------------------------------------------------

## 🖥️ Versões do Projeto

### 🔹 Versão 1 — Console (Branch Principal)
A primeira versão do jogo foi desenvolvida para execução em console, aplicando conceitos como:

- Modularização do código em métodos específicos
- Estruturas de repetição para validação de entrada
- Utilização de Dictionary para gerenciamento de múltiplos jogadores
- Registro de estatísticas individuais (vitórias, derrotas e empates)

Essa versão permite:

- Jogar partidas contra o computador
- Alternar entre jogadores
- Visualizar estatísticas
- Resetar placar
- Exibir relatório final da sessão

--------------------------------------------------

### 🔹 Versão 2 — Windows Forms (Branch de Interface)

A segunda versão do projeto adiciona uma interface gráfica utilizando Windows Forms.  
Essa implementação está disponível em uma branch separada do repositório.

Nessa versão foram adicionadas melhorias estruturais e visuais ao sistema.

Principais mudanças:

- Interface gráfica construída com Windows Forms
- Separação da lógica do jogo em uma Class Library
- Código mais organizado e reutilizável
- Melhor experiência de interação para o usuário

Funcionalidades da interface:

- Escolha das jogadas através de botões com ícones (Pedra, Papel e Tesoura)
- Exibição da escolha do jogador e do computador
- Exibição do resultado da rodada
- Placar em tempo real com:
  - Vitórias
  - Derrotas
  - Empates
- Botão para resetar estatísticas
- Identificação do jogador pelo nome

--------------------------------------------------

## 🧩 Arquitetura do Projeto

A versão com interface gráfica foi organizada separando a lógica do jogo da interface.

--------------------------------------------------

### 📚 Class Library — Jokenpo.Core

Contém toda a lógica do jogo, permitindo reutilização em outras interfaces (console, web ou mobile).

#### Jogador.cs

Responsável por representar o jogador e armazenar suas estatísticas.

Atributos:

- Nome
- Vitorias
- Derrotas
- Empates

Método:

```ResetarEstatisticas()```

Reinicia todas as estatísticas do jogador.

--------------------------------------------------

#### JogoJokenpo.cs

Classe responsável pela lógica principal do jogo.

Principais métodos:

```GerarEscolhaComputador()```  
Gera uma escolha aleatória entre Pedra, Papel ou Tesoura.

```TraduzirEscolha(int escolha)```  
Converte o valor numérico da jogada para texto.

```CalcularResultado(int jogador, int pc)```  
Determina o vencedor da rodada.

```AtualizarEstatisticas(Jogador jogador, string resultado)```  
Atualiza as estatísticas do jogador após cada partida.

--------------------------------------------------

### 🖼️ Interface Gráfica — Jokenpo.WinForms

A interface gráfica foi desenvolvida utilizando Windows Forms.

Arquivo principal:

```Form1.cs```

Responsável pela interação com o usuário.

Principais funcionalidades:

- Solicitar o nome do jogador ao iniciar o jogo
- Receber a jogada através dos botões
- Exibir as escolhas do jogador e do computador
- Mostrar o resultado da rodada
- Atualizar o placar automaticamente
- Resetar estatísticas através de um botão

Fluxo do jogo:

1. O usuário informa seu nome
2. Escolhe entre Pedra, Papel ou Tesoura
3. O computador gera uma jogada aleatória
4. O sistema calcula o resultado
5. As estatísticas são atualizadas e exibidas

--------------------------------------------------

## 🚀 Funcionalidades do Sistema

✔ Interface gráfica interativa  
✔ Separação entre lógica e interface  
✔ Sistema de jogador com estatísticas  
✔ Escolha aleatória do computador  
✔ Cálculo automático de resultado  
✔ Atualização dinâmica do placar  
✔ Reset de estatísticas  
✔ Código modular e reutilizável  

--------------------------------------------------

## 🛠️ Tecnologias Utilizadas

- Linguagem: C# (.NET)
- Windows Forms — Interface gráfica
- Class Library (.NET) — Lógica do jogo
- Namespace System
- Namespace System.Windows.Forms
- Namespace System.Collections.Generic

--------------------------------------------------

## 👥 Integrantes do Grupo

João Victor Soave — RM557595  
Maria Alice Freitas Araújo — RM557516  
Ianny Raquel Ferreira de Souza — RM559096  

--------------------------------------------------

## 💻 Como Executar o Projeto

1. Clone o repositório:

- ```git clone <url-do-repositorio>```

2. Abra a solução no Visual Studio.

3. Caso queira testar a versão com interface gráfica, mude para a branch correspondente.

4. Execute o projeto pressionando:

- ```F5 ou Ctrl + F5```

--------------------------------------------------

Observação:

A separação da lógica em uma Class Library (Jokenpo.Core) permite que o jogo seja reutilizado futuramente em outras interfaces, como Web, API ou Mobile, sem necessidade de reescrever a lógica principal.
