namespace EstoqueProdutos
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
        private void InitializeComponent() {
            components = new System.ComponentModel.Container();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            panel2 = new Panel();
            txtDesconto = new TextBox();
            label9 = new Label();
            txtxAcrescimo = new TextBox();
            label8 = new Label();
            label7 = new Label();
            panel1 = new Panel();
            btnAddcategoria = new Button();
            txtAddCategoria = new TextBox();
            label6 = new Label();
            btnCadastra = new Button();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            cbCategoria = new ComboBox();
            txtQuantidade = new TextBox();
            dtValidade = new DateTimePicker();
            txtValor = new TextBox();
            txtNome = new TextBox();
            tabPage2 = new TabPage();
            tabPage3 = new TabPage();
            lista = new DataGridView();
            nome = new DataGridViewTextBoxColumn();
            valor = new DataGridViewTextBoxColumn();
            validade = new DataGridViewTextBoxColumn();
            quantidade = new DataGridViewTextBoxColumn();
            categoria = new DataGridViewTextBoxColumn();
            codProduto = new DataGridViewTextBoxColumn();
            btnTrazendoTodosProdutos = new Button();
            label10 = new Label();
            textBox4 = new TextBox();
            InformacaoCategoria = new ToolTip(components);
            toolTip2 = new ToolTip(components);
            Desconto = new ToolTip(components);
            btnExcluir = new Button();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)lista).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(805, 561);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(panel2);
            tabPage1.Controls.Add(panel1);
            tabPage1.Controls.Add(btnCadastra);
            tabPage1.Controls.Add(label5);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(cbCategoria);
            tabPage1.Controls.Add(txtQuantidade);
            tabPage1.Controls.Add(dtValidade);
            tabPage1.Controls.Add(txtValor);
            tabPage1.Controls.Add(txtNome);
            tabPage1.Location = new Point(4, 34);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(797, 523);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Adiciona Produto";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.Controls.Add(txtDesconto);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(txtxAcrescimo);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label7);
            panel2.Location = new Point(358, 162);
            panel2.Name = "panel2";
            panel2.Size = new Size(428, 217);
            panel2.TabIndex = 12;
            // 
            // txtDesconto
            // 
            txtDesconto.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            txtDesconto.Location = new Point(6, 151);
            txtDesconto.Name = "txtDesconto";
            txtDesconto.Size = new Size(233, 37);
            txtDesconto.TabIndex = 15;
            Desconto.SetToolTip(txtDesconto, "Se houver disconto, caso não, deixe em branco");
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(6, 120);
            label9.Name = "label9";
            label9.Size = new Size(190, 25);
            label9.TabIndex = 14;
            label9.Text = "Desconto Por Unidade";
            // 
            // txtxAcrescimo
            // 
            txtxAcrescimo.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            txtxAcrescimo.Location = new Point(4, 75);
            txtxAcrescimo.Name = "txtxAcrescimo";
            txtxAcrescimo.Size = new Size(233, 37);
            txtxAcrescimo.TabIndex = 13;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(4, 42);
            label8.Margin = new Padding(5, 5, 3, 0);
            label8.Name = "label8";
            label8.Size = new Size(196, 25);
            label8.TabIndex = 13;
            label8.Text = "Acrescimo Por Unidade";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label7.Location = new Point(4, 4);
            label7.Name = "label7";
            label7.Size = new Size(268, 32);
            label7.TabIndex = 0;
            label7.Text = "Informação de vendas";
            // 
            // panel1
            // 
            panel1.Controls.Add(btnAddcategoria);
            panel1.Controls.Add(txtAddCategoria);
            panel1.Controls.Add(label6);
            panel1.Location = new Point(356, 13);
            panel1.Name = "panel1";
            panel1.Size = new Size(433, 128);
            panel1.TabIndex = 11;
            // 
            // btnAddcategoria
            // 
            btnAddcategoria.Location = new Point(3, 73);
            btnAddcategoria.Name = "btnAddcategoria";
            btnAddcategoria.Size = new Size(112, 34);
            btnAddcategoria.TabIndex = 2;
            btnAddcategoria.Text = "Adicionar";
            btnAddcategoria.UseVisualStyleBackColor = true;
            btnAddcategoria.Click += btnAddcategoria_Click;
            // 
            // txtAddCategoria
            // 
            txtAddCategoria.Location = new Point(3, 28);
            txtAddCategoria.Name = "txtAddCategoria";
            txtAddCategoria.Size = new Size(269, 31);
            txtAddCategoria.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label6.Location = new Point(3, 0);
            label6.Name = "label6";
            label6.Size = new Size(286, 32);
            label6.TabIndex = 0;
            label6.Text = "Adiciona uma categoria";
            // 
            // btnCadastra
            // 
            btnCadastra.Location = new Point(321, 446);
            btnCadastra.Name = "btnCadastra";
            btnCadastra.Size = new Size(151, 49);
            btnCadastra.TabIndex = 10;
            btnCadastra.Text = "Cadastrar";
            btnCadastra.UseVisualStyleBackColor = true;
            btnCadastra.Click += btnCadastra_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(14, 320);
            label5.Margin = new Padding(5, 5, 3, 0);
            label5.Name = "label5";
            label5.Size = new Size(88, 25);
            label5.TabIndex = 9;
            label5.Text = "Categoria";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(14, 237);
            label4.Margin = new Padding(5, 5, 3, 0);
            label4.Name = "label4";
            label4.Size = new Size(105, 25);
            label4.TabIndex = 8;
            label4.Text = "Quantidade";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(14, 164);
            label3.Margin = new Padding(5, 5, 3, 0);
            label3.Name = "label3";
            label3.Size = new Size(121, 25);
            label3.TabIndex = 7;
            label3.Text = "Data Validade";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 91);
            label2.Margin = new Padding(5, 5, 3, 0);
            label2.Name = "label2";
            label2.Size = new Size(152, 25);
            label2.TabIndex = 6;
            label2.Text = "Valor Por unidade";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 13);
            label1.Name = "label1";
            label1.Size = new Size(159, 25);
            label1.TabIndex = 5;
            label1.Text = "Nome do produto";
            // 
            // cbCategoria
            // 
            cbCategoria.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            cbCategoria.FormattingEnabled = true;
            cbCategoria.Location = new Point(14, 348);
            cbCategoria.Name = "cbCategoria";
            cbCategoria.Size = new Size(240, 38);
            cbCategoria.TabIndex = 4;
            // 
            // txtQuantidade
            // 
            txtQuantidade.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            txtQuantidade.Location = new Point(14, 265);
            txtQuantidade.Name = "txtQuantidade";
            txtQuantidade.Size = new Size(234, 37);
            txtQuantidade.TabIndex = 3;
            txtQuantidade.KeyPress += txtQuantidade_KeyPress;
            // 
            // dtValidade
            // 
            dtValidade.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            dtValidade.Format = DateTimePickerFormat.Short;
            dtValidade.Location = new Point(14, 192);
            dtValidade.Name = "dtValidade";
            dtValidade.Size = new Size(234, 37);
            dtValidade.TabIndex = 2;
            // 
            // txtValor
            // 
            txtValor.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            txtValor.Location = new Point(14, 119);
            txtValor.Name = "txtValor";
            txtValor.Size = new Size(233, 37);
            txtValor.TabIndex = 1;
            txtValor.KeyPress += txtValor_KeyPress;
            txtValor.MouseUp += txtQunatidade_MouseUp;
            // 
            // txtNome
            // 
            txtNome.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            txtNome.Location = new Point(14, 46);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(234, 37);
            txtNome.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 34);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(797, 523);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Vendas";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(btnExcluir);
            tabPage3.Controls.Add(lista);
            tabPage3.Controls.Add(btnTrazendoTodosProdutos);
            tabPage3.Controls.Add(label10);
            tabPage3.Controls.Add(textBox4);
            tabPage3.Location = new Point(4, 34);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(797, 523);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Informaçoes";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // lista
            // 
            lista.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            lista.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            lista.BackgroundColor = SystemColors.ButtonHighlight;
            lista.ColumnHeadersHeight = 50;
            lista.Columns.AddRange(new DataGridViewColumn[] { nome, valor, validade, quantidade, categoria, codProduto });
            lista.Dock = DockStyle.Bottom;
            lista.Location = new Point(0, 130);
            lista.Name = "lista";
            lista.RowHeadersWidth = 62;
            lista.RowTemplate.Height = 50;
            lista.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            lista.Size = new Size(797, 393);
            lista.TabIndex = 4;
            // 
            // nome
            // 
            nome.HeaderText = "Nome";
            nome.MinimumWidth = 8;
            nome.Name = "nome";
            // 
            // valor
            // 
            valor.HeaderText = "ValorUnidade";
            valor.MinimumWidth = 8;
            valor.Name = "valor";
            // 
            // validade
            // 
            validade.HeaderText = "dataValidade";
            validade.MinimumWidth = 8;
            validade.Name = "validade";
            // 
            // quantidade
            // 
            quantidade.HeaderText = "Quantidade";
            quantidade.MinimumWidth = 8;
            quantidade.Name = "quantidade";
            // 
            // categoria
            // 
            categoria.HeaderText = "Categoria";
            categoria.MinimumWidth = 8;
            categoria.Name = "categoria";
            // 
            // codProduto
            // 
            codProduto.HeaderText = "CodigoProduto";
            codProduto.MinimumWidth = 8;
            codProduto.Name = "codProduto";
            // 
            // btnTrazendoTodosProdutos
            // 
            btnTrazendoTodosProdutos.Location = new Point(8, 90);
            btnTrazendoTodosProdutos.Name = "btnTrazendoTodosProdutos";
            btnTrazendoTodosProdutos.Size = new Size(141, 34);
            btnTrazendoTodosProdutos.TabIndex = 3;
            btnTrazendoTodosProdutos.Text = "Mostra Todos";
            btnTrazendoTodosProdutos.UseVisualStyleBackColor = true;
            btnTrazendoTodosProdutos.Click += btnTrazendoTodosProdutos_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(8, 14);
            label10.Name = "label10";
            label10.Size = new Size(141, 25);
            label10.TabIndex = 2;
            label10.Text = "Busca por nome";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(8, 42);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(232, 31);
            textBox4.TabIndex = 1;
            // 
            // InformacaoCategoria
            // 
            InformacaoCategoria.AutomaticDelay = 5000;
            InformacaoCategoria.AutoPopDelay = 50000;
            InformacaoCategoria.InitialDelay = 0;
            InformacaoCategoria.IsBalloon = true;
            InformacaoCategoria.ReshowDelay = 1000;
            InformacaoCategoria.ShowAlways = true;
            InformacaoCategoria.ToolTipIcon = ToolTipIcon.Info;
            InformacaoCategoria.ToolTipTitle = "Informação Qunatidade";
            // 
            // toolTip2
            // 
            toolTip2.AutomaticDelay = 5000;
            toolTip2.AutoPopDelay = 50000;
            toolTip2.InitialDelay = 0;
            toolTip2.IsBalloon = true;
            toolTip2.ReshowDelay = 1000;
            toolTip2.ShowAlways = true;
            toolTip2.ToolTipIcon = ToolTipIcon.Info;
            toolTip2.ToolTipTitle = "Informação Qunatidade";
            // 
            // Desconto
            // 
            Desconto.AutomaticDelay = 5000;
            Desconto.AutoPopDelay = 50000;
            Desconto.InitialDelay = 0;
            Desconto.IsBalloon = true;
            Desconto.ReshowDelay = 1000;
            Desconto.ShowAlways = true;
            Desconto.ToolTipIcon = ToolTipIcon.Info;
            Desconto.ToolTipTitle = "Informação Qunatidade";
            // 
            // btnExcluir
            // 
            btnExcluir.Location = new Point(648, 90);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(141, 34);
            btnExcluir.TabIndex = 5;
            btnExcluir.Text = "Excluir ";
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(805, 561);
            Controls.Add(tabControl1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Produtos";
            InformacaoCategoria.SetToolTip(this, "É importante coloca uma categoria coerênte para fazer uma busca por informação mais relevante");
            Load += Form1_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)lista).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TextBox txtNome;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private Label label2;
        private Label label1;
        private ComboBox cbCategoria;
        private TextBox txtQuantidade;
        private DateTimePicker dtValidade;
        private TextBox txtValor;
        private Label label4;
        private Label label3;
        private Label label5;
        private ToolTip InformacaoCategoria;
        private ToolTip toolTip2;
        private Button btnCadastra;
        private Panel panel2;
        private TextBox txtDesconto;
        private ToolTip Desconto;
        private Label label9;
        private TextBox txtxAcrescimo;
        private Label label8;
        private Label label7;
        private Panel panel1;
        private Button btnAddcategoria;
        private TextBox txtAddCategoria;
        private Label label6;
        private Button btnTrazendoTodosProdutos;
        private Label label10;
        private TextBox textBox4;
        private DataGridView lista;
        private DataGridViewTextBoxColumn nome;
        private DataGridViewTextBoxColumn valor;
        private DataGridViewTextBoxColumn validade;
        private DataGridViewTextBoxColumn quantidade;
        private DataGridViewTextBoxColumn categoria;
        private DataGridViewTextBoxColumn codProduto;
        private Button btnExcluir;
    }
}
