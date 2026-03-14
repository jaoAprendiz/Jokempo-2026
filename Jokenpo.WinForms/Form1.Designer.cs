namespace Jokenpo.WinForms
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
            btnPedra = new Button();
            btnPapel = new Button();
            btnTesoura = new Button();
            btnResetar = new Button();
            labelJogador = new Label();
            labelPlacar = new Label();
            labelEscolhaJogador = new Label();
            labelEscolhaPC = new Label();
            labelResultado = new Label();
            JOKENPO = new Label();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // btnPedra
            // 
            btnPedra.Font = new Font("Segoe UI", 25F);
            btnPedra.ForeColor = Color.FromArgb(192, 64, 0);
            btnPedra.Location = new Point(52, 206);
            btnPedra.Name = "btnPedra";
            btnPedra.Size = new Size(80, 68);
            btnPedra.TabIndex = 0;
            btnPedra.Text = "✊";
            btnPedra.UseVisualStyleBackColor = true;
            btnPedra.Click += btnPedra_Click;
            // 
            // btnPapel
            // 
            btnPapel.Font = new Font("Segoe UI", 25F);
            btnPapel.ForeColor = Color.FromArgb(192, 64, 0);
            btnPapel.Location = new Point(158, 206);
            btnPapel.Name = "btnPapel";
            btnPapel.Size = new Size(80, 68);
            btnPapel.TabIndex = 1;
            btnPapel.Text = "✋";
            btnPapel.UseVisualStyleBackColor = true;
            btnPapel.Click += btnPapel_Click;
            // 
            // btnTesoura
            // 
            btnTesoura.Font = new Font("Segoe UI", 25F);
            btnTesoura.ForeColor = Color.FromArgb(192, 64, 0);
            btnTesoura.Location = new Point(265, 206);
            btnTesoura.Name = "btnTesoura";
            btnTesoura.Size = new Size(80, 68);
            btnTesoura.TabIndex = 2;
            btnTesoura.Text = "✌️";
            btnTesoura.UseVisualStyleBackColor = true;
            btnTesoura.Click += btnTesoura_Click;
            // 
            // btnResetar
            // 
            btnResetar.BackColor = Color.FromArgb(192, 64, 0);
            btnResetar.Cursor = Cursors.Hand;
            btnResetar.Font = new Font("Arial Narrow", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnResetar.ForeColor = Color.White;
            btnResetar.Location = new Point(331, 569);
            btnResetar.Name = "btnResetar";
            btnResetar.Size = new Size(88, 34);
            btnResetar.TabIndex = 3;
            btnResetar.Text = "RESETAR";
            btnResetar.UseVisualStyleBackColor = false;
            btnResetar.Click += btnResetar_Click;
            // 
            // labelJogador
            // 
            labelJogador.AutoSize = true;
            labelJogador.Font = new Font("Arial Narrow", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelJogador.ForeColor = Color.White;
            labelJogador.Location = new Point(52, 110);
            labelJogador.Name = "labelJogador";
            labelJogador.Size = new Size(79, 23);
            labelJogador.TabIndex = 4;
            labelJogador.Text = "Jogador:";
            // 
            // labelPlacar
            // 
            labelPlacar.AutoSize = true;
            labelPlacar.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelPlacar.ForeColor = Color.White;
            labelPlacar.Location = new Point(58, 525);
            labelPlacar.Name = "labelPlacar";
            labelPlacar.Size = new Size(209, 20);
            labelPlacar.TabIndex = 5;
            labelPlacar.Text = "Vitórias: 0 Derrotas: 0 Empates: 0";
            // 
            // labelEscolhaJogador
            // 
            labelEscolhaJogador.AutoSize = true;
            labelEscolhaJogador.Font = new Font("Arial Narrow", 12F);
            labelEscolhaJogador.ForeColor = Color.White;
            labelEscolhaJogador.Location = new Point(52, 324);
            labelEscolhaJogador.Name = "labelEscolhaJogador";
            labelEscolhaJogador.Size = new Size(49, 20);
            labelEscolhaJogador.TabIndex = 6;
            labelEscolhaJogador.Text = "Você: ";
            // 
            // labelEscolhaPC
            // 
            labelEscolhaPC.AutoSize = true;
            labelEscolhaPC.Font = new Font("Arial Narrow", 12F);
            labelEscolhaPC.ForeColor = Color.White;
            labelEscolhaPC.Location = new Point(52, 356);
            labelEscolhaPC.Name = "labelEscolhaPC";
            labelEscolhaPC.Size = new Size(35, 20);
            labelEscolhaPC.TabIndex = 7;
            labelEscolhaPC.Text = "PC: ";
            // 
            // labelResultado
            // 
            labelResultado.AutoSize = true;
            labelResultado.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelResultado.ForeColor = Color.White;
            labelResultado.Location = new Point(52, 422);
            labelResultado.Name = "labelResultado";
            labelResultado.Size = new Size(71, 20);
            labelResultado.TabIndex = 8;
            labelResultado.Text = "Resultado";
            // 
            // JOKENPO
            // 
            JOKENPO.AutoSize = true;
            JOKENPO.Font = new Font("Impact", 24.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            JOKENPO.ForeColor = Color.FromArgb(192, 64, 0);
            JOKENPO.Location = new Point(147, 25);
            JOKENPO.Name = "JOKENPO";
            JOKENPO.Size = new Size(132, 41);
            JOKENPO.TabIndex = 9;
            JOKENPO.Text = "JOKENPO";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Narrow", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(52, 486);
            label1.Name = "label1";
            label1.Size = new Size(134, 25);
            label1.TabIndex = 10;
            label1.Text = "📊 Estatísticas:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(52, 172);
            label2.Name = "label2";
            label2.Size = new Size(207, 20);
            label2.TabIndex = 11;
            label2.Text = "Escolha entre as opções abaixo:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Navy;
            ClientSize = new Size(431, 615);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(JOKENPO);
            Controls.Add(labelResultado);
            Controls.Add(labelEscolhaPC);
            Controls.Add(labelEscolhaJogador);
            Controls.Add(labelPlacar);
            Controls.Add(labelJogador);
            Controls.Add(btnResetar);
            Controls.Add(btnTesoura);
            Controls.Add(btnPapel);
            Controls.Add(btnPedra);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public Button btnPedra;
        public Button btnPapel;
        public Button btnTesoura;
        public Button btnResetar;
        public Label labelJogador;
        public Label labelPlacar;
        public Label labelEscolhaJogador;
        public Label labelEscolhaPC;
        public Label labelResultado;
        private Label JOKENPO;
        private Label label1;
        private Label label2;
    }
}
