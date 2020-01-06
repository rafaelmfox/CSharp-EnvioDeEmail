namespace enviodeemail
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtHost = new System.Windows.Forms.TextBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnEnviarEmail = new System.Windows.Forms.Button();
            this.chkSSL = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtEmailPara = new System.Windows.Forms.TextBox();
            this.chkVerSenha = new System.Windows.Forms.CheckBox();
            this.txtAssunto = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMensagem = new System.Windows.Forms.TextBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.lstArquivos = new System.Windows.Forms.ListBox();
            this.btnCarregarArquivos = new System.Windows.Forms.Button();
            this.btnRetirarArquivo = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txtComCopia = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtComCopiaOculta = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtHost
            // 
            this.txtHost.Location = new System.Drawing.Point(70, 9);
            this.txtHost.Name = "txtHost";
            this.txtHost.Size = new System.Drawing.Size(221, 20);
            this.txtHost.TabIndex = 0;
            this.txtHost.Text = "smtp.com.br";
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(70, 89);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.Size = new System.Drawing.Size(221, 20);
            this.txtSenha.TabIndex = 1;
            this.txtSenha.Text = "SuaSenha";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(70, 63);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(221, 20);
            this.txtEmail.TabIndex = 4;
            this.txtEmail.Text = "seuemail@email.com";
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(70, 37);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(71, 20);
            this.txtPort.TabIndex = 2;
            this.txtPort.Text = "587";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Host:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Porta:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Email:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Senha:";
            // 
            // btnEnviarEmail
            // 
            this.btnEnviarEmail.Location = new System.Drawing.Point(70, 447);
            this.btnEnviarEmail.Name = "btnEnviarEmail";
            this.btnEnviarEmail.Size = new System.Drawing.Size(112, 40);
            this.btnEnviarEmail.TabIndex = 9;
            this.btnEnviarEmail.Text = "Enviar";
            this.btnEnviarEmail.UseVisualStyleBackColor = true;
            this.btnEnviarEmail.Click += new System.EventHandler(this.btnEnviarEmail_Click);
            // 
            // chkSSL
            // 
            this.chkSSL.AutoSize = true;
            this.chkSSL.Checked = true;
            this.chkSSL.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkSSL.Location = new System.Drawing.Point(147, 40);
            this.chkSSL.Name = "chkSSL";
            this.chkSSL.Size = new System.Drawing.Size(46, 17);
            this.chkSSL.TabIndex = 3;
            this.chkSSL.Text = "SSL";
            this.chkSSL.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Para:";
            // 
            // txtEmailPara
            // 
            this.txtEmailPara.Location = new System.Drawing.Point(70, 138);
            this.txtEmailPara.Name = "txtEmailPara";
            this.txtEmailPara.Size = new System.Drawing.Size(221, 20);
            this.txtEmailPara.TabIndex = 6;
            this.txtEmailPara.Text = "email@destinatario.com";
            // 
            // chkVerSenha
            // 
            this.chkVerSenha.AutoSize = true;
            this.chkVerSenha.Location = new System.Drawing.Point(70, 115);
            this.chkVerSenha.Name = "chkVerSenha";
            this.chkVerSenha.Size = new System.Drawing.Size(74, 17);
            this.chkVerSenha.TabIndex = 5;
            this.chkVerSenha.Text = "Ver senha";
            this.chkVerSenha.UseVisualStyleBackColor = true;
            this.chkVerSenha.CheckedChanged += new System.EventHandler(this.chkVerSenha_CheckedChanged);
            // 
            // txtAssunto
            // 
            this.txtAssunto.Location = new System.Drawing.Point(70, 216);
            this.txtAssunto.Name = "txtAssunto";
            this.txtAssunto.Size = new System.Drawing.Size(544, 20);
            this.txtAssunto.TabIndex = 7;
            this.txtAssunto.Text = "Assunto email";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 219);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Assunto:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(2, 242);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Mensagem:";
            // 
            // txtMensagem
            // 
            this.txtMensagem.Location = new System.Drawing.Point(70, 242);
            this.txtMensagem.Multiline = true;
            this.txtMensagem.Name = "txtMensagem";
            this.txtMensagem.Size = new System.Drawing.Size(544, 202);
            this.txtMensagem.TabIndex = 8;
            this.txtMensagem.Text = "Mensagem email";
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(511, 447);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(103, 40);
            this.btnLimpar.TabIndex = 17;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(297, 12);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Anexo:";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // lstArquivos
            // 
            this.lstArquivos.FormattingEnabled = true;
            this.lstArquivos.Location = new System.Drawing.Point(343, 9);
            this.lstArquivos.Name = "lstArquivos";
            this.lstArquivos.Size = new System.Drawing.Size(271, 134);
            this.lstArquivos.TabIndex = 21;
            // 
            // btnCarregarArquivos
            // 
            this.btnCarregarArquivos.Location = new System.Drawing.Point(620, 7);
            this.btnCarregarArquivos.Name = "btnCarregarArquivos";
            this.btnCarregarArquivos.Size = new System.Drawing.Size(26, 22);
            this.btnCarregarArquivos.TabIndex = 22;
            this.btnCarregarArquivos.Text = "+";
            this.btnCarregarArquivos.UseVisualStyleBackColor = true;
            this.btnCarregarArquivos.Click += new System.EventHandler(this.btnCarregarArquivos_Click);
            // 
            // btnRetirarArquivo
            // 
            this.btnRetirarArquivo.Location = new System.Drawing.Point(620, 31);
            this.btnRetirarArquivo.Name = "btnRetirarArquivo";
            this.btnRetirarArquivo.Size = new System.Drawing.Size(26, 22);
            this.btnRetirarArquivo.TabIndex = 23;
            this.btnRetirarArquivo.Text = "-";
            this.btnRetirarArquivo.UseVisualStyleBackColor = true;
            this.btnRetirarArquivo.Click += new System.EventHandler(this.btnRetirarArquivo_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(33, 167);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(24, 13);
            this.label9.TabIndex = 25;
            this.label9.Text = "CC:";
            // 
            // txtComCopia
            // 
            this.txtComCopia.Location = new System.Drawing.Point(70, 164);
            this.txtComCopia.Name = "txtComCopia";
            this.txtComCopia.Size = new System.Drawing.Size(221, 20);
            this.txtComCopia.TabIndex = 24;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(33, 193);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(32, 13);
            this.label10.TabIndex = 27;
            this.label10.Text = "CCO:";
            // 
            // txtComCopiaOculta
            // 
            this.txtComCopiaOculta.Location = new System.Drawing.Point(70, 190);
            this.txtComCopiaOculta.Name = "txtComCopiaOculta";
            this.txtComCopiaOculta.Size = new System.Drawing.Size(221, 20);
            this.txtComCopiaOculta.TabIndex = 26;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 529);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtComCopiaOculta);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtComCopia);
            this.Controls.Add(this.btnRetirarArquivo);
            this.Controls.Add(this.btnCarregarArquivos);
            this.Controls.Add(this.lstArquivos);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtMensagem);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtAssunto);
            this.Controls.Add(this.chkVerSenha);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtEmailPara);
            this.Controls.Add(this.chkSSL);
            this.Controls.Add(this.btnEnviarEmail);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPort);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.txtHost);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtHost;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnEnviarEmail;
        private System.Windows.Forms.CheckBox chkSSL;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtEmailPara;
        private System.Windows.Forms.CheckBox chkVerSenha;
        private System.Windows.Forms.TextBox txtAssunto;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtMensagem;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ListBox lstArquivos;
        private System.Windows.Forms.Button btnCarregarArquivos;
        private System.Windows.Forms.Button btnRetirarArquivo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtComCopia;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtComCopiaOculta;
    }
}

