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
    public partial class ColaboradorInfo : Form
    {
        int id_NP;
        public ColaboradorInfo(int id_NP)
        {
            InitializeComponent();
            this.id_NP = id_NP;
            CriaTabelaInfo();
        }

        private void cmd_fechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private  void CriaTabelaInfo()
        {
            
            SqlCeConnection conexao = new SqlCeConnection("Data Source = " + vars.base_dados);
            conexao.Open();


            DataTable dadosInfo = new DataTable();
            SqlCeCommand comando = new SqlCeCommand();
            comando.CommandText = "SELECT * FROM HistoricoAcesso WHERE id_NP = " + id_NP;
            comando.Connection = conexao;

            SqlCeDataAdapter escravo = new SqlCeDataAdapter();
            escravo.SelectCommand = comando;
            escravo.Fill(dadosInfo);

            comando.CommandText = "SELECT * FROM RegistrosColaboradores WHERE id_NP = " + id_NP;
            escravo.SelectCommand = comando;

            DataTable dadosRegistros = new DataTable();
            escravo.Fill(dadosRegistros);

            label_nome_programanome.Text = dadosRegistros.Rows[0]["Nome"].ToString();
            label_nome_programafacilitador.Text = dadosRegistros.Rows[0]["Facilitador"].ToString();
            label_nome_programagerente.Text = dadosRegistros.Rows[0]["Gerente"].ToString();
            label_nome_programaidRFID.Text = dadosRegistros.Rows[0]["id_TagRFID"].ToString();
            label_nome_programaidNP.Text = dadosRegistros.Rows[0]["id_NP"].ToString();

                
            tabela_INFO.DataSource = dadosInfo;
            label_N_acessos.Text = "Nº Acessos: " + tabela_INFO.Rows.Count;

            tabela_INFO.Sort(tabela_INFO.Columns["Horario"], ListSortDirection.Descending);
            tabela_INFO.Columns["id_Historico"].Visible = false;
            tabela_INFO.Columns["id_Registros"].Visible = false;

            tabela_INFO.Columns["id_NP"].Width = CalcularLargura(20);
            tabela_INFO.Columns["id_TagRFID"].Width = CalcularLargura(20);
            tabela_INFO.Columns["EntradaSaida"].Width = CalcularLargura(20);
            tabela_INFO.Columns["Horario"].Width = CalcularLargura(20);
            tabela_INFO.Columns["Local"].Width = CalcularLargura(20);

            tabela_INFO.ClearSelection();
        }


        private int CalcularLargura(int porcentagem)
        {
            int largura_tabela = tabela_INFO.Width - 20;
            int resultado = (largura_tabela * porcentagem) / 100;
            return resultado;
        }

        private void cmd_pesquisar_Click(object sender, EventArgs e)
        {
            data_final.Value = data_final.Value.AddDays(1);

            string data_Inicial = data_inicial.Value.Date.ToString("yyy/MM/dd");
            string data_Final = data_final.Value.Date.ToString("yyy/MM/dd");

            data_final.Value = data_final.Value.AddDays(-1);

            data_Inicial = data_Inicial.Replace("/", "-");
            data_Final = data_Final.Replace("/", "-");

            

            SqlCeConnection conexao = new SqlCeConnection("Data Source =" + vars.base_dados);
            conexao.Open();

            DataTable tabela_Data_Pesquisa = new DataTable();
            SqlCeCommand comando = new SqlCeCommand();
            comando.CommandText = " SELECT * FROM HistoricoAcesso WHERE id_NP = " +
                                  id_NP + " AND Horario BETWEEN '" + data_Inicial + "' AND '" + data_Final + "'";
            comando.Connection = conexao;

            //"SELECT * FROM HistoricoAcesso WHERE " +
            //                      "Horario between" + "'" + data_Inicial_Refinado + "'" + "AND" + "'" + data_Final_Refinado + "' AND id_NP = " + id_NP;

            SqlCeDataAdapter escravo = new SqlCeDataAdapter();
            escravo.SelectCommand = comando;
            escravo.Fill(tabela_Data_Pesquisa);

            tabela_INFO.DataSource = tabela_Data_Pesquisa;
            label_N_acessos.Text = "Nº Acessos: " + tabela_INFO.Rows.Count;
            tabela_INFO.Sort(tabela_INFO.Columns["Horario"], ListSortDirection.Descending);

            tabela_INFO.Columns["id_Historico"].Visible = false;
            tabela_INFO.Columns["id_NP"].Width = CalcularLargura(20);
            tabela_INFO.Columns["id_TagRFID"].Width = CalcularLargura(20);
            tabela_INFO.Columns["EntradaSaida"].Width = CalcularLargura(20);
            tabela_INFO.Columns["Horario"].Width = CalcularLargura(20);
            tabela_INFO.Columns["Local"].Width = CalcularLargura(20);
            tabela_INFO.ClearSelection();
        }

        private void cmd_apagar_tudo_Click(object sender, EventArgs e)
        {
            if (frmMenu.status_Login)
            {
                if (MessageBox.Show("Tem certeza que deseja apagar todo o histórico?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {
                    SqlCeConnection conexao = new SqlCeConnection("Data Source = " + vars.base_dados);
                    conexao.Open();

                    SqlCeCommand comando = new SqlCeCommand("DELETE FROM HistoricoAcesso WHERE id_NP =" + id_NP, conexao);
                    comando.ExecuteNonQuery();

                    comando.CommandText = "DELETE FROM Acessando WHERE id_NP = " + id_NP;
                    comando.ExecuteNonQuery();
                    frmMenu.apagar_historico = true;
                    CriaTabelaInfo();
                }
            }
            else
            {
                MessageBox.Show("Para habilitar está função, faça login como admin.", "" , MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void cmd_atualizar_Click(object sender, EventArgs e)
        {
            CriaTabelaInfo();
        }

        private void ColaboradorInfo_Load(object sender, EventArgs e)
        {
            tabela_INFO.ClearSelection();
        }
    }
}
