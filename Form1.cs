using System;
using System.Drawing; // importante para Color
using System.Globalization;
using System.IO;
using System.Windows.Forms;


namespace CaixaEletronico
{
    public partial class Form1 : Form
    {
        // Saldo inicial do usuário
        decimal saldo = 1000m;

        // Quantidade de notas no caixa
        int notas100 = 20;
        int notas50 = 20;
        int notas20 = 25;
        int notas10 = 30;

        // Caminho do último comprovante
        private string ultimoComprovante = "";

        public Form1()
        {
            InitializeComponent();
            AtualizarInterface();

            // Aplicar estilo visual minimalista
            this.BackColor = Color.WhiteSmoke;
            this.Font = new Font("Segoe UI", 10);

            btnSacar.FlatStyle = FlatStyle.Flat;
            btnDepositar.FlatStyle = FlatStyle.Flat;
            btnComprovante.FlatStyle = FlatStyle.Flat;

            btnSacar.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            btnDepositar.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            btnComprovante.Font = new Font("Segoe UI", 9, FontStyle.Bold);

            Operacoes.BackColor = Color.White;
            Informacoes.BackColor = Color.Gainsboro;

            // Agora corretamente aplicado ao controle, não ao texto
            lblSaldoInfo.ForeColor = Color.DarkSlateGray;
            lblNotasInfo.ForeColor = Color.DarkSlateGray;
            label1.ForeColor = Color.DarkSlateGray;
        }

        // Botão Depositar
        private void btnDepositar_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtValor.Text, out decimal valor) && valor > 0 && valor % 10 == 0)
            {
                saldo += valor;
                txtMensagem.Text = $"Depósito de R$ {valor.ToString("N2", new CultureInfo("pt-BR"))} realizado com sucesso.";
                textBox1.Text = $"Última operação: Depósito de R$ {valor.ToString("N2", new CultureInfo("pt-BR"))}";
                AtualizarInterface();
            }
            else
            {
                txtMensagem.Text = "Valor inválido. Digite um valor positivo e múltiplo de 10.";
            }
        }

        // Botão Sacar
        private void btnSacar_Click(object sender, EventArgs e)
        {
            if (!decimal.TryParse(txtValor.Text, out decimal valor) || valor <= 0 || valor % 10 != 0)
            {
                txtMensagem.Text = "Valor inválido. Digite um valor positivo e múltiplo de 10.";
                return;
            }

            if (valor > saldo)
            {
                txtMensagem.Text = "Saldo insuficiente.";
                return;
            }

            if (valor > 5000)
            {
                txtMensagem.Text = "Limite de saque excedido. Máximo R$ 5.000 por operação.";
                return;
            }

            int restante = (int)valor;
            int n100 = Math.Min(restante / 100, notas100); restante -= n100 * 100;
            int n50 = Math.Min(restante / 50, notas50); restante -= n50 * 50;
            int n20 = Math.Min(restante / 20, notas20); restante -= n20 * 20;
            int n10 = Math.Min(restante / 10, notas10); restante -= n10 * 10;

            if (restante == 0)
            {
                saldo -= valor;
                notas100 -= n100;
                notas50 -= n50;
                notas20 -= n20;
                notas10 -= n10;

                txtMensagem.Text = $"Saque de R$ {valor.ToString("N2", new CultureInfo("pt-BR"))} realizado com sucesso.\n" +
                                   $"Notas entregues:\n100: {n100}, 50: {n50}, 20: {n20}, 10: {n10}";

                textBox1.Text = $"Última operação: Saque de R$ {valor.ToString("N2", new CultureInfo("pt-BR"))}\nNotas: 100x{n100}, 50x{n50}, 20x{n20}, 10x{n10}";
                GerarComprovante(valor, n100, n50, n20, n10);
                AtualizarInterface();
            }
            else
            {
                txtMensagem.Text = "Não há notas suficientes para esse saque.";
            }
        }

        // Atualizar informações visuais
        private void AtualizarInterface()
        {
            lblSaldoInfo.Text = $"Saldo atual: R$ {saldo.ToString("N2", new CultureInfo("pt-BR"))}";
            lblNotasInfo.Text = $"Notas disponíveis:\n100: {notas100} | 50: {notas50} | 20: {notas20} | 10: {notas10}";
        }

        // Gera arquivo .txt com o comprovante
        private void GerarComprovante(decimal valor, int n100, int n50, int n20, int n10)
        {
            string nomeArquivo = $"comprovante_{DateTime.Now:yyyyMMdd_HHmmss}.txt";

            using (StreamWriter sw = new StreamWriter(nomeArquivo))
            {
                sw.WriteLine("Comprovante de Saque - Banco do Patrão");
                sw.WriteLine();
                sw.WriteLine($"Data/Hora: {DateTime.Now:dd/MM/yyyy HH:mm}");
                sw.WriteLine($"Valor solicitado: R$ {valor.ToString("N2", new CultureInfo("pt-BR"))}");
                sw.WriteLine();
                sw.WriteLine("Notas entregues:");
                if (n100 > 0) sw.WriteLine($"- {n100} x R$ 100");
                if (n50 > 0) sw.WriteLine($"- {n50} x R$ 50");
                if (n20 > 0) sw.WriteLine($"- {n20} x R$ 20");
                if (n10 > 0) sw.WriteLine($"- {n10} x R$ 10");
                sw.WriteLine();
                sw.WriteLine($"Saldo restante: R$ {saldo.ToString("N2", new CultureInfo("pt-BR"))}");
                sw.WriteLine();
                sw.WriteLine("Obrigado por utilizar nosso banco! Seja feliz, estribado(a)!");
            }

            ultimoComprovante = nomeArquivo;
        }

        // Ação do botão "Imprimir comprovante"
        private void btnComprovante_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(ultimoComprovante) && File.Exists(ultimoComprovante))
            {
                System.Diagnostics.Process.Start("notepad.exe", ultimoComprovante);
            }
            else
            {
                MessageBox.Show("Nenhum comprovante encontrado ainda.", "Aviso");
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e) { }
        private void label1_Click(object sender, EventArgs e) { }

        private void lblTitulo_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
