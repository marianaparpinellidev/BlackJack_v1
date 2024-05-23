namespace BlackJack_v1
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
            Button novo_jogo;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pedir_carta = new Button();
            parar = new Button();
            jogador = new Label();
            dealer = new Label();
            pontos_dealer = new TextBox();
            pontos_jogador = new TextBox();
            pictureBox1 = new PictureBox();
            cartas_distribuicao = new PictureBox();
            mao_dealer = new PictureBox();
            mao_jogador = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            novo_jogo = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cartas_distribuicao).BeginInit();
            ((System.ComponentModel.ISupportInitialize)mao_dealer).BeginInit();
            ((System.ComponentModel.ISupportInitialize)mao_jogador).BeginInit();
            SuspendLayout();
            // 
            // novo_jogo
            // 
            novo_jogo.AllowDrop = true;
            novo_jogo.BackColor = Color.WhiteSmoke;
            novo_jogo.FlatAppearance.BorderColor = SystemColors.ButtonHighlight;
            novo_jogo.FlatAppearance.BorderSize = 0;
            novo_jogo.FlatAppearance.MouseDownBackColor = SystemColors.ActiveBorder;
            novo_jogo.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke;
            novo_jogo.Font = new Font("Kristen ITC", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            novo_jogo.ForeColor = SystemColors.ActiveCaptionText;
            novo_jogo.ImageAlign = ContentAlignment.MiddleRight;
            novo_jogo.Location = new Point(669, 388);
            novo_jogo.Margin = new Padding(0);
            novo_jogo.Name = "novo_jogo";
            novo_jogo.Size = new Size(114, 49);
            novo_jogo.TabIndex = 0;
            novo_jogo.Text = "Novo Jogo";
            novo_jogo.UseVisualStyleBackColor = false;
            novo_jogo.Click += novo_jogo_Click;
            // 
            // pedir_carta
            // 
            pedir_carta.BackColor = Color.Navy;
            pedir_carta.BackgroundImageLayout = ImageLayout.Center;
            pedir_carta.FlatAppearance.BorderColor = SystemColors.ButtonHighlight;
            pedir_carta.FlatAppearance.BorderSize = 0;
            pedir_carta.FlatAppearance.MouseDownBackColor = Color.Cyan;
            pedir_carta.FlatAppearance.MouseOverBackColor = Color.Navy;
            pedir_carta.FlatStyle = FlatStyle.Flat;
            pedir_carta.Font = new Font("Kristen ITC", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            pedir_carta.ForeColor = SystemColors.ControlLightLight;
            pedir_carta.Location = new Point(668, 272);
            pedir_carta.Name = "pedir_carta";
            pedir_carta.Size = new Size(116, 49);
            pedir_carta.TabIndex = 1;
            pedir_carta.Text = "Pedir Carta";
            pedir_carta.TextImageRelation = TextImageRelation.ImageAboveText;
            pedir_carta.UseVisualStyleBackColor = false;
            pedir_carta.Click += pedir_carta_Click;
            // 
            // parar
            // 
            parar.BackColor = Color.Crimson;
            parar.BackgroundImageLayout = ImageLayout.Center;
            parar.FlatAppearance.BorderColor = Color.Crimson;
            parar.FlatAppearance.MouseDownBackColor = Color.LightCoral;
            parar.FlatAppearance.MouseOverBackColor = Color.Crimson;
            parar.FlatStyle = FlatStyle.Flat;
            parar.Font = new Font("Kristen ITC", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            parar.ForeColor = SystemColors.ControlLightLight;
            parar.Location = new Point(669, 330);
            parar.Name = "parar";
            parar.Size = new Size(115, 49);
            parar.TabIndex = 2;
            parar.Text = "Parar";
            parar.UseVisualStyleBackColor = false;
            parar.UseWaitCursor = true;
            parar.Click += parar_Click_1;
            // 
            // jogador
            // 
            jogador.AutoSize = true;
            jogador.BackColor = Color.Transparent;
            jogador.Font = new Font("Kristen ITC", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            jogador.Location = new Point(688, 199);
            jogador.Name = "jogador";
            jogador.Size = new Size(77, 22);
            jogador.TabIndex = 3;
            jogador.Text = "Jogador";
            // 
            // dealer
            // 
            dealer.AutoSize = true;
            dealer.FlatStyle = FlatStyle.Flat;
            dealer.Font = new Font("Kristen ITC", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dealer.ForeColor = SystemColors.ControlText;
            dealer.Location = new Point(694, 135);
            dealer.Name = "dealer";
            dealer.Size = new Size(65, 22);
            dealer.TabIndex = 4;
            dealer.Text = "Dealer";
            dealer.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pontos_dealer
            // 
            pontos_dealer.BackColor = SystemColors.InactiveBorder;
            pontos_dealer.Font = new Font("Kristen ITC", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            pontos_dealer.Location = new Point(693, 159);
            pontos_dealer.Name = "pontos_dealer";
            pontos_dealer.Size = new Size(66, 33);
            pontos_dealer.TabIndex = 5;
            pontos_dealer.TextAlign = HorizontalAlignment.Center;
            // 
            // pontos_jogador
            // 
            pontos_jogador.BackColor = SystemColors.InactiveBorder;
            pontos_jogador.Font = new Font("Kristen ITC", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            pontos_jogador.Location = new Point(693, 222);
            pontos_jogador.Name = "pontos_jogador";
            pontos_jogador.Size = new Size(66, 33);
            pontos_jogador.TabIndex = 6;
            pontos_jogador.TextAlign = HorizontalAlignment.Center;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(668, 14);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(114, 118);
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // cartas_distribuicao
            // 
            cartas_distribuicao.BackgroundImage = Properties.Resources._00;
            cartas_distribuicao.BackgroundImageLayout = ImageLayout.Center;
            cartas_distribuicao.Image = Properties.Resources._00;
            cartas_distribuicao.Location = new Point(96, 149);
            cartas_distribuicao.Name = "cartas_distribuicao";
            cartas_distribuicao.Size = new Size(106, 149);
            cartas_distribuicao.SizeMode = PictureBoxSizeMode.CenterImage;
            cartas_distribuicao.TabIndex = 8;
            cartas_distribuicao.TabStop = false;
            cartas_distribuicao.Click += pictureBox2_Click;
            // 
            // mao_dealer
            // 
            mao_dealer.BackgroundImage = Properties.Resources._00;
            mao_dealer.Location = new Point(335, 43);
            mao_dealer.Name = "mao_dealer";
            mao_dealer.Size = new Size(106, 149);
            mao_dealer.TabIndex = 9;
            mao_dealer.TabStop = false;
            // 
            // mao_jogador
            // 
            mao_jogador.BackgroundImage = Properties.Resources._00;
            mao_jogador.Location = new Point(335, 230);
            mao_jogador.Name = "mao_jogador";
            mao_jogador.Size = new Size(106, 149);
            mao_jogador.TabIndex = 10;
            mao_jogador.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Kristen ITC", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlText;
            label1.Location = new Point(355, 18);
            label1.Name = "label1";
            label1.Size = new Size(65, 22);
            label1.TabIndex = 11;
            label1.Text = "Dealer";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Kristen ITC", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(352, 384);
            label2.Name = "label2";
            label2.Size = new Size(77, 22);
            label2.TabIndex = 12;
            label2.Text = "Jogador";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Green;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(mao_jogador);
            Controls.Add(mao_dealer);
            Controls.Add(cartas_distribuicao);
            Controls.Add(pictureBox1);
            Controls.Add(pontos_jogador);
            Controls.Add(pontos_dealer);
            Controls.Add(dealer);
            Controls.Add(jogador);
            Controls.Add(parar);
            Controls.Add(pedir_carta);
            Controls.Add(novo_jogo);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BlackJack_v1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)cartas_distribuicao).EndInit();
            ((System.ComponentModel.ISupportInitialize)mao_dealer).EndInit();
            ((System.ComponentModel.ISupportInitialize)mao_jogador).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button novo_jogo;
        private Button pedir_carta;
        private Button parar;
        private Label jogador;
        private Label dealer;
        private TextBox pontos_dealer;
        private TextBox pontos_jogador;
        private PictureBox pictureBox1;
        private PictureBox cartas_distribuicao;
        private PictureBox mao_dealer;
        private PictureBox mao_jogador;
        private Label label1;
        private Label label2;
    }
}
