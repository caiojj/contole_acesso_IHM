using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlServerCe;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControleAcesso2019
{
    public partial class AutenticaçãoAdmin : Form
    {
        public static string nome_admin { get; set; }

        public AutenticaçãoAdmin()
        {
            InitializeComponent();
        }

        private void text_senha_TextChanged(object sender, EventArgs e)
        {
            text_senha.PasswordChar = '*';
        }

        private void cmd_login_Click(object sender, EventArgs e)
        {
            if (text_Usuario.Text == "" || text_senha.Text == "Digite a Senha" || text_Usuario.Text == "Usuário" || text_senha.Text == "")
            {
                MessageBox.Show("Por favor preencha todos os campos.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
                SqlCeConnection conexao = new SqlCeConnection("Data Source = " + Vars.base_dados);
                conexao.Open();

                SqlCeCommand comando = new SqlCeCommand();
                comando.Parameters.AddWithValue("@Usuario", text_Usuario.Text);
                comando.Parameters.AddWithValue("@Senha", text_senha.Text);
                comando.CommandText = "SELECT * FROM Admin WHERE Usuario = @Usuario AND Senha = @Senha";
                comando.Connection = conexao;

                DataTable verifica_Admin = new DataTable();
                SqlCeDataAdapter escravo = new SqlCeDataAdapter();
                escravo.SelectCommand = comando;
                escravo.Fill(verifica_Admin);

                if (verifica_Admin.Rows.Count != 0)
                {
                    nome_admin = verifica_Admin.Rows[0]["Usuario"].ToString();
                    frmMenu.status_Login = true;
                    Close();
                }
                else
                {
                    MessageBox.Show("Usuario ou senha incorretos. Tente novamente", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    text_senha.Text = "Digite a Senha";
                    text_Usuario.Text = "Usuário";
                }

        }

        private void cmd_fechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void text_senha_MouseClick(object sender, MouseEventArgs e)
        {
            text_senha.Clear();
        }

        private void text_Usuario_MouseClick(object sender, MouseEventArgs e)
        {
            text_Usuario.Clear();
        }

    }
}
