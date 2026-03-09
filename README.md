✊✋✌️ Jokenpo (Pedra, Papel e Tesoura)

Um jogo clássico de Jokenpo (Pedra, Papel e Tesoura) desenvolvido em C# utilizando Windows Forms.

Diferente de uma implementação simples do jogo, este projeto possui um sistema de gerenciamento de sessão de jogadores, permitindo criar múltiplos usuários e alternar entre eles durante a execução do programa. Cada jogador possui seu próprio histórico de partidas e vitórias enquanto o aplicativo estiver aberto.

🚀 Funcionalidades
👤 Sistema de Jogadores

Criação de novos jogadores digitando o nome.

Possibilidade de alternar entre jogadores existentes utilizando um ID numérico.

Cada jogador possui suas próprias estatísticas dentro da sessão do jogo.

📊 Estatísticas em Tempo Real

O jogo acompanha automaticamente o desempenho do jogador atual:

Total de jogadas realizadas

Quantidade de vitórias contra o bot

🤖 Adversário (Bot)

O jogador enfrenta um oponente automatizado que faz escolhas aleatórias a cada rodada.

🎮 Interface Dinâmica

Interface construída com Windows Forms.

Uso de emojis visuais para representar as jogadas:

🤛 Pedra
🤚 Papel
🤞 Tesoura

Pequenas transições de interface utilizando Task.Delay para tornar a experiência mais fluida.

🏗️ Estrutura do Projeto

O projeto está dividido em partes principais seguindo conceitos básicos de Programação Orientada a Objetos, separando interface, lógica e modelo de dados.

Form1.cs — Interface e Controle

Responsável pela interface gráfica e controle do fluxo do jogo:

Gerenciamento das telas (login → jogo)

Controle da visibilidade dos botões

Captura de eventos do teclado (ex: tecla Enter)

Atualização das estatísticas exibidas ao jogador

Jokenpo.cs — Regras do Jogo

Classe responsável pela lógica principal do jogo:

Geração da jogada aleatória do bot

Método verific() responsável por determinar o vencedor da rodada

Player.cs — Modelo

Classe utilizada para estruturar os dados dos jogadores:

Name → Nome do jogador

VitCont → Contador de vitórias

JogadasCont → Total de partidas jogadas

📂 Estrutura de Pastas
Jokenpo/
│
├── .gitignore
├── Jokenpo.slnx
├── README.md
│
└── Jokenpo/
    ├── Form1.Designer.cs
    ├── Form1.cs
    ├── Form1.resx
    ├── Jokenpo.cs
    ├── Jokenpo.csproj
    ├── Player.cs
    └── Program.cs
Descrição dos arquivos

Arquivos principais

Program.cs
Ponto de entrada da aplicação. Responsável por iniciar o Windows Forms.

Form1.cs
Contém a lógica da interface e as interações com o jogador.

Form1.Designer.cs
Arquivo gerado automaticamente que define os componentes visuais do formulário.

Form1.resx
Arquivo de recursos utilizado pelo Windows Forms para armazenar propriedades da interface.

Lógica do jogo

Jokenpo.cs
Implementa as regras do jogo e a lógica para determinar o vencedor.

Player.cs
Classe que representa um jogador e armazena suas estatísticas.

Configuração

Jokenpo.csproj
Arquivo de configuração do projeto .NET.

Jokenpo.slnx
Arquivo de solução utilizado pelo Visual Studio para abrir o projeto.

💻 Como Executar o Projeto

Certifique-se de ter o Visual Studio instalado com o pacote de desenvolvimento .NET Desktop Development (Windows Forms).

Clone ou baixe este repositório.

Abra o arquivo .slnx no Visual Studio.

Pressione F5 ou clique em Start / Iniciar para rodar a aplicação.

Na tela inicial:

Digite o nome para criar um novo jogador, ou

Informe o ID de um jogador existente.

Pressione Enter para iniciar o jogo.

🛠️ Tecnologias Utilizadas

C#

.NET (Windows Forms)

Programação Orientada a Objetos

Programação Assíncrona básica (async / await com Task.Delay)

🔮 Possíveis Melhorias Futuras

Algumas melhorias que podem ser implementadas em versões futuras do projeto:

Persistência de dados para salvar jogadores e estatísticas.

Sistema de ranking entre jogadores.

Interface gráfica mais moderna.

Histórico de partidas.

Melhorias visuais nas transições e feedback das jogadas.

👨‍💻 Integrantes

Geronimo Augusto — RM557170

Murilo Cordeiro — RM556727

Vitor Augusto — RM555469
