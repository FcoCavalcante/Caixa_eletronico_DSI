namespace CaixaEletronico
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Button btnSacar;
        private System.Windows.Forms.Button btnDepositar;
        private System.Windows.Forms.TextBox txtMensagem;
        private System.Windows.Forms.GroupBox Operacoes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnComprovante;
        private System.Windows.Forms.Label lblNotasInfo;
        private System.Windows.Forms.Label lblSaldoInfo;
        private System.Windows.Forms.GroupBox Informacoes;
        private System.Windows.Forms.PictureBox picBanner;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtValor = new System.Windows.Forms.TextBox();
            this.txtMensagem = new System.Windows.Forms.TextBox();
            this.Operacoes = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSacar = new System.Windows.Forms.Button();
            this.btnDepositar = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblNotasInfo = new System.Windows.Forms.Label();
            this.lblSaldoInfo = new System.Windows.Forms.Label();
            this.Informacoes = new System.Windows.Forms.GroupBox();
            this.buttonLimpar = new System.Windows.Forms.Button();
            this.btnComprovante = new System.Windows.Forms.Button();
            this.picBanner = new System.Windows.Forms.PictureBox();
            this.Operacoes.SuspendLayout();
            this.Informacoes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBanner)).BeginInit();
            this.SuspendLayout();
            // 
            // txtValor
            // 
            this.txtValor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtValor.Location = new System.Drawing.Point(22, 76);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(175, 27);
            this.txtValor.TabIndex = 2;
            // 
            // txtMensagem
            // 
            this.txtMensagem.BackColor = System.Drawing.Color.White;
            this.txtMensagem.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.txtMensagem.Location = new System.Drawing.Point(10, 281);
            this.txtMensagem.Multiline = true;
            this.txtMensagem.Name = "txtMensagem";
            this.txtMensagem.ReadOnly = true;
            this.txtMensagem.Size = new System.Drawing.Size(307, 125);
            this.txtMensagem.TabIndex = 5;
            // 
            // Operacoes
            // 
            this.Operacoes.BackColor = System.Drawing.Color.Gainsboro;
            this.Operacoes.Controls.Add(this.label1);
            this.Operacoes.Controls.Add(this.txtValor);
            this.Operacoes.Controls.Add(this.txtMensagem);
            this.Operacoes.Controls.Add(this.btnSacar);
            this.Operacoes.Controls.Add(this.btnDepositar);
            this.Operacoes.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold);
            this.Operacoes.Location = new System.Drawing.Point(47, 152);
            this.Operacoes.Name = "Operacoes";
            this.Operacoes.Size = new System.Drawing.Size(330, 420);
            this.Operacoes.TabIndex = 6;
            this.Operacoes.TabStop = false;
            this.Operacoes.Text = "Operações";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(22, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 23);
            this.label1.TabIndex = 5;
            this.label1.Text = "Digite o Valor";
            // 
            // btnSacar
            // 
            this.btnSacar.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnSacar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSacar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold);
            this.btnSacar.Image = global::CaixaEletronico.Properties.Resources.sacar;
            this.btnSacar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSacar.Location = new System.Drawing.Point(23, 200);
            this.btnSacar.Name = "btnSacar";
            this.btnSacar.Size = new System.Drawing.Size(125, 64);
            this.btnSacar.TabIndex = 3;
            this.btnSacar.Text = "Sacar";
            this.btnSacar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSacar.UseVisualStyleBackColor = false;
            this.btnSacar.Click += new System.EventHandler(this.btnSacar_Click);
            // 
            // btnDepositar
            // 
            this.btnDepositar.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnDepositar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDepositar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold);
            this.btnDepositar.Image = global::CaixaEletronico.Properties.Resources.depositar;
            this.btnDepositar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDepositar.Location = new System.Drawing.Point(173, 200);
            this.btnDepositar.Name = "btnDepositar";
            this.btnDepositar.Size = new System.Drawing.Size(125, 64);
            this.btnDepositar.TabIndex = 4;
            this.btnDepositar.Text = "Depositar";
            this.btnDepositar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDepositar.UseVisualStyleBackColor = false;
            this.btnDepositar.Click += new System.EventHandler(this.btnDepositar_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.textBox1.Location = new System.Drawing.Point(7, 281);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(308, 125);
            this.textBox1.TabIndex = 6;
            // 
            // lblNotasInfo
            // 
            this.lblNotasInfo.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.lblNotasInfo.ForeColor = System.Drawing.Color.Black;
            this.lblNotasInfo.Location = new System.Drawing.Point(10, 60);
            this.lblNotasInfo.Name = "lblNotasInfo";
            this.lblNotasInfo.Size = new System.Drawing.Size(280, 110);
            this.lblNotasInfo.TabIndex = 1;
            this.lblNotasInfo.Text = "Notas disponíveis:\n100: 20 notas \n50: 20 notas \n20: 25 notas \n10: 30 notas";
            // 
            // lblSaldoInfo
            // 
            this.lblSaldoInfo.AutoSize = true;
            this.lblSaldoInfo.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.lblSaldoInfo.ForeColor = System.Drawing.Color.Black;
            this.lblSaldoInfo.Location = new System.Drawing.Point(10, 35);
            this.lblSaldoInfo.Name = "lblSaldoInfo";
            this.lblSaldoInfo.Size = new System.Drawing.Size(134, 19);
            this.lblSaldoInfo.TabIndex = 0;
            this.lblSaldoInfo.Text = "Saldo atual: R$ 0,00";
            this.lblSaldoInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Informacoes
            // 
            this.Informacoes.BackColor = System.Drawing.Color.Gainsboro;
            this.Informacoes.Controls.Add(this.buttonLimpar);
            this.Informacoes.Controls.Add(this.lblSaldoInfo);
            this.Informacoes.Controls.Add(this.lblNotasInfo);
            this.Informacoes.Controls.Add(this.btnComprovante);
            this.Informacoes.Controls.Add(this.textBox1);
            this.Informacoes.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold);
            this.Informacoes.Location = new System.Drawing.Point(463, 152);
            this.Informacoes.Name = "Informacoes";
            this.Informacoes.Size = new System.Drawing.Size(330, 420);
            this.Informacoes.TabIndex = 7;
            this.Informacoes.TabStop = false;
            this.Informacoes.Text = "Informações";
            // 
            // buttonLimpar
            // 
            this.buttonLimpar.BackColor = System.Drawing.Color.LightSlateGray;
            this.buttonLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold);
            this.buttonLimpar.Image = global::CaixaEletronico.Properties.Resources.vassouraIcon;
            this.buttonLimpar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonLimpar.Location = new System.Drawing.Point(164, 205);
            this.buttonLimpar.Name = "buttonLimpar";
            this.buttonLimpar.Size = new System.Drawing.Size(144, 70);
            this.buttonLimpar.TabIndex = 8;
            this.buttonLimpar.Text = "Limpar Informações";
            this.buttonLimpar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonLimpar.UseVisualStyleBackColor = false;
            this.buttonLimpar.Click += new System.EventHandler(this.buttonLimpar_Click);
            // 
            // btnComprovante
            // 
            this.btnComprovante.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnComprovante.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnComprovante.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold);
            this.btnComprovante.Image = global::CaixaEletronico.Properties.Resources.comprovante;
            this.btnComprovante.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnComprovante.Location = new System.Drawing.Point(14, 205);
            this.btnComprovante.Name = "btnComprovante";
            this.btnComprovante.Size = new System.Drawing.Size(144, 70);
            this.btnComprovante.TabIndex = 7;
            this.btnComprovante.Text = "Imprimir comprovante";
            this.btnComprovante.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnComprovante.UseVisualStyleBackColor = false;
            this.btnComprovante.Click += new System.EventHandler(this.btnComprovante_Click);
            // 
            // picBanner
            // 
            this.picBanner.Image = global::CaixaEletronico.Properties.Resources.banner_banco;
            this.picBanner.Location = new System.Drawing.Point(139, -20);
            this.picBanner.Name = "picBanner";
            this.picBanner.Size = new System.Drawing.Size(538, 229);
            this.picBanner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBanner.TabIndex = 8;
            this.picBanner.TabStop = false;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(825, 576);
            this.Controls.Add(this.Informacoes);
            this.Controls.Add(this.Operacoes);
            this.Controls.Add(this.picBanner);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Caixa do Patrão – Só Saque Alto";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Operacoes.ResumeLayout(false);
            this.Operacoes.PerformLayout();
            this.Informacoes.ResumeLayout(false);
            this.Informacoes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBanner)).EndInit();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Button buttonLimpar;
    }
}


