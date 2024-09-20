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
            label9 = new Label();
            label8 = new Label();
            txtCompra = new TextBox();
            txtVenda = new TextBox();
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
            listaVendas = new DataGridView();
            label17 = new Label();
            txtVendidosUp = new TextBox();
            label15 = new Label();
            txtNumericoPorcetagemUp = new NumericUpDown();
            label13 = new Label();
            txtVendaCodProduto = new TextBox();
            tabPage3 = new TabPage();
            label7 = new Label();
            cbBusca = new ComboBox();
            btnExcluir = new Button();
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
            tabPage4 = new TabPage();
            labelQuantidadeVendida = new Label();
            label16 = new Label();
            labelSomaTotal = new Label();
            label14 = new Label();
            labelTotalGasto = new Label();
            label11 = new Label();
            label12 = new Label();
            labelTotalProduto = new Label();
            InformacaoCategoria = new ToolTip(components);
            toolTip2 = new ToolTip(components);
            Desconto = new ToolTip(components);
            btnBuscaVendas = new Button();
            btnAtualizaQuantidade = new Button();
            btnAtualizaporcetagem = new Button();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            panel1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)listaVendas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtNumericoPorcetagemUp).BeginInit();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)lista).BeginInit();
            tabPage4.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(986, 561);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(label9);
            tabPage1.Controls.Add(label8);
            tabPage1.Controls.Add(txtCompra);
            tabPage1.Controls.Add(txtVenda);
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
            tabPage1.Size = new Size(978, 523);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Adiciona Produto";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(359, 237);
            label9.Name = "label9";
            label9.Size = new Size(121, 25);
            label9.TabIndex = 15;
            label9.Text = "Valor Compra";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(358, 158);
            label8.Name = "label8";
            label8.Size = new Size(170, 25);
            label8.TabIndex = 14;
            label8.Text = "Porcentagem Venda";
            // 
            // txtCompra
            // 
            txtCompra.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            txtCompra.Location = new Point(359, 265);
            txtCompra.Name = "txtCompra";
            txtCompra.Size = new Size(233, 37);
            txtCompra.TabIndex = 13;
            txtCompra.KeyPress += txtCompra_KeyPress;
            // 
            // txtVenda
            // 
            txtVenda.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            txtVenda.Location = new Point(359, 192);
            txtVenda.Name = "txtVenda";
            txtVenda.Size = new Size(233, 37);
            txtVenda.TabIndex = 12;
            txtVenda.KeyPress += txtVenda_KeyPress;
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
            tabPage2.Controls.Add(btnAtualizaporcetagem);
            tabPage2.Controls.Add(btnAtualizaQuantidade);
            tabPage2.Controls.Add(btnBuscaVendas);
            tabPage2.Controls.Add(listaVendas);
            tabPage2.Controls.Add(label17);
            tabPage2.Controls.Add(txtVendidosUp);
            tabPage2.Controls.Add(label15);
            tabPage2.Controls.Add(txtNumericoPorcetagemUp);
            tabPage2.Controls.Add(label13);
            tabPage2.Controls.Add(txtVendaCodProduto);
            tabPage2.Location = new Point(4, 34);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(978, 523);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Vendas";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // listaVendas
            // 
            listaVendas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            listaVendas.Dock = DockStyle.Bottom;
            listaVendas.Location = new Point(3, 77);
            listaVendas.Name = "listaVendas";
            listaVendas.RowHeadersWidth = 62;
            listaVendas.Size = new Size(972, 443);
            listaVendas.TabIndex = 7;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(331, 11);
            label17.Name = "label17";
            label17.Size = new Size(174, 25);
            label17.TabIndex = 6;
            label17.Text = "Quantidade Vendida";
            // 
            // txtVendidosUp
            // 
            txtVendidosUp.Location = new Point(331, 40);
            txtVendidosUp.Name = "txtVendidosUp";
            txtVendidosUp.Size = new Size(178, 31);
            txtVendidosUp.TabIndex = 5;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(666, 9);
            label15.Name = "label15";
            label15.Size = new Size(106, 25);
            label15.TabIndex = 4;
            label15.Text = "Porcetagem";
            // 
            // txtNumericoPorcetagemUp
            // 
            txtNumericoPorcetagemUp.Location = new Point(666, 37);
            txtNumericoPorcetagemUp.Name = "txtNumericoPorcetagemUp";
            txtNumericoPorcetagemUp.Size = new Size(180, 31);
            txtNumericoPorcetagemUp.TabIndex = 3;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(8, 12);
            label13.Name = "label13";
            label13.Size = new Size(141, 25);
            label13.TabIndex = 1;
            label13.Text = "Codigo Produto";
            // 
            // txtVendaCodProduto
            // 
            txtVendaCodProduto.Location = new Point(8, 40);
            txtVendaCodProduto.Name = "txtVendaCodProduto";
            txtVendaCodProduto.Size = new Size(150, 31);
            txtVendaCodProduto.TabIndex = 0;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(label7);
            tabPage3.Controls.Add(cbBusca);
            tabPage3.Controls.Add(btnExcluir);
            tabPage3.Controls.Add(lista);
            tabPage3.Controls.Add(btnTrazendoTodosProdutos);
            tabPage3.Controls.Add(label10);
            tabPage3.Controls.Add(textBox4);
            tabPage3.Location = new Point(4, 34);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(978, 523);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Informaçoes";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(257, 14);
            label7.Name = "label7";
            label7.Size = new Size(171, 25);
            label7.TabIndex = 7;
            label7.Text = "Busca por Categoria";
            // 
            // cbBusca
            // 
            cbBusca.FormattingEnabled = true;
            cbBusca.Location = new Point(257, 43);
            cbBusca.Name = "cbBusca";
            cbBusca.Size = new Size(182, 33);
            cbBusca.TabIndex = 6;
            cbBusca.SelectedIndexChanged += cbBusca_SelectedIndexChanged;
            // 
            // btnExcluir
            // 
            btnExcluir.Location = new Point(829, 39);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(141, 34);
            btnExcluir.TabIndex = 5;
            btnExcluir.Text = "Excluir ";
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // lista
            // 
            lista.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            lista.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            lista.BackgroundColor = SystemColors.ButtonHighlight;
            lista.ColumnHeadersHeight = 50;
            lista.Columns.AddRange(new DataGridViewColumn[] { nome, valor, validade, quantidade, categoria, codProduto });
            lista.Location = new Point(0, 82);
            lista.Name = "lista";
            lista.RowHeadersWidth = 62;
            lista.RowTemplate.Height = 50;
            lista.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            lista.Size = new Size(978, 441);
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
            btnTrazendoTodosProdutos.Location = new Point(682, 39);
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
            // tabPage4
            // 
            tabPage4.Controls.Add(labelQuantidadeVendida);
            tabPage4.Controls.Add(label16);
            tabPage4.Controls.Add(labelSomaTotal);
            tabPage4.Controls.Add(label14);
            tabPage4.Controls.Add(labelTotalGasto);
            tabPage4.Controls.Add(label11);
            tabPage4.Controls.Add(label12);
            tabPage4.Controls.Add(labelTotalProduto);
            tabPage4.Location = new Point(4, 34);
            tabPage4.Name = "tabPage4";
            tabPage4.Size = new Size(978, 523);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Relatorio";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // labelQuantidadeVendida
            // 
            labelQuantidadeVendida.AutoSize = true;
            labelQuantidadeVendida.Font = new Font("Segoe UI", 24F);
            labelQuantidadeVendida.Location = new Point(341, 64);
            labelQuantidadeVendida.Name = "labelQuantidadeVendida";
            labelQuantidadeVendida.Size = new Size(54, 65);
            labelQuantidadeVendida.TabIndex = 7;
            labelQuantidadeVendida.Text = "0";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(290, 39);
            label16.Name = "label16";
            label16.Size = new Size(174, 25);
            label16.TabIndex = 6;
            label16.Text = "Quantidade Vendida";
            // 
            // labelSomaTotal
            // 
            labelSomaTotal.AutoSize = true;
            labelSomaTotal.Font = new Font("Segoe UI", 24F);
            labelSomaTotal.Location = new Point(135, 389);
            labelSomaTotal.Name = "labelSomaTotal";
            labelSomaTotal.Size = new Size(54, 65);
            labelSomaTotal.TabIndex = 5;
            labelSomaTotal.Text = "0";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(75, 332);
            label14.Name = "label14";
            label14.Size = new Size(178, 25);
            label14.TabIndex = 4;
            label14.Text = "Soma Total Produtos";
            // 
            // labelTotalGasto
            // 
            labelTotalGasto.AutoSize = true;
            labelTotalGasto.Font = new Font("Segoe UI", 24F);
            labelTotalGasto.Location = new Point(135, 217);
            labelTotalGasto.Name = "labelTotalGasto";
            labelTotalGasto.Size = new Size(54, 65);
            labelTotalGasto.TabIndex = 3;
            labelTotalGasto.Text = "0";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(91, 177);
            label11.Name = "label11";
            label11.Size = new Size(144, 25);
            label11.TabIndex = 2;
            label11.Text = "Valor gasto Total";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(91, 39);
            label12.Name = "label12";
            label12.Size = new Size(152, 25);
            label12.TabIndex = 1;
            label12.Text = "Total de Produtos";
            // 
            // labelTotalProduto
            // 
            labelTotalProduto.AutoSize = true;
            labelTotalProduto.Font = new Font("Segoe UI", 24F);
            labelTotalProduto.Location = new Point(135, 64);
            labelTotalProduto.Name = "labelTotalProduto";
            labelTotalProduto.Size = new Size(54, 65);
            labelTotalProduto.TabIndex = 0;
            labelTotalProduto.Text = "0";
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
            // btnBuscaVendas
            // 
            btnBuscaVendas.Location = new Point(164, 37);
            btnBuscaVendas.Name = "btnBuscaVendas";
            btnBuscaVendas.Size = new Size(112, 34);
            btnBuscaVendas.TabIndex = 8;
            btnBuscaVendas.Text = "Buscar";
            btnBuscaVendas.UseVisualStyleBackColor = true;
            // 
            // btnAtualizaQuantidade
            // 
            btnAtualizaQuantidade.Location = new Point(515, 38);
            btnAtualizaQuantidade.Name = "btnAtualizaQuantidade";
            btnAtualizaQuantidade.Size = new Size(112, 34);
            btnAtualizaQuantidade.TabIndex = 9;
            btnAtualizaQuantidade.Text = "Atualizar";
            btnAtualizaQuantidade.UseVisualStyleBackColor = true;
            // 
            // btnAtualizaporcetagem
            // 
            btnAtualizaporcetagem.Location = new Point(852, 34);
            btnAtualizaporcetagem.Name = "btnAtualizaporcetagem";
            btnAtualizaporcetagem.Size = new Size(112, 34);
            btnAtualizaporcetagem.TabIndex = 10;
            btnAtualizaporcetagem.Text = "Atualizar";
            btnAtualizaporcetagem.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(986, 561);
            Controls.Add(tabControl1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Produtos";
            InformacaoCategoria.SetToolTip(this, "É importante coloca uma categoria coerênte para fazer uma busca por informação mais relevante");
            Load += Form1_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)listaVendas).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtNumericoPorcetagemUp).EndInit();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)lista).EndInit();
            tabPage4.ResumeLayout(false);
            tabPage4.PerformLayout();
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
        private ToolTip Desconto;
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
        private ComboBox cbBusca;
        private Label label7;
        private Label label8;
        private TextBox txtCompra;
        private TextBox txtVenda;
        private Label label9;
        private TabPage tabPage4;
        private Label label16;
        private Label labelSomaTotal;
        private Label label14;
        private Label labelTotalGasto;
        private Label label11;
        private Label label12;
        private Label labelTotalProduto;
        private Label labelQuantidadeVendida;
        private Label label13;
        private TextBox txtVendaCodProduto;
        private Label label15;
        private NumericUpDown txtNumericoPorcetagemUp;
        private Label label17;
        private TextBox txtVendidosUp;
        private DataGridView listaVendas;
        private Button btnAtualizaporcetagem;
        private Button btnAtualizaQuantidade;
        private Button btnBuscaVendas;
    }
}
