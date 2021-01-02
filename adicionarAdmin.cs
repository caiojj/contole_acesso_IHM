using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlServerCe;

namespace ControleAcesso2019
{
    public partial class adicionarAdmin : Form
    {
        public adicionarAdmin()
        {
            InitializeComponent();
        }

        private void cmd_fechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void text_Usuario_MouseClick(object sender, MouseEventArgs e)
        {
            text_Usuario.Clear();
        }

        private void text_senha_MouseClick(object sender, MouseEventArgs e)
        {
            text_senha.Clear();
        }

        private void cmd_login_Click(object sender, EventArgs e)
        {
            if (text_Usuario.Text == "" || text_senha.Text == "Digite a Senha" || text_Usuario.Text == "Usuário" || text_senha.Text == "" || textBox1.Text == "" || textBox1.Text == "Digite a Senha")
            {
                MessageBox.Show("Por favor preencha todos os campos.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (text_senha.Text != textBox1.Text)
            {
                MessageBox.Show("Senha não confere!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            SqlCeConnection conexao = new SqlCeConnection("Data Source = " + Vars.base_dados);
            conexao.Open();
            SqlCeCommand comando = new SqlCeCommand();
            comando.Connection = conexao;
            comando.Parameters.AddWithValue("@Usuario", text_Usuario.Text);
            comando.Parameters.AddWithValue("@Senha", text_senha.Text);
            comando.CommandText = "INSERT INTO Admin (Usuario, Senha) VALUES (@Usuario, @Senha)";
            comando.ExecuteNonQuery();
            MessageBox.Show("Admin cadastrado com sucesso.");
            Close();
        }

        private void textBox1_MouseClick(object sender, MouseEventArgs e)
        {
            textBox1.Clear();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.PasswordChar = '*';
        }

        private void text_senha_TextChanged(object sender, EventArgs e)
        {
            text_senha.PasswordChar = '*';
        }
    }
}
