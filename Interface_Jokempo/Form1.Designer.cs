namespace Interface_Jokempo
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
            salvarBTN = new Button();
            jogadorTXT = new TextBox();
            SuspendLayout();
            // 
            // salvarBTN
            // 
            salvarBTN.Location = new Point(426, 88);
            salvarBTN.Name = "salvarBTN";
            salvarBTN.Size = new Size(75, 23);
            salvarBTN.TabIndex = 0;
            salvarBTN.Text = "SALVAR";
            salvarBTN.UseVisualStyleBackColor = true;
            salvarBTN.Click += salvarBTN_Click;
            // 
            // jogadorTXT
            // 
            jogadorTXT.Location = new Point(273, 89);
            jogadorTXT.Name = "jogadorTXT";
            jogadorTXT.Size = new Size(147, 23);
            jogadorTXT.TabIndex = 1;
            jogadorTXT.Text = "digite o seu nome";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(957, 553);
            Controls.Add(jogadorTXT);
            Controls.Add(salvarBTN);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button salvarBTN;
        private TextBox jogadorTXT;
    }
}
