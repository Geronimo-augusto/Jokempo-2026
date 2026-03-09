
namespace Jokenpo
{
    public partial class Form1 : Form
    {
        List<Player> jogadores = new List<Player>();
        Player playerAtual;
        bool mudar = false;
        public Form1()
        {
            InitializeComponent();

        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void logar()
        {
            string players = "-1. criar novo jogador";
            int i = 0;
            foreach (Player player in jogadores)
            {
                players += $"\n{i}. {player.Name}";
                i++;
            }

            PlayerListLabel.Text = players;
            PlayerListLabel.Visible = true;
            MudarPlayerBox.Visible = true;
            MudarPlayerBox.Focus();


        }
        private void criarPlayer()
        {
            PlayerListLabel.Visible = false;
            MudarPlayerBox.Visible = false;

            NomeLabel.Visible = true;
            PlayerNameBox.Visible = true;
            //PlayerNameBox.Focus();
        }
        private void VerificarPlayers()
        {
            PlayerEsLabel.Visible = true;
            NoBtn.Visible = true;
            YesBtn.Visible = true;
            if (jogadores.Count != 0)
            {
                PlayerEsLabel.Text = "deseja escolher um dos players que ja existem? (0_o)";
                mudar = true;
            }

        }
        private async void jogar()
        {
            attStatistic();

            PlayerListLabel.Visible = false;
            NomeLabel.Visible = false;
            PlayerNameBox.Visible = false;
            MudarPlayerBox.Visible = false;
            PlayerEsLabel.Visible = false;
            NoBtn.Visible = false;
            YesBtn.Visible = false;
            RIGHTCHOSEN.Visible = false;
            WrongChosen.Visible = false;

            StartText.Text = " Entao que o Jogo comece v(·ω·)v";
            await Task.Delay(1000);

            PlayerLabel.Text = $"Player atual: {playerAtual.Name}";
            ScissorsButton.Visible = true;
            RockButton.Visible = true;
            PaperButton.Visible = true;
            ChosenText.Visible = true;
            ContVitLabel.Visible = true;
            JogadasLabel.Visible = true;
            MudarBtn.Visible = true;
        }
        private void attStatistic()
        {
            JogadasLabel.Text = $"Jogadas totais de: {playerAtual.JogadasCont}";
            ContVitLabel.Text = $"Vitorias: {playerAtual.VitCont}";
        }

        private void dueal(string chosen)
        {
            Jokenpo jogo = new Jokenpo();
            var respostabot = jogo.Play();


            EscolhaDoBotText.Visible = true;
            EscolhaDoBotText.Text = respostabot;

            ChosenPlayerText.Visible = true;
            ChosenPlayerText.Text = chosen;
            DispotaText.Visible = true;

            bool vitoria = jogo.verific(chosen);


            if (respostabot.Equals(chosen))
            {
                VitoriaText.Visible = true;
                VitoriaText.Text = "Empate ∩(·ω·)∩";
            }
            else if (vitoria)
            {
                VitoriaText.Visible = true;
                VitoriaText.Text = "Parabens Voce ganhou... (Ｔ▽Ｔ)";
                playerAtual.VitCont++;
            }
            else
            {
                VitoriaText.Visible = true;
                VitoriaText.Text = "Oh voce perdeu... (^_^)v";
            }
            playerAtual.JogadasCont++;
            attStatistic();

        }

        private void WrongChosen_Click(object sender, EventArgs e)
        {

            StartText.Text = "...hm entao ta... TnT";
            Thread.Sleep(1000);
            StartText.Text = "...Saindo em 3... TnT";
            Thread.Sleep(1000);
            StartText.Text = "...Saindo em 2... TnT";
            Thread.Sleep(1000);
            StartText.Text = "...Saindo em 1... TnT";
            Thread.Sleep(1000);
            Application.Exit();
        }

        private void RockButton_Click(object sender, EventArgs e)
        {
            dueal("🤛");

        }

        private void PaperButton_Click(object sender, EventArgs e)
        {
            dueal("🤚");
        }

        private void ScissorsButton_Click(object sender, EventArgs e)
        {

            dueal("🤞");
        }

        private void RIGHTCHOSEN_Click(object sender, EventArgs e)
        {
            VerificarPlayers();
        }





        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void label1_Click_3(object sender, EventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void NoBtn_Click(object sender, EventArgs e)
        {
            jogar();
        }

        private void YesBtn_Click(object sender, EventArgs e)
        {
            if (mudar)
            {
                logar();
            }
            else
            {
                criarPlayer();
            }
        }

        private void MudarBtn_Click(object sender, EventArgs e)
        {
            logar();
        }

        private void PlayerNameBox_TextChanged(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (!string.IsNullOrWhiteSpace(PlayerNameBox.Text))
                {
                    Player player = new Player();
                    player.Name = PlayerNameBox.Text;
                    playerAtual = player;
                    jogadores.Add(player); 

                    e.SuppressKeyPress = true;
                    this.ActiveControl = null;
                    jogar();
                }
            }
        }

        private void MudarPlayerBox_TextChanged(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    int resp = int.Parse(MudarPlayerBox.Text);
                    if (resp == -1) {
                        criarPlayer();
                        return;
                    }
                    playerAtual = jogadores[resp];

                    e.SuppressKeyPress = true;
                    this.ActiveControl = null;
                    jogar(); 
                }
                catch
                {
                    MessageBox.Show("Jogador nao encontrado, tente denovo v('c')V");
                    MudarPlayerBox.Clear();
                }
            }
        }
    }
}
