namespace ControleAcesso2019
{
    partial class Sobre
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sobre));
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.logoPictureBox = new System.Windows.Forms.PictureBox();
            this.label_nome_programa = new System.Windows.Forms.Label();
            this.label_versao = new System.Windows.Forms.Label();
            this.label_programador = new System.Windows.Forms.Label();
            this.text_descricao = new System.Windows.Forms.TextBox();
            this.okButton = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.ColumnCount = 2;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 52.9976F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47.0024F));
            this.tableLayoutPanel.Controls.Add(this.logoPictureBox, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.label_nome_programa, 1, 0);
            this.tableLayoutPanel.Controls.Add(this.label_versao, 1, 1);
            this.tableLayoutPanel.Controls.Add(this.label_programador, 1, 2);
            this.tableLayoutPanel.Controls.Add(this.text_descricao, 1, 4);
            this.tableLayoutPanel.Controls.Add(this.okButton, 1, 5);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(9, 9);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 6;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.91513F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.91513F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.3321F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.952029F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(417, 271);
            this.tableLayoutPanel.TabIndex = 0;
            // 
            // logoPictureBox
            // 
            this.logoPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.logoPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("logoPictureBox.Image")));
            this.logoPictureBox.Location = new System.Drawing.Point(3, 3);
            this.logoPictureBox.Name = "logoPictureBox";
            this.tableLayoutPanel.SetRowSpan(this.logoPictureBox, 6);
            this.logoPictureBox.Size = new System.Drawing.Size(214, 265);
            this.logoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logoPictureBox.TabIndex = 12;
            this.logoPictureBox.TabStop = false;
            // 
            // label_nome_programa
            // 
            this.label_nome_programa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_nome_programa.Location = new System.Drawing.Point(226, 0);
            this.label_nome_programa.Margin = new System.Windows.Forms.Padding(6, 0, 3, 0);
            this.label_nome_programa.MaximumSize = new System.Drawing.Size(0, 17);
            this.label_nome_programa.Name = "label_nome_programa";
            this.label_nome_programa.Size = new System.Drawing.Size(188, 17);
            this.label_nome_programa.TabIndex = 19;
            this.label_nome_programa.Text = "Nome do Produto";
            this.label_nome_programa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_versao
            // 
            this.label_versao.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_versao.Location = new System.Drawing.Point(226, 35);
            this.label_versao.Margin = new System.Windows.Forms.Padding(6, 0, 3, 0);
            this.label_versao.MaximumSize = new System.Drawing.Size(0, 17);
            this.label_versao.Name = "label_versao";
            this.label_versao.Size = new System.Drawing.Size(188, 17);
            this.label_versao.TabIndex = 0;
            this.label_versao.Text = "Versão";
            this.label_versao.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_programador
            // 
            this.label_programador.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_programador.Location = new System.Drawing.Point(226, 70);
            this.label_programador.Margin = new System.Windows.Forms.Padding(6, 0, 3, 0);
            this.label_programador.MaximumSize = new System.Drawing.Size(0, 17);
            this.label_programador.Name = "label_programador";
            this.label_programador.Size = new System.Drawing.Size(188, 17);
            this.label_programador.TabIndex = 21;
            this.label_programador.Text = "Copyright";
            this.label_programador.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // text_descricao
            // 
            this.text_descricao.Dock = System.Windows.Forms.DockStyle.Fill;
            this.text_descricao.Location = new System.Drawing.Point(226, 109);
            this.text_descricao.Margin = new System.Windows.Forms.Padding(6, 3, 3, 3);
            this.text_descricao.Multiline = true;
            this.text_descricao.Name = "text_descricao";
            this.text_descricao.ReadOnly = true;
            this.text_descricao.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.text_descricao.Size = new System.Drawing.Size(188, 130);
            this.text_descricao.TabIndex = 23;
            this.text_descricao.TabStop = false;
            this.text_descricao.Text = "Descrição";
            // 
            // okButton
            // 
            this.okButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.okButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.okButton.Location = new System.Drawing.Point(339, 246);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 22);
            this.okButton.TabIndex = 24;
            this.okButton.Text = "&OK";
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(94)))), ((int)(((byte)(186)))));
            this.panel6.Location = new System.Drawing.Point(0, -4);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(437, 10);
            this.panel6.TabIndex = 32;
            // 
            // Sobre
            // 
            this.AcceptButton = this.okButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(435, 289);
            this.ControlBox = false;
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.tableLayoutPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Sobre";
            this.Padding = new System.Windows.Forms.Padding(9);
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.tableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.PictureBox logoPictureBox;
        private System.Windows.Forms.Label label_nome_programa;
        private System.Windows.Forms.Label label_versao;
        private System.Windows.Forms.Label label_programador;
        private System.Windows.Forms.TextBox text_descricao;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Panel panel6;
    }
}
