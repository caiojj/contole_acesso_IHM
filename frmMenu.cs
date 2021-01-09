using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlServerCe;
using System.IO.Ports;


namespace ControleAcesso2019
{
    public partial class frmMenu : Form
    {
        public static bool apagar_historico { get; set; }
        public static bool status_Login { get; set; }
        public static int id_NP { get; set; }
        public static string id_TagRFID { get; set; }
        public static string local_Acesso { get; set; }
        bool led_Ligado = false;

        Point ArrastarCursor;
        Point ArrastarForm;
        bool Arrastando;

        public frmMenu()
        {
            InitializeComponent();
            AtualizacaoListaCOM();
            CriaTabelaRegistros();
            CriaTabelaHistorico();
            CriaTabelaAcesso();
            ApagarEditarOff();
            sairToolStripMenuItem.Visible = false;
            localDoAcessoToolStripMenuItem.Visible = false;
            toolStripSeparator1.Visible = false;
            verifica_Admin_Adicionado();
            exibir_Local_Acesso();
        }

        // cria tabela de colaboradores cadastrados
        private void CriaTabelaRegistros() 
        {
            SqlCeConnection conexao = new SqlCeConnection("Data Source =" + Vars.base_dados);
            conexao.Open();

            SqlCeCommand comando = new SqlCeCommand();
            comando.CommandText = "SELECT * FROM RegistrosColaboradores";
            comando.Connection = conexao;

            SqlCeDataAdapter escravo = new SqlCeDataAdapter();
            escravo.SelectCommand = comando;

            DataTable registros_dados = new DataTable();
            escravo.Fill(registros_dados);

            tabela_registros.DataSource = registros_dados;
            tabela_registros.Columns["id_TagRFID"].Visible = false;
            tabela_registros.Columns["id_Registros"].Visible = false;
            label_registros.Text = "Registros: " + tabela_registros.Rows.Count;

            // dimensão
            tabela_registros.Columns["id_np"].Width = CalcularLargura(25);
            tabela_registros.Columns["Nome"].Width = CalcularLargura(25);
            tabela_registros.Columns["Facilitador"].Width = CalcularLargura(25);
            tabela_registros.Columns["Gerente"].Width = CalcularLargura(25);

            tabela_registros.ClearSelection();
        }
        

        private void CriaTabelaHistorico()  // cria tabala de históricos de acesso
        {
            SqlCeConnection conexao = new SqlCeConnection("Data Source =" + Vars.base_dados);
            conexao.Open();

            string query = "SELECT * FROM HistoricoAcesso";

            SqlCeCommand comando = new SqlCeCommand();
            comando.CommandText = query;
            comando.Connection = conexao;

            SqlCeDataAdapter escravo = new SqlCeDataAdapter();
            escravo.SelectCommand = comando;

            DataTable dados = new DataTable();
            escravo.Fill(dados);

            tabela_historico_acesso.DataSource = dados;
            tabela_historico_acesso.Sort(tabela_historico_acesso.Columns["Horario"], ListSortDirection.Descending);
            label_N_acessos.Text = "Nº Acessos: " + tabela_historico_acesso.Rows.Count;
           

            tabela_historico_acesso.Columns["id_Historico"].Visible = false;
            tabela_historico_acesso.Columns["id_Registros"].Visible = false;


            //dimensão
            tabela_historico_acesso.Columns["id_NP"].Width = CalcularLargura(20);
            tabela_historico_acesso.Columns["id_TagRFID"].Width = CalcularLargura(20);
            tabela_historico_acesso.Columns["EntradaSaida"].Width = CalcularLargura(20);
            tabela_historico_acesso.Columns["Horario"].Width = CalcularLargura(20);
            tabela_historico_acesso.Columns["Local"].Width = CalcularLargura(20);

            tabela_historico_acesso.ClearSelection();
        } 
        
        //======================================================================

