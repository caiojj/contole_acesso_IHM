namespace ControleAcesso2019
{
    partial class ColaboradorInfo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel6 = new System.Windows.Forms.Panel();
            this.cmd_fechar = new System.Windows.Forms.Button();
            this.label_nome_programanome = new System.Windows.Forms.Label();
            this.label_nome_programafacilitador = new System.Windows.Forms.Label();
            this.label_nome_programagerente = new System.Windows.Forms.Label();
            this.label_nome_programaidRFID = new System.Windows.Forms.Label();
            this.label_nome_programaidNP = new System.Windows.Forms.Label();
            this.tabela_INFO = new System.Windows.Forms.DataGridView();
            this.data_inicial = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.data_final = new System.Windows.Forms.DateTimePicker();
            this.cmd_pesquisar = new System.Windows.Forms.PictureBox();
            this.cmd_apagar_tudo = new System.Windows.Forms.PictureBox();
            this.cmd_atualizar = new System.Windows.Forms.PictureBox();
            this.label_N_acessos = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            ((System.ComponentModel.ISupportInitialize)(this.tabela_INFO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmd_pesquisar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmd_apagar_tudo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmd_atualizar)).BeginInit();
            this.SuspendLayout();
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(94)))), ((int)(((byte)(186)))));
            this.panel6.Location = new System.Drawing.Point(-1, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(416, 10);
            this.panel6.TabIndex = 31;
            // 
            // cmd_fechar
            // 
            this.cmd_fechar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(94)))), ((int)(((byte)(186)))));
            this.cmd_fechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmd_fechar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmd_fechar.ForeColor = System.Drawing.Color.Silver;
            this.cmd_fechar.Location = new System.Drawing.Point(322, 388);
            this.cmd_fechar.Name = "cmd_fechar";
            this.cmd_fechar.Size = new System.Drawing.Size(81, 26);
            this.cmd_fechar.TabIndex = 39;
            this.cmd_fechar.Text = "Fechar";
            this.cmd_fechar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.cmd_fechar.UseVisualStyleBackColor = false;
            this.cmd_fechar.Click += new System.EventHandler(this.cmd_fechar_Click);
            // 
            // label_nome_programanome
            // 
            this.label_nome_programanome.BackColor = System.Drawing.Color.White;
            this.label_nome_programanome.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_nome_programanome.Location = new System.Drawing.Point(12, 18);
            this.label_nome_programanome.Name = "label_nome_programanome";
            this.label_nome_programanome.Size = new System.Drawing.Size(390, 23);
            this.label_nome_programanome.TabIndex = 40;
            this.label_nome_programanome.Text = "Nome";
            // 
            // label_nome_programafacilitador
            // 
            this.label_nome_programafacilitador.BackColor = System.Drawing.Color.White;
            this.label_nome_programafacilitador.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_nome_programafacilitador.Location = new System.Drawing.Point(23, 41);
            this.label_nome_programafacilitador.Name = "label_nome_programafacilitador";
            this.label_nome_programafacilitador.Size = new System.Drawing.Size(379, 21);
            this.label_nome_programafacilitador.TabIndex = 41;
            this.label_nome_programafacilitador.Text = "Facilitador";
            // 
            // label_nome_programagerente
            // 
            this.label_nome_programagerente.BackColor = System.Drawing.Color.White;
            this.label_nome_programagerente.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_nome_programagerente.Location = new System.Drawing.Point(23, 62);
            this.label_nome_programagerente.Name = "label_nome_programagerente";
            this.label_nome_programagerente.Size = new System.Drawing.Size(379, 23);
            this.label_nome_programagerente.TabIndex = 42;
            this.label_nome_programagerente.Text = "Gerente";
            // 
            // label_nome_programaidRFID
            // 
            this.label_nome_programaidRFID.BackColor = System.Drawing.Color.White;
            this.label_nome_programaidRFID.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_nome_programaidRFID.Location = new System.Drawing.Point(23, 85);
            this.label_nome_programaidRFID.Name = "label_nome_programaidRFID";
            this.label_nome_programaidRFID.Size = new System.Drawing.Size(167, 23);
            this.label_nome_programaidRFID.TabIndex = 43;
            this.label_nome_programaidRFID.Text = "TagRFID";
            // 
            // label_nome_programaidNP
            // 
            this.label_nome_programaidNP.BackColor = System.Drawing.Color.White;
            this.label_nome_programaidNP.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_nome_programaidNP.Location = new System.Drawing.Point(199, 85);
            this.label_nome_programaidNP.Name = "label_nome_programaidNP";
            this.label_nome_programaidNP.Size = new System.Drawing.Size(203, 23);
            this.label_nome_programaidNP.TabIndex = 44;
            this.label_nome_programaidNP.Text = "ID_NP";
            // 
            // tabela_INFO
            // 
            this.tabela_INFO.AllowUserToAddRows = false;
            this.tabela_INFO.AllowUserToDeleteRows = false;
            this.tabela_INFO.BackgroundColor = System.Drawing.Color.White;
            this.tabela_INFO.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tabela_INFO.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabela_INFO.Location = new System.Drawing.Point(-1, 143);
            this.tabela_INFO.MultiSelect = false;
            this.tabela_INFO.Name = "tabela_INFO";
            this.tabela_INFO.ReadOnly = true;
            this.tabela_INFO.RowHeadersVisible = false;
            this.tabela_INFO.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tabela_INFO.Size = new System.Drawing.Size(416, 239);
            this.tabela_INFO.TabIndex = 0;
            this.tabela_INFO.TabStop = false;
            // 
            // data_inicial
            // 
            this.data_inicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.data_inicial.Location = new System.Drawing.Point(16, 119);
            this.data_inicial.Name = "data_inicial";
            this.data_inicial.Size = new System.Drawing.Size(96, 20);
            this.data_inicial.TabIndex = 47;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(118, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 23);
            this.label1.TabIndex = 48;
            this.label1.Text = "Até";
            // 
            // data_final
            // 
            this.data_final.Checked = false;
            this.data_final.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.data_final.Location = new System.Drawing.Point(157, 120);
            this.data_final.Name = "data_final";
            this.data_final.Size = new System.Drawing.Size(96, 20);
            this.data_final.TabIndex = 49;
            // 
            // cmd_pesquisar
            // 
            this.cmd_pesquisar.BackColor = System.Drawing.Color.White;
            this.cmd_pesquisar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmd_pesquisar.Image = global::ControleAcesso2019.Properties.Resources.icons8_pesquisar_48;
            this.cmd_pesquisar.Location = new System.Drawing.Point(259, 117);
            this.cmd_pesquisar.Name = "cmd_pesquisar";
            this.cmd_pesquisar.Size = new System.Drawing.Size(23, 23);
            this.cmd_pesquisar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cmd_pesquisar.TabIndex = 50;
            this.cmd_pesquisar.TabStop = false;
            this.cmd_pesquisar.Click += new System.EventHandler(this.cmd_pesquisar_Click);
            // 
            // cmd_apagar_tudo
            // 
            this.cmd_apagar_tudo.BackColor = System.Drawing.Color.White;
            this.cmd_apagar_tudo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmd_apagar_tudo.Image = global::ControleAcesso2019.Properties.Resources.icons8_excluir_480;
            this.cmd_apagar_tudo.Location = new System.Drawing.Point(365, 115);
            this.cmd_apagar_tudo.Name = "cmd_apagar_tudo";
            this.cmd_apagar_tudo.Size = new System.Drawing.Size(50, 25);
            this.cmd_apagar_tudo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.cmd_apagar_tudo.TabIndex = 46;
            this.cmd_apagar_tudo.TabStop = false;
            this.cmd_apagar_tudo.Click += new System.EventHandler(this.cmd_apagar_tudo_Click);
            // 
            // cmd_atualizar
            // 
            this.cmd_atualizar.BackColor = System.Drawing.Color.White;
            this.cmd_atualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmd_atualizar.Image = global::ControleAcesso2019.Properties.Resources.icons8_actualizar_96;
            this.cmd_atualizar.Location = new System.Drawing.Point(336, 115);
            this.cmd_atualizar.Name = "cmd_atualizar";
            this.cmd_atualizar.Size = new System.Drawing.Size(23, 23);
            this.cmd_atualizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cmd_atualizar.TabIndex = 56;
            this.cmd_atualizar.TabStop = false;
            this.cmd_atualizar.Click += new System.EventHandler(this.cmd_atualizar_Click);
            // 
            // label_N_acessos
            // 
            this.label_N_acessos.AutoSize = true;
            this.label_N_acessos.BackColor = System.Drawing.Color.White;
            this.label_N_acessos.Location = new System.Drawing.Point(12, 401);
            this.label_N_acessos.Name = "label_N_acessos";
            this.label_N_acessos.Size = new System.Drawing.Size(74, 13);
            this.label_N_acessos.TabIndex = 59;
            this.label_N_acessos.Text = "Nº Acessos: 0";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(414, 418);
            this.menuStrip1.TabIndex = 60;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ColaboradorInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 418);
            this.ControlBox = false;
            this.Controls.Add(this.label_N_acessos);
            this.Controls.Add(this.cmd_atualizar);
            this.Controls.Add(this.cmd_pesquisar);
            this.Controls.Add(this.data_final);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.data_inicial);
            this.Controls.Add(this.cmd_apagar_tudo);
            this.Controls.Add(this.tabela_INFO);
            this.Controls.Add(this.label_nome_programaidNP);
            this.Controls.Add(this.label_nome_programaidRFID);
            this.Controls.Add(this.label_nome_programagerente);
            this.Controls.Add(this.label_nome_programafacilitador);
            this.Controls.Add(this.label_nome_programanome);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.cmd_fechar);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ColaboradorInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.ColaboradorInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tabela_INFO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmd_pesquisar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmd_apagar_tudo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmd_atualizar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button cmd_fechar;
        private System.Windows.Forms.Label label_nome_programanome;
        private System.Windows.Forms.Label label_nome_programafacilitador;
        private System.Windows.Forms.Label label_nome_programagerente;
        private System.Windows.Forms.Label label_nome_programaidRFID;
        private System.Windows.Forms.Label label_nome_programaidNP;
        private System.Windows.Forms.DataGridView tabela_INFO;
        private System.Windows.Forms.PictureBox cmd_apagar_tudo;
        private System.Windows.Forms.DateTimePicker data_inicial;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker data_final;
        private System.Windows.Forms.PictureBox cmd_pesquisar;
        private System.Windows.Forms.PictureBox cmd_atualizar;
        private System.Windows.Forms.Label label_N_acessos;
        private System.Windows.Forms.MenuStrip menuStrip1;
    }
}