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
    public partial class frmAdicinar : Form
    {
        public static bool validar_Adicionar { set; get; }
         
        public frmAdicinar()
        {
            InitializeComponent();
        }

        private void cmd_fechar_Click(object sender, EventArgs e)
        {
            Verificador.verifica_Valor_Tag = false;
            frmMenu.id_TagRFID = null;
            Close();  
        }

        private void cmd_salvar_Click(object sender, EventArgs e)
        {
            
            // Somente salva se todos os campos estiverem preenchidos
            if (text_nome.Text == "" || text_facilitador.Text == "" || text_gerente.Text == "" || text_np.Text == "" || text_id_rfid.Text == "")
            {
                MessageBox.Show("Por favor preencha todos os campos!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            
            // Inicia conexão com o banco de dados
            SqlCeConnection conexao = new SqlCeConnection("Data Source = " + vars.base_dados);
            conexao.Open();
            // Define a conexão usada pela instancia criada
            SqlCeCommand comando = new SqlCeCommand();
            comando.Connection = conexao;

            comando.CommandText = "SELECT * FROM RegistrosColaboradores WHERE id_NP = " + "'" + text_np.Text + "'";

            SqlCeDataAdapter escravo = new SqlCeDataAdapter();
            escravo.SelectCommand = comando;
            DataTable verifica_Existencia = new DataTable();
            escravo.Fill(verifica_Existencia);

            if (verifica_Existencia.Rows.Count != 0)
            {
                    MessageBox.Show("Colaborador com o NP:" + text_np.Text + " já cadastrado", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
            }

            //Define parametros para o SqlCeCommand e seus valor
            comando.Parameters.AddWithValue("@id_NP", text_np.Text);
            comando.Parameters.AddWithValue("@id_TagRFID", text_id_rfid.Text);
            comando.Parameters.AddWithValue("@Nome", text_nome.Text);
            comando.Parameters.AddWithValue("@Facilitador", text_facilitador.Text);
            comando.Parameters.AddWithValue("@Gerente", text_gerente.Text);
            

            // Define a instrução a ser executada no banco de dados
            comando.CommandText = "INSERT INTO RegistrosColaboradores (id_NP, id_TagRFID, Nome, Facilitador, Gerente )" +
                                   "VALUES(@id_NP, @id_TagRFID, @Nome, @Facilitador, @Gerente); ";

            //Executa a instrução SQL
            comando.ExecuteNonQuery();

            MessageBox.Show("Colaborador Cadastrado Com Sucesso", "Adicionar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            text_nome.Text = "";
            text_facilitador.Text = "";
            text_gerente.Text = "";
            text_id_rfid.Text = "";
            text_np.Text = "";
            text_nome.Focus();

            validar_Adicionar = true;
        }

        private void frmAdicinar_Load(object sender, EventArgs e)
        {
            text_id_rfid.Enabled = false;
            text_id_rfid.Text = frmMenu.id_TagRFID;
        }

        private void frmAdicinar_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmMenu.id_TagRFID = null;
            Close();
        }

        private void cmd_fechar_KeyDown(object sender, KeyEventArgs e)
        {
            if ((Keys)  e.KeyValue == Keys.Escape)
            {
                Close();
            }
        }

        private void cmd_atualizar_rfid_Click(object sender, EventArgs e)
        {
            string id_rfid_editar = frmMenu.id_TagRFID;

            if (id_rfid_editar != null)
            {
                text_id_rfid.Text = id_rfid_editar;
                frmMenu.id_TagRFID = null;

            }
        }
    }
}
