
using EstoqueProdutos.model;
using EstoqueProdutos.model.db;
using System.Data;
using System.Data.SqlClient;

namespace EstoqueProdutos
{
    public partial class Form1 : Form {
        SqlDataReader reader;
        SqlDataAdapter adpater;
        DataTable DataTable;
        SqlCommand cmd;
        string query;
        public Form1() {
            InitializeComponent();
        }

        private void txtQunatidade_MouseUp(object sender, MouseEventArgs e) {

        }

        private void Form1_Load(object sender, EventArgs e) {
            BDOperacoes.TrazendoCategoria(cbCategoria);
        }

        private void btnCadastra_Click(object sender, EventArgs e) {
            BDOperacoes.InserirDadosTable(txtNome, txtValor, dtValidade, txtQuantidade, cbCategoria);
        }

        private void btnAddcategoria_Click(object sender, EventArgs e) {
            Produtos.AddCategoria(txtAddCategoria, cbCategoria);
        }

        private void txtValor_KeyPress(object sender, KeyPressEventArgs e) {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ',') {
                // Se não for um desses, cancela a entrada
                e.Handled = true;
            }
            else if (e.KeyChar == ',' && txtValor.Text.Contains(",")) {
                // Impede a entrada de mais de uma vírgula
                e.Handled = true;
            }
            else if (txtValor.Text.Contains(",")) {
                // Verifica se já existe uma vírgula e impede mais de duas casas decimais
                string[] parts = txtValor.Text.Split(',');
                if (parts.Length > 1 && parts[1].Length >= 2 && !char.IsControl(e.KeyChar)) {
                    // Impede a entrada se já houver duas casas decimais
                    e.Handled = true;
                }
            }
        }
        private void btnTrazendoTodosProdutos_Click(object sender, EventArgs e) {
            BDOperacoes.TrazendoTodosProdutos(lista);
        }

        private void txtQuantidade_KeyPress(object sender, KeyPressEventArgs e) {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ',') {
                // Se não for um desses, cancela a entrada
                e.Handled = true;
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e) {
            BDOperacoes.ExcluirDado(lista);
        }
    }
}
