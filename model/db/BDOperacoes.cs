using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace EstoqueProdutos.model.db {
   internal partial class  BDOperacoes {

        private SqlDataAdapter DataAdapter;
        private static SqlCommand cmd;
        private static SqlDataReader reader;
        private static DataTable DataTable;
        private static SqlConnection con;
        private static string query;
        private static string Auxiliar;
        private static double AuxliarValores;

        private static Produtos produtos;

        public static string url = ConfigurationManager.ConnectionStrings["MinhaStringConexao"].ConnectionString;

        public static void InserirDadosTable(TextBox nome, DateTimePicker validade, TextBox quantidade, ComboBox categoria,TextBox valorVenda,TextBox valorCompra) {
            query = "INSERT INTO  PRODUTOS (nome,valorunidade,datavalidade,quantidade,categoria,codproduto,PORCETAGEM,valorcompra) values (" +
                "@nome,@valorunidade,@datavalidade,@quantidade,@categoria,@cod,@porcetagem,@comprar)";
            using (con = new SqlConnection(url)) {
                using (cmd = new SqlCommand(query, con)) {
                    try {
                        var vl = Produtos.ValorVendaPorcetagem( valorVenda,valorCompra);
                        con.Open();
                        produtos = Produtos.VerificandoCampos(nome, quantidade, categoria, validade,valorCompra,valorVenda);
                        cmd.Parameters.AddWithValue("@nome", produtos.Nome);
                        cmd.Parameters.AddWithValue("@valorunidade", vl);
                        cmd.Parameters.AddWithValue("@datavalidade", produtos.Validade);
                        cmd.Parameters.AddWithValue("@quantidade", produtos.Quantidade);
                        cmd.Parameters.AddWithValue("@categoria", produtos.Categoria);
                        cmd.Parameters.AddWithValue("@cod", produtos.CodigoProdutos);
                        cmd.Parameters.AddWithValue("@comprar", produtos.ValorComprar);
                        cmd.Parameters.AddWithValue("@porcetagem",valorVenda.Text);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Produto Inserido");

                    } catch (Exception ex) {
                        MessageBox.Show(ex.Message);

                    } finally {
                        nome.Text = "";
                       
                        quantidade.Text = "";
                        categoria.Text = "";
                        valorVenda.Text = "";
                        valorCompra.Text = "";
                    }
                }

            }
        }
        public static void TrazendoCategoria(ComboBox box) {
            query = "SELECT CATEGORIA FROM PRODUTOS";
            using (con = new SqlConnection(url)) {
                using (cmd = new SqlCommand(query, con)) {
                    try {
                        con.Open();
                        reader = cmd.ExecuteReader();
                        if (reader.Read()) {
                            for (int i = 0; i < reader.FieldCount; i++) {
                                box.Items.Add(reader.GetValue(i));
                            }
                        }


                    } catch (Exception ex) {
                        MessageBox.Show(ex.Message);
                    }

                }
            }
        }

        public static void TrazendoTodosProdutos(DataGridView lista) {
            query = "SELECT nome,datavalidade,quantidade,categoria,codproduto,valorcompra,Porcetagem,valorUnidade, (quantidade * valorunidade) SomasUnidades FROM PRODUTOS";
            using (con = new SqlConnection(url)) {
                using (cmd = new SqlCommand(query, con)) {
                    try {
                        con.Open();
                        reader = cmd.ExecuteReader();
                        object[] rows = new object[reader.FieldCount];
                        if (reader.HasRows) {

                            lista.Columns.Clear();
                            for (int i = 0; i < reader.FieldCount; i++) {
                                lista.Columns.Add(reader.GetName(i), reader.GetName(i));
                            }
                            while (reader.Read()) {
                                for (int i = 0; i < reader.FieldCount; i++) {
                                    rows[i] = reader.GetValue(i);
                                }
                                lista.Rows.Add(rows);
                            }

                        }
                    } catch(Exception ex) {
                        MessageBox.Show(ex.Message);    
                    }

                }
            }
        }

        public static void ExcluirDado(string cod) {
            query = "Delete from produtos where codproduto = @cod";
            using (con = new SqlConnection(url)) {
                using (cmd = new SqlCommand(query,con)) {
                    try{
                        con.Open();
                        cmd.Parameters.AddWithValue("@cod", cod);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Produto Excluido");
                    } catch (Exception ex) {
                        MessageBox.Show(ex.Message);
                    }
                    
                }
            }
        }

        public static void buscaCategoria(ComboBox bx, DataGridView lista) {
            query = "select nome,valorUnidade,quantidade,porcetagem,valorcompra from produtos where categoria = @cat";
            using(con = new SqlConnection(url)) {
                using(cmd = new SqlCommand(query,con)) {
                    try {
                        con.Open();
                        cmd.Parameters.AddWithValue("@cat", bx.Text);
                        reader = cmd.ExecuteReader();
                        object[] rows = new object[reader.FieldCount];
                        if (reader.HasRows) {

                            lista.Columns.Clear();
                            for (int i = 0; i < reader.FieldCount; i++) {
                                lista.Columns.Add(reader.GetName(i), reader.GetName(i));
                            }
                            while (reader.Read()) {
                                for (int i = 0; i < reader.FieldCount; i++) {
                                    rows[i] = reader.GetValue(i);
                                }
                                lista.Rows.Add(rows);
                            }

                        }

                    } catch (Exception ex) {
                        MessageBox.Show(ex.Message);
                    }
                } 
            }
        }

        public static void VendaProduto(TextBox cod,TextBox vendida) {
            query = " Update produtos set quantidade = @vendida where codProduto = @cod";
            using (con = new SqlConnection(url)) {
                using (cmd = new SqlCommand(query, con)) {
                    try {
                        con.Open();
                        if(Auxiliar == "") {
                            MessageBox.Show("Busque pelo codigo do produto");
                            return;
                        }
                        cmd.Parameters.AddWithValue("@cod", Auxiliar);
                        cmd.Parameters.AddWithValue("@vendida", vendida.Text);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Quantidade Atualizada");

                    }catch(Exception ex) {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        public static void TrazeTodosProdutosPorCodigo(DataGridView lista, TextBox cod) {
            query = "SELECT nome,valorUnidade,datavalidade,quantidade,categoria,codproduto,valorcompra,porcetagem,(quantidade * valorunidade) as SomaTotalProduto FROM PRODUTOS where codProduto = @cod";
            using (con = new SqlConnection(url)) {
                using (cmd = new SqlCommand(query, con)) {
                    try {
                        con.Open();
                        Auxiliar = cod.Text;
                        cmd.Parameters.AddWithValue("@cod",cod.Text);
                        reader = cmd.ExecuteReader();
                        
                        object[] rows = new object[reader.FieldCount];
                        if (reader.HasRows) {

                            lista.Columns.Clear();
                            for (int i = 0; i < reader.FieldCount; i++) {
                                lista.Columns.Add(reader.GetName(i), reader.GetName(i));
                            }
                            while (reader.Read()) {
                                for (int i = 0; i < reader.FieldCount; i++) {
                                    rows[i] = reader.GetValue(i);
                                }
                                lista.Rows.Add(rows);
                            }

                        }
                    } catch (Exception ex) {
                        MessageBox.Show(ex.Message);
                    }

                }
            }
        }

        public static void RelatorioTotalProdutos(Label text) {
            query = "select count(*) as Total from Produtos";
            using (con = new SqlConnection(url)) {
                using (cmd = new SqlCommand(query, con)) {
                    con.Open();
                    reader = cmd.ExecuteReader();
                    if (reader.Read()) {
                        string total = reader.GetValue(0).ToString();
                        if (text.InvokeRequired) {
                            text.Invoke(new Action(() => text.Text = total));
                        }
                        else {
                            text.Text = total;
                        }
                    }
                    else {
                        MessageBox.Show("Erro ao mostra a quantidade de produtos");
                    }
                    
                }
            }
        }

        public static void AtulizaPorcetagem(TextBox number) {
            query = "UPDATE PRODUTOS SET porcetagem = @numero where codproduto = @cod";
            using (con = new SqlConnection(url)) {
                using (cmd = new SqlCommand(query, con)) {
                    try {
                        con.Open();
                        cmd.Parameters.AddWithValue("@numero", number.Text);
                        cmd.Parameters.AddWithValue("@cod", Auxiliar);
                       
                        cmd.ExecuteNonQuery();

                    }catch(Exception ex) {
                        MessageBox.Show(ex.Message);
                    } finally {
                        number.Text = "";
                    }
                }
            }
        }

        public static async Task AtualizaValoreUpdateAsync() {
            string query = "select quantidade, porcetagem from Produtos where codProduto = @cod";

            using (SqlConnection con = new SqlConnection(url)) {
                using (SqlCommand cmd = new SqlCommand(query, con)) {
                    try {
                        // Abrir conexão de forma assíncrona
                        await con.OpenAsync();

                        // Adicionar o parâmetro
                        cmd.Parameters.AddWithValue("@cod", Auxiliar);

                        // Executar a leitura de forma assíncrona
                        using (SqlDataReader reader = await cmd.ExecuteReaderAsync()) {
                            if (await reader.ReadAsync()) {
                                int quant = reader.GetInt32(0);
                                double porce = reader.GetInt32(1);

                                // Atualiza o valor auxiliar com o valor calculado
                                AuxliarValores = Produtos.ValorVendaPorcetagem(porce, quant);
                                MessageBox.Show(AuxliarValores.ToString());
                            }
                        }
                    } catch (Exception ex) {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        public static async Task AtualizaValorUnidadeAsync() {
            // Primeiro, atualizar os valores necessários antes de realizar a atualização no banco
            await AtualizaValoreUpdateAsync();

            string query = "UPDATE PRODUTOS SET valorUnidade = @numero where codproduto = @cod";

            using (SqlConnection con = new SqlConnection(url)) {
                using (SqlCommand cmd = new SqlCommand(query, con)) {
                    try {
                        // Abrir conexão de forma assíncrona
                        await con.OpenAsync();

                        // Adicionar os parâmetros
                        cmd.Parameters.AddWithValue("@numero", AuxliarValores);
                        cmd.Parameters.AddWithValue("@cod", Auxiliar);

                        // Executar o comando de forma assíncrona
                        await cmd.ExecuteNonQueryAsync();
                    } catch (Exception ex) {
                        MessageBox.Show(ex.Message);
                    } finally {
                        AuxliarValores = 0;
                    }
                }
            }
        }


    }
}
