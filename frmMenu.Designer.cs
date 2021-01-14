namespace ControleAcesso2019
{
    partial class frmMenu
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu));
            this.arduino = new System.IO.Ports.SerialPort(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tab_registros_colaboradores = new System.Windows.Forms.TabPage();
            this.label_registros = new System.Windows.Forms.Label();
            this.cmd_atualizar_registros = new System.Windows.Forms.PictureBox();
            this.cmd_pesquisar_registros = new System.Windows.Forms.PictureBox();
            this.text_pesquisar = new System.Windows.Forms.TextBox();
            this.tabela_registros = new System.Windows.Forms.DataGridView();
            this.tab_historico_acesso = new System.Windows.Forms.TabPage();
            this.label_N_acessos = new System.Windows.Forms.Label();
            this.data_final = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.data_inicial = new System.Windows.Forms.DateTimePicker();
            this.tabela_historico_acesso = new System.Windows.Forms.DataGridView();
            this.cmd_atualizar = new System.Windows.Forms.PictureBox();
            this.cmd_pesquisar = new System.Windows.Forms.PictureBox();
            this.tabela_acessando = new System.Windows.Forms.TabPage();
            this.tabela_Acesso_Atual = new System.Windows.Forms.DataGridView();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmd_MINIMIZAR = new System.Windows.Forms.PictureBox();
            this.cmd_FECHAR = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adicionarAdminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.localDoAcessoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmd_serial = new System.Windows.Forms.PictureBox();
            this.cmd_propriedades = new System.Windows.Forms.PictureBox();
            this.cmd_apagar = new System.Windows.Forms.PictureBox();
            this.cmd_editar = new System.Windows.Forms.PictureBox();
            this.cmd_adicionar = new System.Windows.Forms.PictureBox();
            this.tabControl1.SuspendLayout();
            this.tab_registros_colaboradores.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmd_atualizar_registros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmd_pesquisar_registros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabela_registros)).BeginInit();
            this.tab_historico_acesso.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabela_historico_acesso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmd_atualizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmd_pesquisar)).BeginInit();
            this.tabela_acessando.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabela_Acesso_Atual)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmd_MINIMIZAR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmd_FECHAR)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmd_serial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmd_propriedades)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmd_apagar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmd_editar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmd_adicionar)).BeginInit();
            this.SuspendLayout();
            // 
            // arduino
            // 
            this.arduino.PortName = "COM3";
            this.arduino.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.arduino_DataReceived);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tab_registros_colaboradores);
            this.tabControl1.Controls.Add(this.tab_historico_acesso);
            this.tabControl1.Controls.Add(this.tabela_acessando);
            this.tabControl1.Location = new System.Drawing.Point(77, 21);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(549, 353);
            this.tabControl1.TabIndex = 4;
            // 
            // tab_registros_colaboradores
            // 
            this.tab_registros_colaboradores.BackColor = System.Drawing.Color.White;
            this.tab_registros_colaboradores.Controls.Add(this.label_registros);
            this.tab_registros_colaboradores.Controls.Add(this.cmd_atualizar_registros);
            this.tab_registros_colaboradores.Controls.Add(this.cmd_pesquisar_registros);
            this.tab_registros_colaboradores.Controls.Add(this.text_pesquisar);
            this.tab_registros_colaboradores.Controls.Add(this.tabela_registros);
            this.tab_registros_colaboradores.Location = new System.Drawing.Point(4, 22);
            this.tab_registros_colaboradores.Name = "tab_registros_colaboradores";
            this.tab_registros_colaboradores.Padding = new System.Windows.Forms.Padding(3);
            this.tab_registros_colaboradores.Size = new System.Drawing.Size(541, 327);
            this.tab_registros_colaboradores.TabIndex = 0;
            this.tab_registros_colaboradores.Text = "Registros - Colaboradores";
            // 
            // label_registros
            // 
            this.label_registros.AutoSize = true;
            this.label_registros.Location = new System.Drawing.Point(455, 11);
            this.label_registros.Name = "label_registros";
            this.label_registros.Size = new System.Drawing.Size(63, 13);
            this.label_registros.TabIndex = 57;
            this.label_registros.Text = "Registros: 0";
            // 
            // cmd_atualizar_registros
            // 
            this.cmd_atualizar_registros.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmd_atualizar_registros.Image = global::ControleAcesso2019.Properties.Resources.icons8_actualizar_96;
            this.cmd_atualizar_registros.Location = new System.Drawing.Point(278, 3);
            this.cmd_atualizar_registros.Name = "cmd_atualizar_registros";
            this.cmd_atualizar_registros.Size = new System.Drawing.Size(23, 23);
            this.cmd_atualizar_registros.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cmd_atualizar_registros.TabIndex = 56;
            this.cmd_atualizar_registros.TabStop = false;
            this.cmd_atualizar_registros.Click += new System.EventHandler(this.cmd_atualizar_registros_Click);
            // 
            // cmd_pesquisar_registros
            // 
            this.cmd_pesquisar_registros.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmd_pesquisar_registros.Image = global::ControleAcesso2019.Properties.Resources.icons8_pesquisar_48;
            this.cmd_pesquisar_registros.Location = new System.Drawing.Point(249, 3);
            this.cmd_pesquisar_registros.Name = "cmd_pesquisar_registros";
            this.cmd_pesquisar_registros.Size = new System.Drawing.Size(23, 23);
            this.cmd_pesquisar_registros.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cmd_pesquisar_registros.TabIndex = 55;
            this.cmd_pesquisar_registros.TabStop = false;
            this.cmd_pesquisar_registros.Click += new System.EventHandler(this.cmd_pesquisar_registros_Click);
            // 
            // text_pesquisar
            // 
            this.text_pesquisar.Location = new System.Drawing.Point(3, 5);
            this.text_pesquisar.Name = "text_pesquisar";
            this.text_pesquisar.Size = new System.Drawing.Size(240, 20);
            this.text_pesquisar.TabIndex = 2;
            this.text_pesquisar.KeyUp += new System.Windows.Forms.KeyEventHandler(this.text_pesquisar_KeyUp);
            // 
            // tabela_registros
            // 
            this.tabela_registros.AllowUserToAddRows = false;
            this.tabela_registros.AllowUserToDeleteRows = false;
            this.tabela_registros.BackgroundColor = System.Drawing.Color.White;
            this.tabela_registros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabela_registros.Location = new System.Drawing.Point(3, 27);
            this.tabela_registros.MaximumSize = new System.Drawing.Size(535, 297);
            this.tabela_registros.MinimumSize = new System.Drawing.Size(535, 297);
            this.tabela_registros.MultiSelect = false;
            this.tabela_registros.Name = "tabela_registros";
            this.tabela_registros.ReadOnly = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.tabela_registros.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.tabela_registros.RowHeadersVisible = false;
            this.tabela_registros.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tabela_registros.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tabela_registros.Size = new System.Drawing.Size(535, 297);
            this.tabela_registros.TabIndex = 1;
            this.tabela_registros.TabStop = false;
            this.tabela_registros.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tabela_registros_CellClick);
            // 
            // tab_historico_acesso
            // 
            this.tab_historico_acesso.BackColor = System.Drawing.Color.White;
            this.tab_historico_acesso.Controls.Add(this.label_N_acessos);
            this.tab_historico_acesso.Controls.Add(this.data_final);
            this.tab_historico_acesso.Controls.Add(this.label2);
            this.tab_historico_acesso.Controls.Add(this.data_inicial);
            this.tab_historico_acesso.Controls.Add(this.tabela_historico_acesso);
            this.tab_historico_acesso.Controls.Add(this.cmd_atualizar);
            this.tab_historico_acesso.Controls.Add(this.cmd_pesquisar);
            this.tab_historico_acesso.Location = new System.Drawing.Point(4, 22);
            this.tab_historico_acesso.Name = "tab_historico_acesso";
            this.tab_historico_acesso.Padding = new System.Windows.Forms.Padding(3);
            this.tab_historico_acesso.Size = new System.Drawing.Size(541, 327);
            this.tab_historico_acesso.TabIndex = 1;
            this.tab_historico_acesso.Text = "Historico - Acesso";
            // 
            // label_N_acessos
            // 
            this.label_N_acessos.AutoSize = true;
            this.label_N_acessos.Location = new System.Drawing.Point(444, 10);
            this.label_N_acessos.Name = "label_N_acessos";
            this.label_N_acessos.Size = new System.Drawing.Size(74, 13);
            this.label_N_acessos.TabIndex = 58;
            this.label_N_acessos.Text = "Nº Acessos: 0";
            // 
            // data_final
            // 
            this.data_final.Checked = false;
            this.data_final.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.data_final.Location = new System.Drawing.Point(147, 4);
            this.data_final.Name = "data_final";
            this.data_final.Size = new System.Drawing.Size(96, 20);
            this.data_final.TabIndex = 53;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(108, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 23);
            this.label2.TabIndex = 52;
            this.label2.Text = "Até";
            // 
            // data_inicial
            // 
            this.data_inicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.data_inicial.Location = new System.Drawing.Point(0, 4);
            this.data_inicial.Name = "data_inicial";
            this.data_inicial.Size = new System.Drawing.Size(96, 20);
            this.data_inicial.TabIndex = 51;
            // 
            // tabela_historico_acesso
            // 
            this.tabela_historico_acesso.AllowUserToAddRows = false;
            this.tabela_historico_acesso.AllowUserToDeleteRows = false;
            this.tabela_historico_acesso.BackgroundColor = System.Drawing.Color.White;
            this.tabela_historico_acesso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabela_historico_acesso.Location = new System.Drawing.Point(3, 27);
            this.tabela_historico_acesso.MaximumSize = new System.Drawing.Size(535, 297);
            this.tabela_historico_acesso.MinimumSize = new System.Drawing.Size(535, 297);
            this.tabela_historico_acesso.MultiSelect = false;
            this.tabela_historico_acesso.Name = "tabela_historico_acesso";
            this.tabela_historico_acesso.ReadOnly = true;
            this.tabela_historico_acesso.RowHeadersVisible = false;
            this.tabela_historico_acesso.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tabela_historico_acesso.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tabela_historico_acesso.Size = new System.Drawing.Size(535, 297);
            this.tabela_historico_acesso.TabIndex = 1;
            this.tabela_historico_acesso.TabStop = false;
            this.tabela_historico_acesso.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tabela_historico_acesso_CellClick);
            // 
            // cmd_atualizar
            // 
            this.cmd_atualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmd_atualizar.Image = global::ControleAcesso2019.Properties.Resources.icons8_actualizar_96;
            this.cmd_atualizar.Location = new System.Drawing.Point(278, 3);
            this.cmd_atualizar.Name = "cmd_atualizar";
            this.cmd_atualizar.Size = new System.Drawing.Size(23, 23);
            this.cmd_atualizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cmd_atualizar.TabIndex = 55;
            this.cmd_atualizar.TabStop = false;
            this.cmd_atualizar.Click += new System.EventHandler(this.cmd_atualizar_Click);
            // 
            // cmd_pesquisar
            // 
            this.cmd_pesquisar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmd_pesquisar.Image = global::ControleAcesso2019.Properties.Resources.icons8_pesquisar_48;
            this.cmd_pesquisar.Location = new System.Drawing.Point(249, 3);
            this.cmd_pesquisar.Name = "cmd_pesquisar";
            this.cmd_pesquisar.Size = new System.Drawing.Size(23, 23);
            this.cmd_pesquisar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cmd_pesquisar.TabIndex = 54;
            this.cmd_pesquisar.TabStop = false;
            this.cmd_pesquisar.Click += new System.EventHandler(this.cmd_pesquisar_Click);
            // 
            // tabela_acessando
            // 
            this.tabela_acessando.Controls.Add(this.tabela_Acesso_Atual);
            this.tabela_acessando.Location = new System.Drawing.Point(4, 22);
            this.tabela_acessando.Name = "tabela_acessando";
            this.tabela_acessando.Size = new System.Drawing.Size(541, 327);
            this.tabela_acessando.TabIndex = 2;
            this.tabela_acessando.Text = "Acessando";
            this.tabela_acessando.UseVisualStyleBackColor = true;
            // 
            // tabela_Acesso_Atual
            // 
            this.tabela_Acesso_Atual.AllowUserToAddRows = false;
            this.tabela_Acesso_Atual.AllowUserToDeleteRows = false;
            this.tabela_Acesso_Atual.BackgroundColor = System.Drawing.Color.White;
            this.tabela_Acesso_Atual.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabela_Acesso_Atual.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabela_Acesso_Atual.Location = new System.Drawing.Point(0, 0);
            this.tabela_Acesso_Atual.MultiSelect = false;
            this.tabela_Acesso_Atual.Name = "tabela_Acesso_Atual";
            this.tabela_Acesso_Atual.ReadOnly = true;
            this.tabela_Acesso_Atual.RowHeadersVisible = false;
            this.tabela_Acesso_Atual.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tabela_Acesso_Atual.Size = new System.Drawing.Size(541, 327);
            this.tabela_Acesso_Atual.TabIndex = 1;
            this.tabela_Acesso_Atual.TabStop = false;
            this.tabela_Acesso_Atual.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tabela_Acesso_Atual_CellClick);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(94)))), ((int)(((byte)(186)))));
            this.panel1.Controls.Add(this.cmd_MINIMIZAR);
            this.panel1.Controls.Add(this.cmd_FECHAR);
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.MaximumSize = new System.Drawing.Size(630, 15);
            this.panel1.MinimumSize = new System.Drawing.Size(630, 15);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(630, 15);
            this.panel1.TabIndex = 7;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // cmd_MINIMIZAR
            // 
            this.cmd_MINIMIZAR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmd_MINIMIZAR.Image = global::ControleAcesso2019.Properties.Resources.transferir;
            this.cmd_MINIMIZAR.Location = new System.Drawing.Point(569, 0);
            this.cmd_MINIMIZAR.Name = "cmd_MINIMIZAR";
            this.cmd_MINIMIZAR.Size = new System.Drawing.Size(30, 15);
            this.cmd_MINIMIZAR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.cmd_MINIMIZAR.TabIndex = 1;
            this.cmd_MINIMIZAR.TabStop = false;
            this.cmd_MINIMIZAR.Click += new System.EventHandler(this.cmd_MINIMIZAR_Click);
            // 
            // cmd_FECHAR
            // 
            this.cmd_FECHAR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmd_FECHAR.Image = global::ControleAcesso2019.Properties.Resources.icons8_excluir_100;
            this.cmd_FECHAR.Location = new System.Drawing.Point(599, 0);
            this.cmd_FECHAR.Name = "cmd_FECHAR";
            this.cmd_FECHAR.Size = new System.Drawing.Size(30, 15);
            this.cmd_FECHAR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.cmd_FECHAR.TabIndex = 0;
            this.cmd_FECHAR.TabStop = false;
            this.cmd_FECHAR.Click += new System.EventHandler(this.cmd_FECHAR_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(586, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Sobre";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loginToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(374, 17);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(69, 24);
            this.menuStrip1.TabIndex = 59;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // loginToolStripMenuItem
            // 
            this.loginToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adicionarAdminToolStripMenuItem,
            this.localDoAcessoToolStripMenuItem,
            this.toolStripSeparator1,
            this.sairToolStripMenuItem});
            this.loginToolStripMenuItem.Image = global::ControleAcesso2019.Properties.Resources.login30x30;
            this.loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            this.loginToolStripMenuItem.Padding = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.loginToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.loginToolStripMenuItem.Text = "Login";
            this.loginToolStripMenuItem.Click += new System.EventHandler(this.loginToolStripMenuItem_Click);
            // 
            // adicionarAdminToolStripMenuItem
            // 
            this.adicionarAdminToolStripMenuItem.Image = global::ControleAcesso2019.Properties.Resources.adicinar30x30;
            this.adicionarAdminToolStripMenuItem.Name = "adicionarAdminToolStripMenuItem";
            this.adicionarAdminToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.adicionarAdminToolStripMenuItem.Text = "Adicionar Admin";
            this.adicionarAdminToolStripMenuItem.Click += new System.EventHandler(this.adicionarAdminToolStripMenuItem_Click);
            // 
            // localDoAcessoToolStripMenuItem
            // 
            this.localDoAcessoToolStripMenuItem.Image = global::ControleAcesso2019.Properties.Resources.portão;
            this.localDoAcessoToolStripMenuItem.Name = "localDoAcessoToolStripMenuItem";
            this.localDoAcessoToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.localDoAcessoToolStripMenuItem.Text = "Local do acesso";
            this.localDoAcessoToolStripMenuItem.Click += new System.EventHandler(this.localDoAcessoToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(161, 6);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Image = global::ControleAcesso2019.Properties.Resources.sair_30x30;
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // cmd_serial
            // 
            this.cmd_serial.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmd_serial.Image = global::ControleAcesso2019.Properties.Resources.icons8_usb_off_48;
            this.cmd_serial.Location = new System.Drawing.Point(12, 281);
            this.cmd_serial.Name = "cmd_serial";
            this.cmd_serial.Size = new System.Drawing.Size(48, 48);
            this.cmd_serial.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.cmd_serial.TabIndex = 5;
            this.cmd_serial.TabStop = false;
            this.cmd_serial.Click += new System.EventHandler(this.cmd_serial_Click);
            // 
            // cmd_propriedades
            // 
            this.cmd_propriedades.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmd_propriedades.Image = ((System.Drawing.Image)(resources.GetObject("cmd_propriedades.Image")));
            this.cmd_propriedades.Location = new System.Drawing.Point(12, 227);
            this.cmd_propriedades.Name = "cmd_propriedades";
            this.cmd_propriedades.Size = new System.Drawing.Size(48, 48);
            this.cmd_propriedades.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.cmd_propriedades.TabIndex = 3;
            this.cmd_propriedades.TabStop = false;
            this.cmd_propriedades.Click += new System.EventHandler(this.cmd_propriedades_Click);
            // 
            // cmd_apagar
            // 
            this.cmd_apagar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmd_apagar.Image = ((System.Drawing.Image)(resources.GetObject("cmd_apagar.Image")));
            this.cmd_apagar.Location = new System.Drawing.Point(12, 173);
            this.cmd_apagar.Name = "cmd_apagar";
            this.cmd_apagar.Size = new System.Drawing.Size(48, 48);
            this.cmd_apagar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.cmd_apagar.TabIndex = 2;
            this.cmd_apagar.TabStop = false;
            this.cmd_apagar.Click += new System.EventHandler(this.cmd_apagar_Click);
            // 
            // cmd_editar
            // 
            this.cmd_editar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmd_editar.Image = ((System.Drawing.Image)(resources.GetObject("cmd_editar.Image")));
            this.cmd_editar.Location = new System.Drawing.Point(12, 119);
            this.cmd_editar.Name = "cmd_editar";
            this.cmd_editar.Size = new System.Drawing.Size(48, 48);
            this.cmd_editar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.cmd_editar.TabIndex = 1;
            this.cmd_editar.TabStop = false;
            this.cmd_editar.Click += new System.EventHandler(this.cmd_editar_Click);
            // 
            // cmd_adicionar
            // 
            this.cmd_adicionar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmd_adicionar.Image = ((System.Drawing.Image)(resources.GetObject("cmd_adicionar.Image")));
            this.cmd_adicionar.Location = new System.Drawing.Point(12, 65);
            this.cmd_adicionar.Name = "cmd_adicionar";
            this.cmd_adicionar.Size = new System.Drawing.Size(48, 48);
            this.cmd_adicionar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.cmd_adicionar.TabIndex = 0;
            this.cmd_adicionar.TabStop = false;
            this.cmd_adicionar.Click += new System.EventHandler(this.cmd_adicionar_Click);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(628, 378);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cmd_serial);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.cmd_propriedades);
            this.Controls.Add(this.cmd_apagar);
            this.Controls.Add(this.cmd_editar);
            this.Controls.Add(this.cmd_adicionar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(630, 380);
            this.MinimumSize = new System.Drawing.Size(630, 380);
            this.Name = "frmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TransparencyKey = System.Drawing.Color.DarkRed;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMenu_FormClosed);
            this.Load += new System.EventHandler(this.frmMenu_Load);
            this.tabControl1.ResumeLayout(false);
            this.tab_registros_colaboradores.ResumeLayout(false);
            this.tab_registros_colaboradores.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmd_atualizar_registros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmd_pesquisar_registros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabela_registros)).EndInit();
            this.tab_historico_acesso.ResumeLayout(false);
            this.tab_historico_acesso.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabela_historico_acesso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmd_atualizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmd_pesquisar)).EndInit();
            this.tabela_acessando.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tabela_Acesso_Atual)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cmd_MINIMIZAR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmd_FECHAR)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmd_serial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmd_propriedades)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmd_apagar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmd_editar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmd_adicionar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort arduino;
        private System.Windows.Forms.PictureBox cmd_adicionar;
        private System.Windows.Forms.PictureBox cmd_editar;
        private System.Windows.Forms.PictureBox cmd_apagar;
        private System.Windows.Forms.PictureBox cmd_propriedades;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tab_registros_colaboradores;
        private System.Windows.Forms.TabPage tab_historico_acesso;
        private System.Windows.Forms.DataGridView tabela_historico_acesso;
        private System.Windows.Forms.DataGridView tabela_registros;
        private System.Windows.Forms.PictureBox cmd_serial;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox cmd_FECHAR;
        private System.Windows.Forms.PictureBox cmd_MINIMIZAR;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabela_acessando;
        private System.Windows.Forms.DataGridView tabela_Acesso_Atual;
        private System.Windows.Forms.PictureBox cmd_pesquisar;
        private System.Windows.Forms.DateTimePicker data_final;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker data_inicial;
        private System.Windows.Forms.PictureBox cmd_atualizar;
        private System.Windows.Forms.TextBox text_pesquisar;
        private System.Windows.Forms.PictureBox cmd_pesquisar_registros;
        private System.Windows.Forms.PictureBox cmd_atualizar_registros;
        private System.Windows.Forms.Label label_registros;
        private System.Windows.Forms.Label label_N_acessos;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adicionarAdminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem localDoAcessoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    }
}

