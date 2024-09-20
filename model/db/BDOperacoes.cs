﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
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
        private static string Auxiliar;

        private static Produtos produtos;

        public static string url = ConfigurationManager.ConnectionStrings["MinhaStringConexao"].ConnectionString;

        public static void InserirDadosTable(TextBox nome, TextBox valor, DateTimePicker validade, TextBox quantidade, ComboBox categoria,TextBox valorVenda,TextBox valorCompra) {
            query = "INSERT INTO  PRODUTOS (nome,valorunidade,datavalidade,quantidade,categoria,codproduto,valorvenda,valorcompra) values (" +
                "@nome,@valorunidade,@datavalidade,@quantidade,@categoria,@cod,@venda,@comprar)";
            using (con = new SqlConnection(url)) {
                using (cmd = new SqlCommand(query, con)) {
                    try {
                        var vl = Produtos.ValorVendaPorcetagem(valorVenda, valor);
                        con.Open();
                        produtos = Produtos.VerificandoCampos(nome, valor, quantidade, categoria, validade,valorCompra,valorVenda);
                        cmd.Parameters.AddWithValue("@nome", produtos.Nome);
                        cmd.Parameters.AddWithValue("@valorunidade", produtos.PrecoUnidade);
                        cmd.Parameters.AddWithValue("@datavalidade", produtos.Validade);
                        cmd.Parameters.AddWithValue("@quantidade", produtos.Quantidade);
                        cmd.Parameters.AddWithValue("@categoria", produtos.Categoria);
                        cmd.Parameters.AddWithValue("@cod", produtos.CodigoProdutos);
                        cmd.Parameters.AddWithValue("@comprar", produtos.ValorComprar);
                        cmd.Parameters.AddWithValue("@venda", vl);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Produto Inserido");

                    } catch (Exception ex) {
                        MessageBox.Show(ex.Message);

                    } finally {
                        nome.Text = "";
                        valor.Text = "";
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
            query = "SELECT nome,valorUnidade,datavalidade,quantidade,categoria,codproduto,valorcompra,valorvenda as '%',(quantidade * valorunidade) as Total FROM PRODUTOS";
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
            query = "select * from produtos where categoria = @cat";
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
            query = "SELECT nome,valorUnidade,datavalidade,quantidade,categoria,codproduto,valorcompra,valorvenda as '%',(quantidade * valorunidade) as Total FROM PRODUTOS where codProduto = @cod";
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
    }
}
