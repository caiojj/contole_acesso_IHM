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
    public partial class frmEditar : Form
    {
        public static bool validar_Edicao { set; get; }
        public static bool valida_edicao_TAG { set; get; }
        string id_rfid_editar;
        int id_NP;
        //===================================
        public frmEditar(int id_NP)
        {
            InitializeComponent();
            this.id_NP = id_NP;
            valida_edicao_TAG = true;
            
            
        }

        private void cmd_fechar_Click(object sender, EventArgs e)
        {
            frmMenu.id_TagRFID = null;
            valida_edicao_TAG = false;
            Close();
        }

        private void cmd_salvar_Click(object sender, EventArgs e)
        {
            // todos os campos estão preenchidos
            if(text_nome.Text == "" || text_facilitador.Text == "" || text_gerente.Text == "" || text_np.Text == "" || text_id_rfid.Text == "")
            {
                MessageBox.Show("Por favor preencha todos os campos!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SqlCeConnection conexao = new SqlCeConnection("Data Source = " + Vars.base_dados);
            conexao.Open();
            SqlCeCommand comando = new SqlCeCommand();
            comando.Connection = conexao;

            comando.Parameters.AddWithValue("@id_NP", text_np.Text);
            comando.Parameters.AddWithValue("@id_TagRFID", text_id_rfid.Text);
            comando.Parameters.AddWithValue("@Nome", text_nome.Text);
            comando.Parameters.AddWithValue("@Facilitador", text_facilitador.Text);
            comando.Parameters.AddWithValue("@Gerente", text_gerente.Text);
            comando.Parameters.AddWithValue("@id_NP_Localizador", id_NP);

            comando.CommandText = "UPDATE RegistrosColaboradores SET " +
                                          "id_NP          =       @id_NP," +
                                          "id_TagRFID     =       @id_TagRFID," +
                                          "Nome           =       @Nome," +
                                          "Facilitador    =       @Facilitador," +
                                          "Gerente        =       @Gerente " +
                                          "WHERE id_NP    =       @id_NP_Localizador";

            comando.ExecuteNonQuery();
            conexao.Close();
            Close();
            MessageBox.Show("Registro atualizado com sucesso!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            validar_Edicao = true;

        }

        private void frmEditar_Load(object sender, EventArgs e)
        {
            ApresentarInfo();
        }

        private void ApresentarInfo()
        {
            

           SqlCeConnection conexao = new SqlCeConnection("Data Source = " + Vars.base_dados);
           conexao.Open();

           DataTable dados = new DataTable();
           SqlCeDataAdapter escravo = new SqlCeDataAdapter("SELECT * FROM RegistrosColaboradores WHERE id_NP =" + id_NP, conexao);
           escravo.Fill(dados);

           text_nome.Text = dados.Rows[0]["Nome"].ToString();
           text_facilitador.Text = dados.Rows[0]["Facilitador"].ToString();
           text_gerente.Text = dados.Rows[0]["Gerente"].ToString();
           text_id_rfid.Text = dados.Rows[0]["id_TagRFID"].ToString();
           text_np.Text = dados.Rows[0]["id_NP"].ToString();
           text_id_rfid.Enabled = false;
            
   
        }

        private void cmd_fechar_KeyDown(object sender, KeyEventArgs e)
        {
            if((Keys) e.KeyValue == Keys.Escape)
            {
                frmMenu.id_TagRFID = null;
                Close();
            }
        }

        private void cmd_atualizar_rfid_Click(object sender, EventArgs e)
        {
            id_rfid_editar = frmMenu.id_TagRFID;

            if (id_rfid_editar != null)
            {
                text_id_rfid.Text = id_rfid_editar;
                cmd_atualizar_rfid.Image = ControleAcesso2019.Properties.Resources.icons8_confirmação_e_atualização_48;
                frmMenu.id_TagRFID = null;

            }
        }
    }
}
