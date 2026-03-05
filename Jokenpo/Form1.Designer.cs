namespace Jokenpo
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            StartText = new Label();
            WrongChosen = new Button();
            RIGHTCHOSEN = new Button();
            RockButton = new Button();
            PaperButton = new Button();
            ScissorsButton = new Button();
            DispotaText = new Label();
            ChosenPlayerText = new Label();
            EscolhaDoBotText = new Label();
            ChosenText = new Label();
            VitoriaText = new Label();
            PlayerNameBox = new TextBox();
            ContVitLabel = new Label();
            JogadasLabel = new Label();
            PlayerEsLabel = new Label();
            YesBtn = new Button();
            NoBtn = new Button();
            NomeLabel = new Label();
            MudarBtn = new Button();
            PlayerListLabel = new Label();
            MudarPlayerBox = new TextBox();
            PlayerLabel = new Label();
            SuspendLayout();
            // 
            // StartText
            // 
            StartText.AutoSize = true;
            StartText.Location = new Point(334, 9);
            StartText.Name = "StartText";
            StartText.Size = new Size(75, 45);
            StartText.TabIndex = 0;
            StartText.Text = "\r\nIniciar Jogo? \r\n           (＾▽＾)\r\n";
            StartText.Click += label1_Click;
            // 
            // WrongChosen
            // 
            WrongChosen.Location = new Point(401, 74);
            WrongChosen.Name = "WrongChosen";
            WrongChosen.Size = new Size(75, 23);
            WrongChosen.TabIndex = 1;
            WrongChosen.Text = "nao... ._.";
            WrongChosen.UseVisualStyleBackColor = true;
            WrongChosen.Click += WrongChosen_Click;
            // 
            // RIGHTCHOSEN
            // 
            RIGHTCHOSEN.Location = new Point(277, 74);
            RIGHTCHOSEN.Name = "RIGHTCHOSEN";
            RIGHTCHOSEN.Size = new Size(75, 23);
            RIGHTCHOSEN.TabIndex = 2;
            RIGHTCHOSEN.Text = "SIM";
            RIGHTCHOSEN.UseVisualStyleBackColor = true;
            RIGHTCHOSEN.Click += RIGHTCHOSEN_Click;
            // 
            // RockButton
            // 
            RockButton.Location = new Point(549, 367);
            RockButton.Name = "RockButton";
            RockButton.Size = new Size(75, 23);
            RockButton.TabIndex = 3;
            RockButton.Text = "\U0001f91b";
            RockButton.UseVisualStyleBackColor = true;
            RockButton.Visible = false;
            RockButton.Click += RockButton_Click;
            // 
            // PaperButton
            // 
            PaperButton.Location = new Point(549, 396);
            PaperButton.Name = "PaperButton";
            PaperButton.Size = new Size(75, 23);
            PaperButton.TabIndex = 4;
            PaperButton.Text = "\U0001f91a";
            PaperButton.UseVisualStyleBackColor = true;
            PaperButton.Visible = false;
            PaperButton.Click += PaperButton_Click;
            // 
            // ScissorsButton
            // 
            ScissorsButton.Location = new Point(549, 425);
            ScissorsButton.Name = "ScissorsButton";
            ScissorsButton.Size = new Size(75, 23);
            ScissorsButton.TabIndex = 5;
            ScissorsButton.Text = "\U0001f91e";
            ScissorsButton.UseVisualStyleBackColor = true;
            ScissorsButton.Visible = false;
            ScissorsButton.Click += ScissorsButton_Click;
            // 
            // DispotaText
            // 
            DispotaText.AutoSize = true;
            DispotaText.Location = new Point(362, 389);
            DispotaText.Name = "DispotaText";
            DispotaText.Size = new Size(14, 15);
            DispotaText.TabIndex = 6;
            DispotaText.Text = "X";
            DispotaText.Visible = false;
            DispotaText.Click += label2_Click;
            // 
            // ChosenPlayerText
            // 
            ChosenPlayerText.AutoSize = true;
            ChosenPlayerText.Location = new Point(442, 389);
            ChosenPlayerText.Name = "ChosenPlayerText";
            ChosenPlayerText.Size = new Size(0, 15);
            ChosenPlayerText.TabIndex = 7;
            ChosenPlayerText.Visible = false;
            ChosenPlayerText.Click += label3_Click;
            // 
            // EscolhaDoBotText
            // 
            EscolhaDoBotText.AutoSize = true;
            EscolhaDoBotText.Location = new Point(275, 389);
            EscolhaDoBotText.Name = "EscolhaDoBotText";
            EscolhaDoBotText.Size = new Size(0, 15);
            EscolhaDoBotText.TabIndex = 8;
            EscolhaDoBotText.Visible = false;
            // 
            // ChosenText
            // 
            ChosenText.AutoSize = true;
            ChosenText.Location = new Point(532, 329);
            ChosenText.Name = "ChosenText";
            ChosenText.Size = new Size(104, 15);
            ChosenText.TabIndex = 9;
            ChosenText.Text = "Faça a sua escolha";
            ChosenText.Visible = false;
            ChosenText.Click += label1_Click_1;
            // 
            // VitoriaText
            // 
            VitoriaText.AutoSize = true;
            VitoriaText.Location = new Point(318, 324);
            VitoriaText.Name = "VitoriaText";
            VitoriaText.Size = new Size(132, 15);
            VitoriaText.TabIndex = 10;
            VitoriaText.Text = "Parabes você ganhou!!!!";
            VitoriaText.Visible = false;
            VitoriaText.Click += label1_Click_2;
            // 
            // PlayerNameBox
            // 
            PlayerNameBox.Location = new Point(12, 127);
            PlayerNameBox.Name = "PlayerNameBox";
            PlayerNameBox.Size = new Size(100, 23);
            PlayerNameBox.TabIndex = 11;
            PlayerNameBox.Visible = false;
            PlayerNameBox.KeyDown += PlayerNameBox_TextChanged;
            // 
            // ContVitLabel
            // 
            ContVitLabel.AutoSize = true;
            ContVitLabel.Location = new Point(648, 153);
            ContVitLabel.Name = "ContVitLabel";
            ContVitLabel.Size = new Size(101, 15);
            ContVitLabel.TabIndex = 12;
            ContVitLabel.Text = "Vitorias do player:";
            ContVitLabel.Visible = false;
            ContVitLabel.Click += label1_Click_3;
            // 
            // JogadasLabel
            // 
            JogadasLabel.AutoSize = true;
            JogadasLabel.Location = new Point(648, 209);
            JogadasLabel.Name = "JogadasLabel";
            JogadasLabel.Size = new Size(97, 15);
            JogadasLabel.TabIndex = 13;
            JogadasLabel.Text = "Total de Jogadas:";
            JogadasLabel.Visible = false;
            // 
            // PlayerEsLabel
            // 
            PlayerEsLabel.AutoSize = true;
            PlayerEsLabel.Location = new Point(309, 127);
            PlayerEsLabel.Name = "PlayerEsLabel";
            PlayerEsLabel.Size = new Size(141, 30);
            PlayerEsLabel.TabIndex = 14;
            PlayerEsLabel.Text = "Nao ha nenhum Jogador.\r\nDeseja criar um novo?";
            PlayerEsLabel.Visible = false;
            // 
            // YesBtn
            // 
            YesBtn.Location = new Point(277, 188);
            YesBtn.Name = "YesBtn";
            YesBtn.Size = new Size(75, 23);
            YesBtn.TabIndex = 15;
            YesBtn.Text = "Sim";
            YesBtn.UseVisualStyleBackColor = true;
            YesBtn.Visible = false;
            YesBtn.Click += YesBtn_Click;
            // 
            // NoBtn
            // 
            NoBtn.Location = new Point(401, 188);
            NoBtn.Name = "NoBtn";
            NoBtn.Size = new Size(75, 23);
            NoBtn.TabIndex = 16;
            NoBtn.Text = "Nao";
            NoBtn.UseVisualStyleBackColor = true;
            NoBtn.Visible = false;
            NoBtn.Click += NoBtn_Click;
            // 
            // NomeLabel
            // 
            NomeLabel.AutoSize = true;
            NomeLabel.Location = new Point(12, 91);
            NomeLabel.Name = "NomeLabel";
            NomeLabel.Size = new Size(134, 15);
            NomeLabel.TabIndex = 17;
            NomeLabel.Text = "Digite o nome do player";
            NomeLabel.Visible = false;
            // 
            // MudarBtn
            // 
            MudarBtn.Location = new Point(670, 425);
            MudarBtn.Name = "MudarBtn";
            MudarBtn.Size = new Size(75, 23);
            MudarBtn.TabIndex = 19;
            MudarBtn.Text = "Mudar jogador";
            MudarBtn.UseVisualStyleBackColor = true;
            MudarBtn.Visible = false;
            MudarBtn.Click += MudarBtn_Click;
            // 
            // PlayerListLabel
            // 
            PlayerListLabel.AutoSize = true;
            PlayerListLabel.Location = new Point(12, 209);
            PlayerListLabel.Name = "PlayerListLabel";
            PlayerListLabel.Size = new Size(38, 15);
            PlayerListLabel.TabIndex = 20;
            PlayerListLabel.Text = "label1";
            PlayerListLabel.Visible = false;
            // 
            // MudarPlayerBox
            // 
            MudarPlayerBox.Location = new Point(12, 425);
            MudarPlayerBox.Name = "MudarPlayerBox";
            MudarPlayerBox.PlaceholderText = "Digite o numero do jogador";
            MudarPlayerBox.Size = new Size(161, 23);
            MudarPlayerBox.TabIndex = 21;
            MudarPlayerBox.Visible = false;
            MudarPlayerBox.KeyDown += MudarPlayerBox_TextChanged;
            // 
            // PlayerLabel
            // 
            PlayerLabel.AutoSize = true;
            PlayerLabel.Location = new Point(670, 389);
            PlayerLabel.Name = "PlayerLabel";
            PlayerLabel.Size = new Size(74, 15);
            PlayerLabel.TabIndex = 22;
            PlayerLabel.Text = "Player atual: ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(PlayerLabel);
            Controls.Add(MudarPlayerBox);
            Controls.Add(PlayerListLabel);
            Controls.Add(MudarBtn);
            Controls.Add(NomeLabel);
            Controls.Add(NoBtn);
            Controls.Add(YesBtn);
            Controls.Add(PlayerEsLabel);
            Controls.Add(JogadasLabel);
            Controls.Add(ContVitLabel);
            Controls.Add(PlayerNameBox);
            Controls.Add(VitoriaText);
            Controls.Add(ChosenText);
            Controls.Add(EscolhaDoBotText);
            Controls.Add(ChosenPlayerText);
            Controls.Add(DispotaText);
            Controls.Add(ScissorsButton);
            Controls.Add(PaperButton);
            Controls.Add(RockButton);
            Controls.Add(RIGHTCHOSEN);
            Controls.Add(WrongChosen);
            Controls.Add(StartText);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label StartText;
        private Button WrongChosen;
        private Button RIGHTCHOSEN;
        private Button RockButton;
        private Button PaperButton;
        private Button ScissorsButton;
        private Label DispotaText;
        private Label ChosenPlayerText;
        private Label EscolhaDoBotText;
        private Label ChosenText;
        private Label VitoriaText;
        private TextBox PlayerNameBox;
        private Label ContVitLabel;
        private Label JogadasLabel;
        private Label PlayerEsLabel;
        private Button YesBtn;
        private Button NoBtn;
        private Label NomeLabel;
        private Button MudarBtn;
        private Label PlayerListLabel;
        private TextBox MudarPlayerBox;
        private Label PlayerLabel;
    }
}
