using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio_MySql_Cadastro_2Forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            string conexaoMySql = "Server=localhost;Database=pessoas;Uid=root;Pwd=root;";

            MySqlConnection conexao = new MySqlConnection(conexaoMySql);

            string querry = $@"insert into usuario(nome, email, senha)
            values('{txtNome.Text}', '{txtEmail.Text}', '{txtSenha.Text}')";

            string confirmarSenha = txtConfirmarSenha.Text;

            try
            {
                conexao.Open();

                if (txtSenha.Text == confirmarSenha && txtNome.Text != string.Empty && txtEmail.Text != string.Empty)
                {
                    MySqlCommand cmd = new MySqlCommand(querry, conexao);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Cadastro efetuado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Limpar();
                }
                else if(txtSenha.Text != txtConfirmarSenha.Text)
                {
                    MessageBox.Show("Os campos 'Senha' e 'Confirmar Senha' não são compatíveis!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Um ou mais Campos não foram preenchidos", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conexao.Close();
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        private void Limpar()
        {
            txtNome.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtSenha.Text = string.Empty;
            txtConfirmarSenha.Text = string.Empty;
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            Form2 abrirPesquisa = new Form2();

            abrirPesquisa.Show();

            this.Hide();
        }
    }
}
