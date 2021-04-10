namespace Trabalho_Pratico
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.criarTabela = new System.Windows.Forms.Button();
            this.preencher = new System.Windows.Forms.Button();
            this.pivo = new System.Windows.Forms.Button();
            this.solucionar = new System.Windows.Forms.Button();
            this.otimos = new System.Windows.Forms.Button();
            this.variaveis = new System.Windows.Forms.TextBox();
            this.restricoes = new System.Windows.Forms.TextBox();
            this.Resultado = new System.Windows.Forms.ListBox();
            this.dgv1 = new System.Windows.Forms.DataGridView();
            this.dgv2 = new System.Windows.Forms.DataGridView();
            this.radioMax = new System.Windows.Forms.RadioButton();
            this.radioMin = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.marcaSolucionar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Variaveis";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Restrições";
            // 
            // criarTabela
            // 
            this.criarTabela.Location = new System.Drawing.Point(28, 19);
            this.criarTabela.Name = "criarTabela";
            this.criarTabela.Size = new System.Drawing.Size(96, 37);
            this.criarTabela.TabIndex = 2;
            this.criarTabela.Text = "Criar Tabela";
            this.criarTabela.UseVisualStyleBackColor = true;
            this.criarTabela.Click += new System.EventHandler(this.criarTabela_Click);
            // 
            // preencher
            // 
            this.preencher.Location = new System.Drawing.Point(28, 62);
            this.preencher.Name = "preencher";
            this.preencher.Size = new System.Drawing.Size(96, 37);
            this.preencher.TabIndex = 3;
            this.preencher.Text = "Preencher";
            this.preencher.UseVisualStyleBackColor = true;
            this.preencher.Click += new System.EventHandler(this.preencher_Click);
            // 
            // pivo
            // 
            this.pivo.Location = new System.Drawing.Point(130, 19);
            this.pivo.Name = "pivo";
            this.pivo.Size = new System.Drawing.Size(96, 37);
            this.pivo.TabIndex = 4;
            this.pivo.Text = "Marcar Pivo";
            this.pivo.UseVisualStyleBackColor = true;
            this.pivo.Click += new System.EventHandler(this.pivo_Click);
            // 
            // solucionar
            // 
            this.solucionar.Location = new System.Drawing.Point(130, 62);
            this.solucionar.Name = "solucionar";
            this.solucionar.Size = new System.Drawing.Size(96, 37);
            this.solucionar.TabIndex = 5;
            this.solucionar.Text = "Solucionar";
            this.solucionar.UseVisualStyleBackColor = true;
            this.solucionar.Click += new System.EventHandler(this.solucionar_Click);
            // 
            // otimos
            // 
            this.otimos.Location = new System.Drawing.Point(232, 62);
            this.otimos.Name = "otimos";
            this.otimos.Size = new System.Drawing.Size(96, 37);
            this.otimos.TabIndex = 6;
            this.otimos.Text = "Valores Otimos";
            this.otimos.UseVisualStyleBackColor = true;
            this.otimos.Click += new System.EventHandler(this.otimos_Click);
            // 
            // variaveis
            // 
            this.variaveis.Location = new System.Drawing.Point(79, 28);
            this.variaveis.Name = "variaveis";
            this.variaveis.Size = new System.Drawing.Size(100, 20);
            this.variaveis.TabIndex = 7;
            // 
            // restricoes
            // 
            this.restricoes.Location = new System.Drawing.Point(79, 59);
            this.restricoes.Name = "restricoes";
            this.restricoes.Size = new System.Drawing.Size(100, 20);
            this.restricoes.TabIndex = 8;
            // 
            // Resultado
            // 
            this.Resultado.FormattingEnabled = true;
            this.Resultado.Location = new System.Drawing.Point(12, 368);
            this.Resultado.Name = "Resultado";
            this.Resultado.Size = new System.Drawing.Size(179, 82);
            this.Resultado.TabIndex = 9;
            // 
            // dgv1
            // 
            this.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv1.Location = new System.Drawing.Point(12, 138);
            this.dgv1.Name = "dgv1";
            this.dgv1.Size = new System.Drawing.Size(378, 210);
            this.dgv1.TabIndex = 10;
            // 
            // dgv2
            // 
            this.dgv2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv2.Location = new System.Drawing.Point(410, 138);
            this.dgv2.Name = "dgv2";
            this.dgv2.Size = new System.Drawing.Size(378, 210);
            this.dgv2.TabIndex = 11;
            // 
            // radioMax
            // 
            this.radioMax.AutoSize = true;
            this.radioMax.Location = new System.Drawing.Point(196, 29);
            this.radioMax.Name = "radioMax";
            this.radioMax.Size = new System.Drawing.Size(86, 17);
            this.radioMax.TabIndex = 12;
            this.radioMax.TabStop = true;
            this.radioMax.Text = "Maximização";
            this.radioMax.UseVisualStyleBackColor = true;
            // 
            // radioMin
            // 
            this.radioMin.AutoSize = true;
            this.radioMin.Location = new System.Drawing.Point(196, 58);
            this.radioMin.Name = "radioMin";
            this.radioMin.Size = new System.Drawing.Size(83, 17);
            this.radioMin.TabIndex = 13;
            this.radioMin.TabStop = true;
            this.radioMin.Text = "Minimização";
            this.radioMin.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.radioMin);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.radioMax);
            this.groupBox1.Controls.Add(this.variaveis);
            this.groupBox1.Controls.Add(this.restricoes);
            this.groupBox1.Location = new System.Drawing.Point(12, 18);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(378, 114);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Método Simplex";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.marcaSolucionar);
            this.groupBox2.Controls.Add(this.preencher);
            this.groupBox2.Controls.Add(this.criarTabela);
            this.groupBox2.Controls.Add(this.pivo);
            this.groupBox2.Controls.Add(this.solucionar);
            this.groupBox2.Controls.Add(this.otimos);
            this.groupBox2.Location = new System.Drawing.Point(410, 18);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(378, 114);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Operações";
            // 
            // marcaSolucionar
            // 
            this.marcaSolucionar.Location = new System.Drawing.Point(232, 19);
            this.marcaSolucionar.Name = "marcaSolucionar";
            this.marcaSolucionar.Size = new System.Drawing.Size(96, 37);
            this.marcaSolucionar.TabIndex = 7;
            this.marcaSolucionar.Text = "Marcar Pivo e Solucionar";
            this.marcaSolucionar.UseVisualStyleBackColor = true;
            this.marcaSolucionar.Click += new System.EventHandler(this.marcaSolucionar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 464);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgv2);
            this.Controls.Add(this.dgv1);
            this.Controls.Add(this.Resultado);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button criarTabela;
        private System.Windows.Forms.Button preencher;
        private System.Windows.Forms.Button pivo;
        private System.Windows.Forms.Button solucionar;
        private System.Windows.Forms.Button otimos;
        private System.Windows.Forms.TextBox variaveis;
        private System.Windows.Forms.TextBox restricoes;
        private System.Windows.Forms.ListBox Resultado;
        private System.Windows.Forms.DataGridView dgv1;
        private System.Windows.Forms.DataGridView dgv2;
        private System.Windows.Forms.RadioButton radioMax;
        private System.Windows.Forms.RadioButton radioMin;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button marcaSolucionar;
    }
}

