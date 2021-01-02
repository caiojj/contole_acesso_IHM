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
    public partial class Edita_Adiciona_Porao : Form
    {
        string local_Acesso = frmMenu.local_Acesso;
        public static bool Local_Atualizado { set; get; }
        public Edita_Adiciona_Porao()
        {
            InitializeComponent();

        }

        private void cmd_fechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Edita_Adiciona_Porao_Load(object sender, EventArgs e)
        {

        }

        private void cmd_login_Click(object sender, EventArgs e)
        {
            SqlCeConnection conexao = new SqlCeConnection(@"Data Source =" + vars.baseDadosLocal);
            conexao.Open();

            SqlCeCommand comando = new SqlCeCommand();
            comando.Connection = conexao;
            comando.CommandText = "SELECT * FROM LocalAcesso";

            SqlCeDataAdapter escravo = new SqlCeDataAdapter();
            escravo.SelectCommand = comando;

            DataTable verifica_Existencia_Acesso = new DataTable();
            escravo.Fill(verifica_Existencia_Acesso);

            if(text_Usuario.Text == "")
            {
                MessageBox.Show("Para alterar o local de acesso insira o nome do mesmo.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (verifica_Existencia_Acesso.Rows.Count == 0)
            {
                comando.Parameters.AddWithValue("@LocalAcesso", text_Usuario.Text);
                comando.CommandText = "INSERT INTO LocalAcesso (Local_Acesso) VALUES (@LocalAcesso)";
                comando.ExecuteNonQuery();

                Local_Atualizado = true;
                Close();

            }
            else
            {
                comando.Parameters.AddWithValue("@Local_Acesso", local_Acesso);
                comando.CommandText = "DELETE FROM LocalAcesso WHERE Local_Acesso = @Local_Acesso";
                comando.ExecuteNonQuery();

                comando.Parameters.AddWithValue("@LocalAcesso", text_Usuario.Text);
                comando.CommandText = "INSERT INTO LocalAcesso (Local_Acesso) VALUES (@LocalAcesso)";
                comando.ExecuteNonQuery();

                Local_Atualizado = true;
                Close();

            }
            
        }
    }
}
