
namespace BibliotecaDeJogosForms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.labelTitulo = new System.Windows.Forms.Label();
            this.labelGenero = new System.Windows.Forms.Label();
            this.labelJogadores = new System.Windows.Forms.Label();
            this.labelLancamento = new System.Windows.Forms.Label();
            this.textTitulo = new System.Windows.Forms.TextBox();
            this.textGenero = new System.Windows.Forms.TextBox();
            this.textLancamento = new System.Windows.Forms.TextBox();
            this.textJogadores = new System.Windows.Forms.TextBox();
            this.btCadastrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label1.Location = new System.Drawing.Point(386, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Biblioteca de Jogos";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.BackColor = System.Drawing.Color.Transparent;
            this.labelTitulo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelTitulo.Location = new System.Drawing.Point(65, 204);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(40, 15);
            this.labelTitulo.TabIndex = 1;
            this.labelTitulo.Text = "Titulo:";
            this.labelTitulo.Click += new System.EventHandler(this.label2_Click);
            // 
            // labelGenero
            // 
            this.labelGenero.AutoSize = true;
            this.labelGenero.BackColor = System.Drawing.Color.Transparent;
            this.labelGenero.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelGenero.Location = new System.Drawing.Point(65, 237);
            this.labelGenero.Name = "labelGenero";
            this.labelGenero.Size = new System.Drawing.Size(45, 15);
            this.labelGenero.TabIndex = 2;
            this.labelGenero.Text = "Gênero";
            this.labelGenero.Click += new System.EventHandler(this.label3_Click);
            // 
            // labelJogadores
            // 
            this.labelJogadores.AutoSize = true;
            this.labelJogadores.BackColor = System.Drawing.Color.Transparent;
            this.labelJogadores.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelJogadores.Location = new System.Drawing.Point(64, 300);
            this.labelJogadores.Name = "labelJogadores";
            this.labelJogadores.Size = new System.Drawing.Size(104, 15);
            this.labelJogadores.TabIndex = 3;
            this.labelJogadores.Text = "Máx. de jogadores";
            this.labelJogadores.Click += new System.EventHandler(this.label4_Click);
            // 
            // labelLancamento
            // 
            this.labelLancamento.AutoSize = true;
            this.labelLancamento.BackColor = System.Drawing.Color.Transparent;
            this.labelLancamento.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelLancamento.Location = new System.Drawing.Point(64, 269);
            this.labelLancamento.Name = "labelLancamento";
            this.labelLancamento.Size = new System.Drawing.Size(73, 15);
            this.labelLancamento.TabIndex = 4;
            this.labelLancamento.Text = "Lançamento";
            // 
            // textTitulo
            // 
            this.textTitulo.Location = new System.Drawing.Point(111, 201);
            this.textTitulo.Name = "textTitulo";
            this.textTitulo.Size = new System.Drawing.Size(153, 23);
            this.textTitulo.TabIndex = 5;
            // 
            // textGenero
            // 
            this.textGenero.Location = new System.Drawing.Point(116, 234);
            this.textGenero.Name = "textGenero";
            this.textGenero.Size = new System.Drawing.Size(146, 23);
            this.textGenero.TabIndex = 6;
            // 
            // textLancamento
            // 
            this.textLancamento.Location = new System.Drawing.Point(143, 266);
            this.textLancamento.Name = "textLancamento";
            this.textLancamento.Size = new System.Drawing.Size(119, 23);
            this.textLancamento.TabIndex = 7;
            // 
            // textJogadores
            // 
            this.textJogadores.Location = new System.Drawing.Point(174, 297);
            this.textJogadores.Name = "textJogadores";
            this.textJogadores.Size = new System.Drawing.Size(88, 23);
            this.textJogadores.TabIndex = 8;
            // 
            // btCadastrar
            // 
            this.btCadastrar.BackColor = System.Drawing.Color.White;
            this.btCadastrar.Location = new System.Drawing.Point(64, 341);
            this.btCadastrar.Name = "btCadastrar";
            this.btCadastrar.Size = new System.Drawing.Size(198, 23);
            this.btCadastrar.TabIndex = 9;
            this.btCadastrar.Text = "CADASTRAR";
            this.btCadastrar.UseVisualStyleBackColor = false;
            this.btCadastrar.Click += new System.EventHandler(this.btCadastrar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.BackgroundImage = global::BibliotecaDeJogosForms.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(886, 486);
            this.Controls.Add(this.btCadastrar);
            this.Controls.Add(this.textJogadores);
            this.Controls.Add(this.textLancamento);
            this.Controls.Add(this.textGenero);
            this.Controls.Add(this.textTitulo);
            this.Controls.Add(this.labelLancamento);
            this.Controls.Add(this.labelJogadores);
            this.Controls.Add(this.labelGenero);
            this.Controls.Add(this.labelTitulo);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Biblioteca de Jogos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.Label labelGenero;
        private System.Windows.Forms.Label labelJogadores;
        private System.Windows.Forms.Label labelLancamento;
        private System.Windows.Forms.TextBox textTitulo;
        private System.Windows.Forms.TextBox textGenero;
        private System.Windows.Forms.TextBox textLancamento;
        private System.Windows.Forms.TextBox textJogadores;
        private System.Windows.Forms.Button btCadastrar;
    }
}

