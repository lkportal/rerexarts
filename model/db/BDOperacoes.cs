using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstoqueProdutos.model.db {
    internal class BDOperacoes {

        private SqlDataAdapter DataAdapter;
        private static SqlCommand cmd;
        private static SqlDataReader reader;
        private static DataTable DataTable;
        private static SqlConnection con;
        private static string query;

        private static Produtos produtos;

        public static string url = @"Server =DESKTOP-ONN8FDK\SQLEXPRESS;Database=rerexarts;Trusted_Connection=True;";

        public static void InserirDadosTable(TextBox nome, TextBox valor, DateTimePicker validade, TextBox quantidade, ComboBox categoria) {
            query = "INSERT INTO  PRODUTOS (nome,valorunidade,datavalidade,quantidade,categoria,codproduto) values (" +
                "@nome,@valorunidade,@datavalidade,@quantidade,@categoria,@cod)";
            using (con = new SqlConnection(url)) {
                using (cmd = new SqlCommand(query, con)) {
                    try {
                        con.Open();
                        produtos = Produtos.VerificandoCampos(nome, valor, quantidade, categoria, validade);
                        cmd.Parameters.AddWithValue("@nome", produtos.Nome);
                        cmd.Parameters.AddWithValue("@valorunidade", produtos.PrecoUnidade);
                        cmd.Parameters.AddWithValue("@datavalidade", produtos.Validade);
                        cmd.Parameters.AddWithValue("@quantidade", produtos.Quantidade);
                        cmd.Parameters.AddWithValue("@categoria", produtos.Categoria);
                        cmd.Parameters.AddWithValue("@cod", produtos.CodigoProdutos);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Produto Inserido");

                    } catch (Exception ex) {
                        MessageBox.Show(ex.Message);

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
            query = "SELECT nome,valorUnidade,datavalidade,quantidade,categoria,codproduto FROM PRODUTOS";
            using (con = new SqlConnection(url)) {
                using (cmd = new SqlCommand(query, con)) {
                    con.Open();
                    reader = cmd.ExecuteReader();
                    object[] rows = new object[reader.FieldCount];
                    if (reader.HasRows) {

                        lista.Columns.Clear();
                         for(int i=0; i<reader.FieldCount; i++) {
                            lista.Columns.Add(reader.GetName(i),reader.GetName(i));
                        }
                        while (reader.Read()) {
                            for (int i = 0; i < reader.FieldCount; i++) {
                                rows[i] = reader.GetValue(i);
                            }
                            lista.Rows.Add(rows);
                        }

                    }

                }
            }
        }

        public static void ExcluirDado(DataGridView lista) {
          
        }
    }
}
