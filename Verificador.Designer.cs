namespace ControleAcesso2019
{
    partial class Verificador
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Timer timer1;
            this.label_nome_programanome = new System.Windows.Forms.Label();
            this.cmd_FECHAR = new System.Windows.Forms.PictureBox();
            this.cmd_cancelar = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.cmd_FECHAR)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label_nome_programanome
            // 
            this.label_nome_programanome.AutoSize = true;
            this.label_nome_programanome.BackColor = System.Drawing.Color.White;
            this.label_nome_programanome.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_nome_programanome.ForeColor = System.Drawing.Color.Black;
            this.label_nome_programanome.Location = new System.Drawing.Point(83, 42);
            this.label_nome_programanome.Name = "label_nome_programanome";
            this.label_nome_programanome.Size = new System.Drawing.Size(201, 16);
            this.label_nome_programanome.TabIndex = 0;
            this.label_nome_programanome.Text = "Por favor passe o cartão no leitor!";
            // 
            // cmd_FECHAR
            // 
            this.cmd_FECHAR.Image = global::ControleAcesso2019.Properties.Resources.icons8_brake_warning_48;
            this.cmd_FECHAR.Location = new System.Drawing.Point(31, 25);
            this.cmd_FECHAR.Name = "cmd_FECHAR";
            this.cmd_FECHAR.Size = new System.Drawing.Size(48, 48);
            this.cmd_FECHAR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.cmd_FECHAR.TabIndex = 1;
            this.cmd_FECHAR.TabStop = false;
            // 
            // cmd_cancelar
            // 
            this.cmd_cancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(94)))), ((int)(((byte)(186)))));
            this.cmd_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmd_cancelar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmd_cancelar.ForeColor = System.Drawing.Color.Silver;
            this.cmd_cancelar.Location = new System.Drawing.Point(198, 83);
            this.cmd_cancelar.Name = "cmd_cancelar";
            this.cmd_cancelar.Size = new System.Drawing.Size(81, 26);
            this.cmd_cancelar.TabIndex = 3;
            this.cmd_cancelar.Text = "Cancelar";
            this.cmd_cancelar.UseVisualStyleBackColor = false;
            this.cmd_cancelar.Click += new System.EventHandler(this.cmd_cancelar_Click);
            this.cmd_cancelar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmd_cancelar_KeyDown);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(94)))), ((int)(((byte)(186)))));
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(317, 5);
            this.panel6.TabIndex = 31;
            // 
            // Verificador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(315, 134);
            this.ControlBox = false;
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.cmd_cancelar);
            this.Controls.Add(this.cmd_FECHAR);
            this.Controls.Add(this.label_nome_programanome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(317, 136);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(317, 136);
            this.Name = "Verificador";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Verificador_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.cmd_FECHAR)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_nome_programanome;
        private System.Windows.Forms.PictureBox cmd_FECHAR;
        private System.Windows.Forms.Button cmd_cancelar;
        private System.Windows.Forms.Panel panel6;
    }
}