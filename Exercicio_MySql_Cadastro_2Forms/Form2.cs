using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Exercicio_MySql_Cadastro_2Forms
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            string conexaoMySql = "Server=localhost;Database=pessoas;Uid=root;Pwd=root;";

            MySqlConnection conexao = new MySqlConnection(conexaoMySql);

            string querry = $@"select * from usuario
            where nome like '%{txtCaixaPesquisa.Text}%' or email like '%{txtCaixaPesquisa.Text}%'";

            DataTable tabela = new DataTable();

            try
            {
                conexao.Open();

                MySqlDataAdapter adpter = new MySqlDataAdapter(querry, conexao);

                adpter.Fill(tabela);

                if(tabela.Rows.Count == 0 || txtCaixaPesquisa.Text == string.Empty)
                {
                    MessageBox.Show("Nenhum valor encontrado!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    dgvTabelaUsuario.DataSource = tabela;
                }
               

            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Erro!");
            }
            finally
            {
                conexao.Close();
            }
        }
    }
}
