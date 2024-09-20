
using EstoqueProdutos.model;
using EstoqueProdutos.model.db;
using System.Data;
using System.Data.SqlClient;

namespace EstoqueProdutos
{
    public partial class Form1 : Form {

        public Form1() {
            InitializeComponent();
        }

        private void txtQunatidade_MouseUp(object sender, MouseEventArgs e) {

        }

        private void Form1_Load(object sender, EventArgs e) {
            BDOperacoes.TrazendoCategoria(cbCategoria);
            BDOperacoes.TrazendoCategoria(cbBusca);

        }

        private void btnCadastra_Click(object sender, EventArgs e) {

            BDOperacoes.InserirDadosTable(txtNome, txtValor, dtValidade, txtQuantidade, cbCategoria, txtVenda, txtCompra);

        }

        private void btnAddcategoria_Click(object sender, EventArgs e) {
            Produtos.AddCategoria(txtAddCategoria, cbCategoria);
            txtAddCategoria.Text = "";
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
            if (lista.CurrentCell != null) {
                var valor = lista.CurrentCell.RowIndex;
                var cod = lista.Rows[valor].Cells["codProduto"].Value;
                BDOperacoes.ExcluirDado(cod.ToString());
                lista.Rows.Clear();
                cbBusca.Text = "";
            }

        }

        private void txtVenda_KeyPress(object sender, KeyPressEventArgs e) {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ',') {
                // Se não for um desses, cancela a entrada
                e.Handled = true;
            }
        }

        private void txtCompra_KeyPress(object sender, KeyPressEventArgs e) {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ',') {
                // Se não for um desses, cancela a entrada
                e.Handled = true;
            }
            else if (e.KeyChar == ',' && txtCompra.Text.Contains(",")) {
                // Impede a entrada de mais de uma vírgula
                e.Handled = true;
            }
            else if (txtCompra.Text.Contains(",")) {
                // Verifica se já existe uma vírgula e impede mais de duas casas decimais
                string[] parts = txtCompra.Text.Split(',');
                if (parts.Length > 1 && parts[1].Length >= 2 && !char.IsControl(e.KeyChar)) {
                    // Impede a entrada se já houver duas casas decimais
                    e.Handled = true;
                }
            }
        }

        private void cbBusca_SelectedIndexChanged(object sender, EventArgs e) {

            BDOperacoes.buscaCategoria(cbBusca, lista);

        }

        private void btnBuscaVendas_Click(object sender, EventArgs e) {
            if (!string.IsNullOrEmpty(txtVendaCodProduto.Text)) {
                BDOperacoes.TrazeTodosProdutosPorCodigo(listaVendas, txtVendaCodProduto);
            }
            else {
                MessageBox.Show("Informe o codigo do produto, o codigo do produto pode ser obtido na aba informação > e no botão mostra todos", "Aviso");

            }
        }

        private void btnAtualizaQuantidade_Click(object sender, EventArgs e) {
            if (!string.IsNullOrEmpty(txtVendidosUp.Text)) {
                BDOperacoes.VendaProduto(txtVendaCodProduto, txtVendidosUp);
                txtVendidosUp.Text = "";
            }
            else {
                MessageBox.Show("Informe a quantidade, se for 0 informe");
            }
            
        }
    }
}
