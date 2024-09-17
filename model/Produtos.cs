using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstoqueProdutos.model {
    internal class Produtos {

        public string Nome { get; set; }
        public double PrecoUnidade { get; set; }
        public DateTime Validade { get; set; }
        public int Quantidade { get; set; }
        public string Categoria { get; set; }
        public string CodigoProdutos { get;  private set; }

        public Produtos(string nome, double precoUnidade, DateTime Validade, int quantidade, string categoria) {
            Nome = nome;
            PrecoUnidade = precoUnidade;
            this.Validade = Validade;
            Quantidade = quantidade;
            Categoria = categoria;
            CodigoProdutos = GerarNumero();
        }
        public Produtos() { }

        private static string GerarNumero() {
            
                var alph = "abcdefghijklmnopqrstuvwxyz";
                var num = "1234567890";              
                var chars = alph + num;
                Random random = new Random();
                var resultado = new char[5];              
                for (int i = 0; i < resultado.Length; i++) {
                    resultado[i] = chars[random.Next(chars.Length)];
                }              
                string codigoAleatorio = new string(resultado);
                 return codigoAleatorio;
            }

        public void VerificandoQuantidade(int quantidade) {
            if (quantidade < 0)
                MessageBox.Show("A Quantidade não pode se menos ou igual a 0");
        }

        public static Produtos VerificandoCampos(TextBox nome,TextBox preco,TextBox quantidade,ComboBox categoria,DateTimePicker validade) {
            string dataValidade;
            if(!string.IsNullOrEmpty(nome.Text) && !string.IsNullOrEmpty(preco.Text) && !string.IsNullOrEmpty(quantidade.Text)  && !string.IsNullOrEmpty(categoria.Text)) {
                if(!string.IsNullOrEmpty(validade.Text)) {
                    dataValidade = validade.Text;
                }
                else {
                    dataValidade = null;
                }
               
                return new Produtos() { Nome = nome.Text, PrecoUnidade = Double.Parse(preco.Text),Validade = DateTime.Parse(dataValidade), Quantidade = int.Parse(quantidade.Text), Categoria = categoria.Text, CodigoProdutos = GerarNumero() };
            }
            else {
                MessageBox.Show("Preencha os campos Obrigatórios: Nome, Valor,Quantidade ou QuantidadeKG e Categoria","Aviso");
                return new Produtos();
            }
        }

        public static string AddCategoria(TextBox categorias,ComboBox box) {
            if (!string.IsNullOrEmpty(categorias.Text)) {
                box.Items.Add(categorias.Text);
                box.Update();
                return categorias.Text;
            }
            else {
                MessageBox.Show("Adicione uma categoria");
                return "";
            }
        }

        }
    }

