namespace CriarSlidesIgreja
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.btnCriar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbTituloMusica = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.numLinhas = new System.Windows.Forms.NumericUpDown();
            this.chkLetrasMaiusculas = new System.Windows.Forms.CheckBox();
            this.numTamanhoFonte = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.numTamanhoTitulo = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.colorDialogFonte = new System.Windows.Forms.ColorDialog();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCorFonte = new System.Windows.Forms.Button();
            this.tbArquivoModelo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbPastaSaida = new System.Windows.Forms.TextBox();
            this.btnArquivoModelo = new System.Windows.Forms.Button();
            this.btnPastaSaida = new System.Windows.Forms.Button();
            this.tbLetra = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.openFileTela = new System.Windows.Forms.OpenFileDialog();
            this.label9 = new System.Windows.Forms.Label();
            this.folderBrowserTela = new System.Windows.Forms.FolderBrowserDialog();
            this.btnAbrirLetra = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numLinhas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTamanhoFonte)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTamanhoTitulo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCriar
            // 
            this.btnCriar.Location = new System.Drawing.Point(420, 444);
            this.btnCriar.Name = "btnCriar";
            this.btnCriar.Size = new System.Drawing.Size(75, 23);
            this.btnCriar.TabIndex = 0;
            this.btnCriar.Text = "&Criar";
            this.btnCriar.UseVisualStyleBackColor = true;
            this.btnCriar.Click += new System.EventHandler(this.btnCriar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Titulo / Nome:";
            // 
            // tbTituloMusica
            // 
            this.tbTituloMusica.Location = new System.Drawing.Point(103, 21);
            this.tbTituloMusica.Name = "tbTituloMusica";
            this.tbTituloMusica.Size = new System.Drawing.Size(392, 20);
            this.tbTituloMusica.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Linhas por Slide:";
            // 
            // numLinhas
            // 
            this.numLinhas.Location = new System.Drawing.Point(103, 47);
            this.numLinhas.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numLinhas.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numLinhas.Name = "numLinhas";
            this.numLinhas.Size = new System.Drawing.Size(57, 20);
            this.numLinhas.TabIndex = 5;
            this.numLinhas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numLinhas.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // chkLetrasMaiusculas
            // 
            this.chkLetrasMaiusculas.AutoSize = true;
            this.chkLetrasMaiusculas.Checked = true;
            this.chkLetrasMaiusculas.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkLetrasMaiusculas.Location = new System.Drawing.Point(212, 48);
            this.chkLetrasMaiusculas.Name = "chkLetrasMaiusculas";
            this.chkLetrasMaiusculas.Size = new System.Drawing.Size(116, 17);
            this.chkLetrasMaiusculas.TabIndex = 6;
            this.chkLetrasMaiusculas.Text = "Letras Maíusculas ";
            this.chkLetrasMaiusculas.UseVisualStyleBackColor = true;
            // 
            // numTamanhoFonte
            // 
            this.numTamanhoFonte.Location = new System.Drawing.Point(103, 74);
            this.numTamanhoFonte.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.numTamanhoFonte.Minimum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.numTamanhoFonte.Name = "numTamanhoFonte";
            this.numTamanhoFonte.Size = new System.Drawing.Size(57, 20);
            this.numTamanhoFonte.TabIndex = 8;
            this.numTamanhoFonte.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numTamanhoFonte.Value = new decimal(new int[] {
            45,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Tamanho Letra:";
            // 
            // numTamanhoTitulo
            // 
            this.numTamanhoTitulo.Location = new System.Drawing.Point(438, 47);
            this.numTamanhoTitulo.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.numTamanhoTitulo.Minimum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.numTamanhoTitulo.Name = "numTamanhoTitulo";
            this.numTamanhoTitulo.Size = new System.Drawing.Size(57, 20);
            this.numTamanhoTitulo.TabIndex = 10;
            this.numTamanhoTitulo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numTamanhoTitulo.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(347, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Tamanho Titulo:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(347, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Cor da Fonte:";
            // 
            // btnCorFonte
            // 
            this.btnCorFonte.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnCorFonte.Location = new System.Drawing.Point(438, 74);
            this.btnCorFonte.Name = "btnCorFonte";
            this.btnCorFonte.Size = new System.Drawing.Size(57, 20);
            this.btnCorFonte.TabIndex = 12;
            this.btnCorFonte.UseVisualStyleBackColor = false;
            this.btnCorFonte.Click += new System.EventHandler(this.btnCorFonte_Click);
            // 
            // tbArquivoModelo
            // 
            this.tbArquivoModelo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbArquivoModelo.Location = new System.Drawing.Point(103, 100);
            this.tbArquivoModelo.Name = "tbArquivoModelo";
            this.tbArquivoModelo.ReadOnly = true;
            this.tbArquivoModelo.Size = new System.Drawing.Size(359, 20);
            this.tbArquivoModelo.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 103);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Arquivo Modelo:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 129);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Pasta Saída:";
            // 
            // tbPastaSaida
            // 
            this.tbPastaSaida.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbPastaSaida.Location = new System.Drawing.Point(103, 126);
            this.tbPastaSaida.Name = "tbPastaSaida";
            this.tbPastaSaida.ReadOnly = true;
            this.tbPastaSaida.Size = new System.Drawing.Size(359, 20);
            this.tbPastaSaida.TabIndex = 15;
            // 
            // btnArquivoModelo
            // 
            this.btnArquivoModelo.Location = new System.Drawing.Point(468, 100);
            this.btnArquivoModelo.Name = "btnArquivoModelo";
            this.btnArquivoModelo.Size = new System.Drawing.Size(27, 20);
            this.btnArquivoModelo.TabIndex = 17;
            this.btnArquivoModelo.Text = "...";
            this.btnArquivoModelo.UseVisualStyleBackColor = true;
            this.btnArquivoModelo.Click += new System.EventHandler(this.btnArquivoModelo_Click);
            // 
            // btnPastaSaida
            // 
            this.btnPastaSaida.Location = new System.Drawing.Point(468, 126);
            this.btnPastaSaida.Name = "btnPastaSaida";
            this.btnPastaSaida.Size = new System.Drawing.Size(27, 20);
            this.btnPastaSaida.TabIndex = 18;
            this.btnPastaSaida.Text = "...";
            this.btnPastaSaida.UseVisualStyleBackColor = true;
            this.btnPastaSaida.Click += new System.EventHandler(this.btnPastaSaida_Click);
            // 
            // tbLetra
            // 
            this.tbLetra.Location = new System.Drawing.Point(12, 201);
            this.tbLetra.Multiline = true;
            this.tbLetra.Name = "tbLetra";
            this.tbLetra.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbLetra.Size = new System.Drawing.Size(483, 237);
            this.tbLetra.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 185);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Letra da Música:";
            // 
            // openFileTela
            // 
            this.openFileTela.FileName = "Arquivo de Modelo";
            this.openFileTela.Filter = "\"Arquivo PPTX|*.pptx|Arquivo PPT|*.ppt\"";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(182, 149);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(280, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "O nome do arquivo será o Titulo da Letra informado acima";
            // 
            // btnAbrirLetra
            // 
            this.btnAbrirLetra.Location = new System.Drawing.Point(12, 444);
            this.btnAbrirLetra.Name = "btnAbrirLetra";
            this.btnAbrirLetra.Size = new System.Drawing.Size(75, 23);
            this.btnAbrirLetra.TabIndex = 22;
            this.btnAbrirLetra.Text = "&Abrir Letra";
            this.btnAbrirLetra.UseVisualStyleBackColor = true;
            this.btnAbrirLetra.Click += new System.EventHandler(this.btnAbrirLetra_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 479);
            this.Controls.Add(this.btnAbrirLetra);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tbLetra);
            this.Controls.Add(this.btnPastaSaida);
            this.Controls.Add(this.btnArquivoModelo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbPastaSaida);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbArquivoModelo);
            this.Controls.Add(this.btnCorFonte);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.numTamanhoTitulo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numTamanhoFonte);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.chkLetrasMaiusculas);
            this.Controls.Add(this.numLinhas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbTituloMusica);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCriar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Cria slides Igreja";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numLinhas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTamanhoFonte)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTamanhoTitulo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCriar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbTituloMusica;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numLinhas;
        private System.Windows.Forms.CheckBox chkLetrasMaiusculas;
        private System.Windows.Forms.NumericUpDown numTamanhoFonte;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numTamanhoTitulo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ColorDialog colorDialogFonte;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnCorFonte;
        private System.Windows.Forms.TextBox tbArquivoModelo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbPastaSaida;
        private System.Windows.Forms.Button btnArquivoModelo;
        private System.Windows.Forms.Button btnPastaSaida;
        private System.Windows.Forms.TextBox tbLetra;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.OpenFileDialog openFileTela;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserTela;
        private System.Windows.Forms.Button btnAbrirLetra;
    }
}