        private void CriaTabelaAcesso() // cria tabela de colaboradores que estão acessando o local
        {
            SqlCeConnection conexao = new SqlCeConnection("Data Source =" + Vars.base_dados);
            conexao.Open();

            SqlCeCommand comando = new SqlCeCommand();
            comando.CommandText = "SELECT * FROM Acessando";
            comando.Connection = conexao;

            DataTable dados = new DataTable();
            SqlCeDataAdapter escravo = new SqlCeDataAdapter();
            escravo.SelectCommand = comando;
            escravo.Fill(dados);

            tabela_Acesso_Atual.DataSource = dados;
            tabela_Acesso_Atual.Columns["id_Acessando"].Visible = false;
            tabela_Acesso_Atual.Columns["id_Registros"].Visible = false;
            tabela_Acesso_Atual.Sort(tabela_Acesso_Atual.Columns["Horario"], ListSortDirection.Descending);
            // dimensão
            tabela_Acesso_Atual.Columns["id_NP"].Width = CalcularLargura(20);
            tabela_Acesso_Atual.Columns["id_TagRFID"].Width = CalcularLargura(20);
            tabela_Acesso_Atual.Columns["EntradaSaida"].Width = CalcularLargura(20);
            tabela_Acesso_Atual.Columns["Horario"].Width = CalcularLargura(20);
            tabela_Acesso_Atual.Columns["Local"].Width = CalcularLargura(20);

            tabela_Acesso_Atual.ClearSelection();
        }
        

        private int CalcularLargura (int porcentagem)
        {
            int largura_tabela = tabela_registros.Width - 20;
            int resultado = largura_tabela * porcentagem / 100;
            return resultado;
        }
        

