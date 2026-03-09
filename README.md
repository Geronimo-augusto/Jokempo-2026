# ✊✋✌️ Jokenpo (Pedra, Papel e Tesoura)

Um jogo clássico de Jokenpo (Pedra, Papel e Tesoura) desenvolvido em **C#** utilizando **Windows Forms**. 

Diferente de um jogo de Jokenpo simples, este projeto conta com um sistema de gerenciamento de sessão, permitindo que você crie múltiplos jogadores e alterne entre eles, mantendo o histórico de vitórias e partidas jogadas de cada um enquanto o aplicativo estiver aberto.

## 🚀 Funcionalidades

* **Sistema de Jogadores:** Crie novos jogadores digitando o nome ou alterne entre jogadores já existentes usando um ID numérico.
* **Estatísticas em Tempo Real:** O jogo rastreia automaticamente o seu desempenho:
  * Total de jogadas feitas pelo jogador atual.
  * Quantidade de vitórias contra o bot.
* **Adversário (Bot):** Um oponente automatizado que faz escolhas aleatórias a cada rodada.
* **Interface Dinâmica:** Transições de tela suaves (usando `Task.Delay`) e uso de emojis visuais (🤛, 🤚, 🤞) para representar as jogadas.

## 🏗️ Estrutura do Projeto

O código está dividido em três partes principais, seguindo princípios básicos de Orientação a Objetos:

* **`Form1.cs` (Interface e Controle):** Coração visual do jogo. Gerencia a visibilidade dos botões, captura as teclas (como o *Enter* nas caixas de texto), controla o fluxo de telas (login -> jogo) e atualiza a interface com as estatísticas.
* **`Jokenpo.cs` (Regras de Negócio):** Classe responsável pela lógica do jogo. Ela gera a jogada aleatória do bot e contém o método `verific()` para julgar quem foi o vencedor da rodada baseada nas regras clássicas.
* **`Player.cs` (Modelo):** Uma classe simples para estruturar os dados do usuário, armazenando seu `Name`, `VitCont` (Vitórias) e `JogadasCont` (Total de partidas).

## 💻 Como executar o projeto

1. Certifique-se de ter o **Visual Studio** instalado com o pacote de desenvolvimento para *Desktop com .NET* (Windows Forms).
2. Clone este repositório para a sua máquina.
3. Dê um duplo clique no arquivo `.sln` para abrir a solução no Visual Studio.
4. Pressione `F5` ou clique no botão **"Iniciar"** (Start) para rodar a aplicação.
5. Siga as instruções na tela para criar seu primeiro jogador ou escolher um existente apertando a tecla `Enter`.

## 🛠️ Tecnologias Utilizadas
* C#
* .NET (Windows Forms)
* Programação Assíncrona básica (`async` / `await Task.Delay`)

## 👷 Integrantes
* Geronimo augusto - rm557170