        private void cmd_adicionar_Click(object sender, EventArgs e)
        {
            if (status_Login)
            {
                Verificador abrirAdicinar = new Verificador();
                abrirAdicinar.ShowDialog();

                if (Verificador.verifica_Valor_Tag)
                {
                    frmAdicinar abrir = new frmAdicinar();
                    abrir.ShowDialog();
                    Verificador.verifica_Valor_Tag = false;
                    
                    CriaTabelaRegistros();
                    frmAdicinar.validar_Adicionar = false;
                }
            }

            else
            {
                MessageBox.Show("Para habilitar está função, faça login como admin.", "Acesso Negado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        

        private void cmd_serial_Click(object sender, EventArgs e)
        {
            MenuSerial menuSerial = new MenuSerial();

            menuSerial.ShowDialog();
            conectarserial();
        }
        

        private void AtualizacaoListaCOM()  // Atualiza portas COM 
        {
            // se a quantidade mudar
             if (box_COM.Items.Count == SerialPort.GetPortNames().Length)
            {
                return;
               
            }


            //limpa comboBox
            box_COM.Items.Clear();
            try
            {
                // adiciona todas as COM disponiveis na lista
                foreach (string s in SerialPort.GetPortNames())
                {
                    box_COM.Items.Add(s);
                }

                box_COM.SelectedIndex = 0;

            }
            catch
            {
                box_COM.Text = "";
                MessageBox.Show("Favor Conectar o Arduino a Porta COM ", "Nenhuma Porta COM Encontrada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void conectarserial()
        {
            if (arduino.IsOpen == false)
            {
                try
                {
                    arduino.PortName = MenuSerial.port_com;
                    arduino.Open();

                    cmd_serial.Image = ControleAcesso2019.Properties.Resources.icons8_usb_on_48;
                    box_COM.Enabled = false;

                }
                catch
                {
                    MessageBox.Show("Erro ao se conectar a SerialPort", "Falha na SerialPort", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

            }
            else
            {
               
                arduino.Close();
                box_COM.Enabled = true;
                cmd_serial.Image = ControleAcesso2019.Properties.Resources.icons8_usb_off_48;
                
            }
        }
        

        private void arduino_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            id_TagRFID = arduino.ReadLine();
            Invoke(new EventHandler(TratamentoDados));
        }


        private void TratamentoDados(object sender, EventArgs e)
        {
            if (Edita_Adiciona_Porao.Local_Atualizado == true)
            {
                exibir_Local_Acesso();
                Edita_Adiciona_Porao.Local_Atualizado = false;
            }

            // Remove os caracteres '\r' da variavel id+TagRFID 
            id_TagRFID = id_TagRFID.Replace("\r", "");

            SqlCeConnection conexao = new SqlCeConnection("Data Source = " + Vars.base_dados);
            conexao.Open();

            string query = "SELECT * FROM RegistrosColaboradores WHERE id_TagRFID = " + "'" + id_TagRFID + "'";
            SqlCeCommand comando = new SqlCeCommand(query, conexao);

            SqlCeDataAdapter escravo = new SqlCeDataAdapter();
            escravo.SelectCommand = comando;

            //Autenticação verifica existencia
            DataTable verifica_EX_Dados = new DataTable();
            escravo.Fill(verifica_EX_Dados);

            //Busca maior valor da primary key 
            comando.CommandText = "SELECT MAX(id_Historico) AS IndiceMAX FROM HistoricoAcesso";
            escravo.SelectCommand = comando;
            DataTable indiceMAX = new DataTable();
            escravo.Fill(indiceMAX);
 

            // Se diferente de 0 o valor da tag esta no banco de dados
            if (verifica_EX_Dados.Rows.Count != 0)
            {
                // Busca o valor da tag no tabela Histórico de acesso
                comando.CommandText = "SELECT * FROM HistoricoAcesso WHERE id_TagRFID =" + "'" + id_TagRFID + "'";
                escravo.SelectCommand = comando;

                // Tabela virtual de verificação de primeiro acesso
                DataTable Verifica_Primeiro_Acesso = new DataTable();
                escravo.Fill(Verifica_Primeiro_Acesso);
                
                //Filtra se é o primero acesso do colaborador ao local
                if (Verifica_Primeiro_Acesso.Rows.Count == 0)
                {
                    // Calouro 
                    arduino.Write("E");// Messagem de entrada na serial
                    bool bit = true;
                    string id_nP = verifica_EX_Dados.Rows[0]["id_NP"].ToString();
                    int id_Registros = int.Parse(verifica_EX_Dados.Rows[0]["id_Registros"].ToString()); // Busca a primary key de RegistrosColaboradores

                    comando.Parameters.AddWithValue("@id_Registros", id_Registros);
                    comando.Parameters.AddWithValue("@id_NP", id_nP);
                    comando.Parameters.AddWithValue("@id_TagRFID", id_TagRFID);
                    comando.Parameters.AddWithValue("@EntradaSaida", bit);
                    comando.Parameters.AddWithValue("@Horario", DateTime.Now);
                    comando.Parameters.AddWithValue("@Local", local_Acesso);
                    comando.CommandText = "INSERT INTO HistoricoAcesso (id_Registros, id_NP, id_TagRFID, EntradaSaida, Horario, Local )" +
                                          "VALUES( @id_Registros, @id_NP, @id_TagRFID, @EntradaSaida, @Horario, @Local); ";
                    comando.ExecuteNonQuery();

                    Acessando();
                    CriaTabelaHistorico();
                }
                else
                {
                    //Veterano
                    comando.CommandText = "SELECT * FROM HistoricoAcesso WHERE id_TagRFID =" + "'" + id_TagRFID + "'" + "ORDER BY Horario DESC";
                    escravo.SelectCommand = comando;

                    DataTable Verifica_Estado_Acesso = new DataTable();
                    escravo.Fill(Verifica_Estado_Acesso);

                    string nivel_logico = Verifica_Estado_Acesso.Rows[0]["EntradaSaida"].ToString();
                    bool Nivel_Logico_Acesso = bool.Parse(nivel_logico);

                    // Se o valor de EntradaSaida mais recente for true o colaborador esta saindo do local, se não esta entrando
                    if(Nivel_Logico_Acesso == true )
                    {
                        arduino.Write("S");// Mensagem de saida na serial
                        bool bit = false;
                        string id_nP = verifica_EX_Dados.Rows[0]["id_NP"].ToString();
                        int id_Registros = int.Parse(verifica_EX_Dados.Rows[0]["id_Registros"].ToString()); // Busca a primary key de RegistrosColaboradores

                        comando.Parameters.AddWithValue("@id_Registros", id_Registros);
                        comando.Parameters.AddWithValue("@id_NP", id_nP);
                        comando.Parameters.AddWithValue("@id_TagRFID", id_TagRFID);
                        comando.Parameters.AddWithValue("@EntradaSaida", bit);
                        comando.Parameters.AddWithValue("@Horario", DateTime.Now);
                        comando.Parameters.AddWithValue("@Local", local_Acesso);
                        comando.CommandText = "INSERT INTO HistoricoAcesso (id_Registros, id_NP, id_TagRFID, EntradaSaida, Horario, Local )" +
                                              "VALUES( @id_Registros, @id_NP, @id_TagRFID, @EntradaSaida, @Horario, @Local); ";

                        comando.ExecuteNonQuery();

                        DescarteAcesso();
                        CriaTabelaHistorico();
                    }
                    else
                    {
                        arduino.Write("E");// Mensagem de entrada na serial
                        bool bit = true;
                        string id_nP = verifica_EX_Dados.Rows[0]["id_NP"].ToString();
                        int id_Registros = int.Parse(verifica_EX_Dados.Rows[0]["id_Registros"].ToString()); // Busca a primary key de RegistrosColaboradores

                        comando.Parameters.AddWithValue("@id_Registros", id_Registros);
                        comando.Parameters.AddWithValue("@id_NP", id_nP);
                        comando.Parameters.AddWithValue("@id_TagRFID", id_TagRFID);
                        comando.Parameters.AddWithValue("@EntradaSaida", bit);
                        comando.Parameters.AddWithValue("@Horario", DateTime.Now);
                        comando.Parameters.AddWithValue("@Local", local_Acesso);
                        comando.CommandText = "INSERT INTO HistoricoAcesso (id_Registros, id_NP, id_TagRFID, EntradaSaida, Horario, Local )" +
                                              "VALUES( @id_Registros, @id_NP, @id_TagRFID, @EntradaSaida, @Horario, @Local); ";
                        comando.ExecuteNonQuery();

                        Acessando();
                        CriaTabelaHistorico();
                    }   
                }
                id_TagRFID = null;
            }
            else
            {
                if (!frmEditar.valida_edicao_TAG)
                {
                    // Imprime na serial (acesso negado)
                    arduino.Write("B");
                    if (!Verificador.verifica_Froms_Aberta)
                    {
                        id_TagRFID = null;
                    }
                }
            }
        }
        
        //======================================================================

        private void frmMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            arduino.Close();
        }
        
        //======================================================================

        private void timer1_Tick(object sender, EventArgs e)
        {
            AtualizacaoListaCOM();
            Led_Estadia_Porao();
        }
        
        //======================================================================

        private void cmd_editar_Click(object sender, EventArgs e)
        { 
            frmEditar editar = new frmEditar(id_NP);

            if (status_Login)
            {
                editar.ShowDialog();
            }
            else
            {
                MessageBox.Show("Para habilitar está função, faça login como admin.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            

            if (frmEditar.validar_Edicao)
            {
                CriaTabelaRegistros();
                frmEditar.validar_Edicao = false;
            }
        }
        
        //======================================================================

        private void tabela_registros_CellClick(object sender, DataGridViewCellEventArgs e)
        {
             try
            {
                id_NP = Convert.ToInt32(tabela_registros.Rows[e.RowIndex].Cells["id_NP"].Value);
                cmd_editar.Enabled = true;
                cmd_apagar.Enabled = true;

                //id_NPhistorico = Convert.ToInt32(tabela_registros.Rows[e.RowIndex].Cells["id_NP"].Value);
                cmd_propriedades.Enabled = true; 
            }
            catch
            {

            }
        }
        
        //======================================================================

        private void tabela_historico_acesso_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                id_NP = Convert.ToInt32(tabela_historico_acesso.Rows[e.RowIndex].Cells["id_NP"].Value);
                cmd_propriedades.Enabled = true;
            }
            catch
            {
   
            }
        }

        //======================================================================

        private void tabela_Acesso_Atual_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                id_NP = Convert.ToInt32(tabela_Acesso_Atual.Rows[e.RowIndex].Cells["id_NP"].Value);
                cmd_propriedades.Enabled = true;
            }
            catch
            {

            }
        }
        
        //======================================================================

        private void cmd_apagar_Click(object sender, EventArgs e)
        {
            if (status_Login)
            {
                if (MessageBox.Show("Tem certeza que deseja excluir esté registro?", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {
                    SqlCeConnection conexao = new SqlCeConnection("Data Source = " + Vars.base_dados);
                    conexao.Open();

                    SqlCeCommand comando = new SqlCeCommand("DELETE FROM RegistrosColaboradores WHERE id_NP =" + id_NP, conexao);
                    comando.ExecuteNonQuery();
                    conexao.Close();
                    comando.Dispose();

                    CriaTabelaRegistros();
                    CriaTabelaHistorico();
                    CriaTabelaAcesso();

                    cmd_apagar.Enabled = false;
                    cmd_propriedades.Enabled = false;
                    cmd_editar.Enabled = false;
                }
            }
            else
            {
                MessageBox.Show("Para habilitar está função, faça login como admin.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        
        //======================================================================

        private void ApagarEditarOff()
        {
            cmd_apagar.Enabled = false;
            cmd_editar.Enabled = false;
            cmd_propriedades.Enabled = false;
        }

        //===============================================================

        private void cmd_FECHAR_Click(object sender, EventArgs e)
        {
            arduino.Close();
            Application.Exit();
        }
        

        private void cmd_MINIMIZAR_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        
        //======================================================================

        private void cmd_propriedades_Click(object sender, EventArgs e)
        {
            ColaboradorInfo info = new ColaboradorInfo(id_NP);
            info.ShowDialog();

            if (apagar_historico == true)
            {
                CriaTabelaHistorico();
                CriaTabelaAcesso();
                apagar_historico = false;
            }


            cmd_propriedades.Enabled = false;
        }
        
        //======================================================================

        private void label1_Click(object sender, EventArgs e)
        {
            Sobre abrirSobre = new Sobre();
            abrirSobre.ShowDialog();
        }
        
        //======================================================================

        private void Acessando()
        {
            SqlCeConnection conexao = new SqlCeConnection("Data Source = " + Vars.base_dados);
            conexao.Open();

            SqlCeCommand comando = new SqlCeCommand();
            comando.Connection = conexao;
            comando.CommandText = "SELECT * FROM HistoricoAcesso WHERE id_TagRFID =" + "'" + id_TagRFID + "'";

            DataTable dados_idNP = new DataTable();
            SqlCeDataAdapter escravo = new SqlCeDataAdapter();
            escravo.SelectCommand = comando;
            escravo.Fill(dados_idNP);

            DataTable tabela_indice = new DataTable();
            comando.CommandText = "SELECT MAX(id_Acessando) AS indiceMAX FROM Acessando ";
            escravo.Fill(tabela_indice);

            DataTable Busca_PrimaryKey_Registros = new DataTable();
            comando.CommandText = "SELECT * FROM RegistrosColaboradores WHERE id_TagRFID = " + "'" + id_TagRFID + "'";
            escravo.Fill(Busca_PrimaryKey_Registros);


            int id_NPAcesso = Convert.ToInt32(dados_idNP.Rows[0]["id_NP"].ToString());
            string id_RFID = dados_idNP.Rows[0]["id_TagRFID"].ToString();
            int bit = 1; int id_Registros = int.Parse(Busca_PrimaryKey_Registros.Rows[0]["id_Registros"].ToString()); // Busca a primary key de RegistrosColaboradores

            comando.Parameters.AddWithValue("@id_Registros", id_Registros);
            comando.Parameters.AddWithValue("@id_NP", id_NPAcesso);
            comando.Parameters.AddWithValue("@id_TagRFID", id_RFID);
            comando.Parameters.AddWithValue("@EntradaSaida", bit);
            comando.Parameters.AddWithValue("@Horario", DateTime.Now);
            comando.Parameters.AddWithValue("@Local", local_Acesso);

            comando.CommandText = "INSERT INTO Acessando (id_Registros, id_NP, id_TagRFID, EntradaSaida, Horario, Local )" +
                                  "VALUES( @id_Registros, @id_NP, @id_TagRFID, @EntradaSaida, @Horario, @Local); ";

            comando.ExecuteNonQuery();

            CriaTabelaAcesso();
        }

        //======================================================================

        private void DescarteAcesso()
        {
           
           SqlCeConnection conexao = new SqlCeConnection("Data Source =" + Vars.base_dados);
           conexao.Open();

           SqlCeCommand comando = new SqlCeCommand();
           comando.Connection = conexao;
           comando.CommandText = "DELETE FROM Acessando WHERE id_TagRFID =" + "'" + id_TagRFID + "'";
           comando.ExecuteNonQuery();
           comando.Dispose();
           conexao.Close();

           CriaTabelaAcesso();
        }

        //======================================================================

        private void cmd_pesquisar_Click(object sender, EventArgs e)
        {
            data_final.Value = data_final.Value.AddDays(1);
            string data_Inicial = data_inicial.Value.Date.ToString("yyy/MM/dd");
            string data_Final = data_final.Value.Date.ToString("yyy/MM/dd");

            data_final.Value = data_final.Value.AddDays(-1);

            data_Inicial = data_Inicial.Replace("/", "-");
            data_Final = data_Final.Replace("/", "-");



            SqlCeConnection conexao = new SqlCeConnection("Data Source =" + Vars.base_dados);
            conexao.Open();

            DataTable tabela_Data_Pesquisa = new DataTable();
            SqlCeCommand comando = new SqlCeCommand();
            comando.CommandText = " SELECT * FROM HistoricoAcesso WHERE Horario BETWEEN '" + data_Inicial + "' AND '" + data_Final + "'";
            comando.Connection = conexao;

            SqlCeDataAdapter escravo = new SqlCeDataAdapter();
            escravo.SelectCommand = comando;
            escravo.Fill(tabela_Data_Pesquisa);

            tabela_historico_acesso.DataSource = tabela_Data_Pesquisa;
            tabela_historico_acesso.Sort(tabela_historico_acesso.Columns["Horario"], ListSortDirection.Descending);

            tabela_historico_acesso.Columns["id_NP"].Width = CalcularLargura(20);
            tabela_historico_acesso.Columns["id_TagRFID"].Width = CalcularLargura(20);
            tabela_historico_acesso.Columns["EntradaSaida"].Width = CalcularLargura(20);
            tabela_historico_acesso.Columns["Horario"].Width = CalcularLargura(20);
            tabela_historico_acesso.Columns["Local"].Width = CalcularLargura(20);

            tabela_historico_acesso.DataSource = tabela_Data_Pesquisa;
            label_N_acessos.Text = "Nº Acessos: " + tabela_historico_acesso.Rows.Count;
        }

        //======================================================================

        private void cmd_atualizar_Click(object sender, EventArgs e)
        {
            CriaTabelaHistorico();
        }
      
        //======================================================================

        private void cmd_pesquisar_registros_Click(object sender, EventArgs e)
        {
            Executar_Pesquisa();

        }
        //======================================================================

        private void cmd_atualizar_registros_Click(object sender, EventArgs e)
        {
            CriaTabelaRegistros();
            CriaTabelaAcesso();
        }
        //======================================================================

        #region Evento de click arraste
        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            Arrastando = false;
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            Arrastando = true;
            ArrastarCursor = Cursor.Position;
            ArrastarForm = Location;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (Arrastando == true)
            {
                Point diferenca = Point.Subtract(Cursor.Position, new Size(ArrastarCursor));
                this.Location = Point.Add(ArrastarForm, new Size(diferenca));
            }
        }
        #endregion
        //======================================================================

        private void frmMenu_Load(object sender, EventArgs e)
        {
            // limpa seleção da tabela
            tabela_registros.ClearSelection();

            tabela_historico_acesso.ClearSelection();

            tabela_Acesso_Atual.ClearSelection();
        }

        // pesquisa ao pressionar enter
        private void text_pesquisar_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Executar_Pesquisa();
            }
        }

        private void Executar_Pesquisa()
        {
            SqlCeConnection conexao = new SqlCeConnection("Data Source =" + Vars.base_dados);
            conexao.Open();

            SqlCeCommand comando = new SqlCeCommand();
            comando.Parameters.AddWithValue("@Nome", "%" + text_pesquisar.Text + "%");
            comando.CommandText = "SELECT * FROM RegistrosColaboradores WHERE Nome LIKE @Nome";
            comando.Connection = conexao;

            SqlCeDataAdapter escravo = new SqlCeDataAdapter();
            escravo.SelectCommand = comando;

            DataTable dados_pesquisa = new DataTable();
            escravo.Fill(dados_pesquisa);

            tabela_registros.DataSource = dados_pesquisa;
            tabela_registros.Columns["id_TagRFID"].Visible = false;
            label_registros.Text = "Registros: " + tabela_registros.Rows.Count;
            tabela_registros.ClearSelection();
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SqlCeConnection conexao = new SqlCeConnection("Data Source = " + Vars.base_dados);
            conexao.Open();

            SqlCeCommand comando = new SqlCeCommand();
            comando.Connection = conexao;

            comando.CommandText = "SELECT * FROM Admin";

            DataTable verifica_Existencia_Admin = new DataTable();
            SqlCeDataAdapter escravo = new SqlCeDataAdapter();
            escravo.SelectCommand = comando;
            escravo.Fill(verifica_Existencia_Admin);
            // verifica se admin já foi adicionado
            if (verifica_Existencia_Admin.Rows.Count != 0)
            {
                // deixa visivel as opções de administrador 
                if (!status_Login)
                {
                    AutenticaçãoAdmin abrir = new AutenticaçãoAdmin();
                    abrir.ShowDialog();
                } else
                {
                    adicionarAdminToolStripMenuItem.Visible = true;
                    sairToolStripMenuItem.Visible = true;
                    localDoAcessoToolStripMenuItem.Visible = true;
                    toolStripSeparator1.Visible = true;
                    loginToolStripMenuItem.Text = AutenticaçãoAdmin.nome_admin;
                    loginToolStripMenuItem.Image = Properties.Resources.admin30x30;
                }
            }
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // oculta as opções de administrador quando é feito logout
            if(MessageBox.Show("Deseja fazer logout", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                adicionarAdminToolStripMenuItem.Visible = false;
                sairToolStripMenuItem.Visible = false;
                localDoAcessoToolStripMenuItem.Visible = false;
                toolStripSeparator1.Visible = false;
                status_Login = false;
                loginToolStripMenuItem.Text = "Login";
                loginToolStripMenuItem.Image = Properties.Resources.login30x30;
            }
        }

        private void adicionarAdminToolStripMenuItem_Click(object sender, EventArgs e) // abre a form para login
        {
            adicionarAdmin abrir = new adicionarAdmin();
            abrir.ShowDialog();

            verifica_Admin_Adicionado();
        }

        private void verifica_Admin_Adicionado() // verifica se ja foi adicionado um admin
        {
            SqlCeConnection conexao = new SqlCeConnection("Data Source = " + Vars.base_dados);
            conexao.Open();

            SqlCeCommand comando = new SqlCeCommand();
            comando.Connection = conexao;

            comando.CommandText = "SELECT * FROM Admin";

            DataTable verifica_Existencia_Admin = new DataTable();
            SqlCeDataAdapter escravo = new SqlCeDataAdapter();
            escravo.SelectCommand = comando;
            escravo.Fill(verifica_Existencia_Admin);
            // admin já foi adicionado oculta a opção adicionar admin
            if(verifica_Existencia_Admin.Rows.Count != 0)
            {
                adicionarAdminToolStripMenuItem.Visible = false;
                adicionarAdminToolStripMenuItem.Enabled = false;
            }
            
        }

        private void Led_Estadia_Porao()
        {
            SqlCeConnection conexao = new SqlCeConnection(@"Data Source = " + Vars.base_dados);
            conexao.Open();

            SqlCeCommand comando = new SqlCeCommand();
            comando.Connection = conexao;
            comando.CommandText = "SELECT * FROM Acessando WHERE Local = " + "'" + local_Acesso + "'";

            DataTable verifica_Estadia = new DataTable();

            SqlCeDataAdapter escravo = new SqlCeDataAdapter();
            escravo.SelectCommand = comando;
            escravo.Fill(verifica_Estadia);

            if(verifica_Estadia.Rows.Count != 0)
            {
                if (arduino.IsOpen)
                {
                    if (led_Ligado == false)
                    {
                        arduino.Write("L");
                        led_Ligado = true;
                    }
                }
            }
            else
            {
                if (arduino.IsOpen)
                {
                    if (led_Ligado == true)
                    {
                        arduino.Write("D");
                        led_Ligado = false;
                    }
                }
            }



        }

        private void localDoAcessoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Edita_Adiciona_Porao abrir = new Edita_Adiciona_Porao();
            abrir.ShowDialog();
        }

        private void exibir_Local_Acesso()
        {
            SqlCeConnection conexao = new SqlCeConnection(@"Data Source = " + Vars.baseDadosLocal);
            conexao.Open();

            SqlCeCommand comando = new SqlCeCommand();
            comando.Connection = conexao;
            comando.CommandText = "SELECT * FROM LocalAcesso";

            DataTable exibe_Local = new DataTable();

            SqlCeDataAdapter escravo = new SqlCeDataAdapter();
            escravo.SelectCommand = comando;
            escravo.Fill(exibe_Local);

            if (exibe_Local.Rows.Count != 0)
            {
                local_Acesso = exibe_Local.Rows[0][0].ToString();
            }
            else
            {
               local_Acesso = "LOCAL NAO ESPECIFICADO";
            }

        } 
    }
}
