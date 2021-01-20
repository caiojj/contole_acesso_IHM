
namespace ControleAcesso2019
{
    partial class MenuSerial
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmd_MINIMIZAR = new System.Windows.Forms.PictureBox();
            this.cmd_FECHAR = new System.Windows.Forms.PictureBox();
            this.salvar_serial = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label_baud_rate = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_data_bits = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.port_name = new System.Windows.Forms.ComboBox();
            this.button_cancelar = new System.Windows.Forms.Button();
            this.stop_bits = new System.Windows.Forms.ComboBox();
            this.boxParity = new System.Windows.Forms.ComboBox();
            this.baud_rate = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmd_MINIMIZAR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmd_FECHAR)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(94)))), ((int)(((byte)(186)))));
            this.panel1.Controls.Add(this.cmd_MINIMIZAR);
            this.panel1.Controls.Add(this.cmd_FECHAR);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.MaximumSize = new System.Drawing.Size(450, 15);
            this.panel1.MinimumSize = new System.Drawing.Size(450, 15);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(450, 15);
            this.panel1.TabIndex = 8;
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
            // 
            // salvar_serial
            // 
            this.salvar_serial.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(94)))), ((int)(((byte)(186)))));
            this.salvar_serial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.salvar_serial.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salvar_serial.ForeColor = System.Drawing.Color.Silver;
            this.salvar_serial.Location = new System.Drawing.Point(12, 180);
            this.salvar_serial.Name = "salvar_serial";
            this.salvar_serial.Size = new System.Drawing.Size(179, 26);
            this.salvar_serial.TabIndex = 39;
            this.salvar_serial.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.salvar_serial.UseVisualStyleBackColor = false;
            this.salvar_serial.Click += new System.EventHandler(this.salvar_serial_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Silver;
            this.panel2.Location = new System.Drawing.Point(90, 42);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(348, 1);
            this.panel2.TabIndex = 51;
            // 
            // label_baud_rate
            // 
            this.label_baud_rate.AccessibleName = "baud_rate";
            this.label_baud_rate.AutoSize = true;
            this.label_baud_rate.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_baud_rate.ForeColor = System.Drawing.Color.Black;
            this.label_baud_rate.Location = new System.Drawing.Point(9, 27);
            this.label_baud_rate.Name = "label_baud_rate";
            this.label_baud_rate.Size = new System.Drawing.Size(75, 16);
            this.label_baud_rate.TabIndex = 50;
            this.label_baud_rate.Text = "Baud Rate";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Silver;
            this.panel3.Location = new System.Drawing.Point(90, 70);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(348, 1);
            this.panel3.TabIndex = 54;
            // 
            // label1
            // 
            this.label1.AccessibleName = "baud_rate";
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(9, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 16);
            this.label1.TabIndex = 53;
            this.label1.Text = "Data Bits";
            // 
            // textBox_data_bits
            // 
            this.textBox_data_bits.BackColor = System.Drawing.Color.White;
            this.textBox_data_bits.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_data_bits.Font = new System.Drawing.Font("Arial", 8.25F);
            this.textBox_data_bits.ForeColor = System.Drawing.Color.Black;
            this.textBox_data_bits.Location = new System.Drawing.Point(94, 49);
            this.textBox_data_bits.Margin = new System.Windows.Forms.Padding(3, 3, 3, 5);
            this.textBox_data_bits.MaxLength = 50;
            this.textBox_data_bits.Name = "textBox_data_bits";
            this.textBox_data_bits.Size = new System.Drawing.Size(344, 13);
            this.textBox_data_bits.TabIndex = 52;
            this.textBox_data_bits.Text = "8";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Silver;
            this.panel4.Location = new System.Drawing.Point(90, 98);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(348, 1);
            this.panel4.TabIndex = 57;
            // 
            // label2
            // 
            this.label2.AccessibleName = "baud_rate";
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(9, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 56;
            this.label2.Text = "Parity";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Silver;
            this.panel5.Location = new System.Drawing.Point(90, 126);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(348, 1);
            this.panel5.TabIndex = 60;
            // 
            // label3
            // 
            this.label3.AccessibleName = "baud_rate";
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(9, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 16);
            this.label3.TabIndex = 59;
            this.label3.Text = "Stop Bits";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Silver;
            this.panel6.Location = new System.Drawing.Point(92, 160);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(348, 1);
            this.panel6.TabIndex = 63;
            // 
            // label4
            // 
            this.label4.AccessibleName = "baud_rate";
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(11, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 16);
            this.label4.TabIndex = 62;
            this.label4.Text = "Port Name";
            // 
            // port_name
            // 
            this.port_name.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.port_name.FormattingEnabled = true;
            this.port_name.Items.AddRange(new object[] {
            "COM 1"});
            this.port_name.Location = new System.Drawing.Point(92, 137);
            this.port_name.Name = "port_name";
            this.port_name.Size = new System.Drawing.Size(346, 21);
            this.port_name.TabIndex = 65;
            // 
            // button_cancelar
            // 
            this.button_cancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(94)))), ((int)(((byte)(186)))));
            this.button_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_cancelar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_cancelar.ForeColor = System.Drawing.Color.Silver;
            this.button_cancelar.Location = new System.Drawing.Point(259, 180);
            this.button_cancelar.Name = "button_cancelar";
            this.button_cancelar.Size = new System.Drawing.Size(179, 26);
            this.button_cancelar.TabIndex = 66;
            this.button_cancelar.Text = "Cancelar";
            this.button_cancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button_cancelar.UseVisualStyleBackColor = false;
            this.button_cancelar.Click += new System.EventHandler(this.button_cancelar_Click);
            // 
            // stop_bits
            // 
            this.stop_bits.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stop_bits.FormattingEnabled = true;
            this.stop_bits.Items.AddRange(new object[] {
            "One",
            "Two",
            "OnePointeFive"});
            this.stop_bits.Location = new System.Drawing.Point(90, 103);
            this.stop_bits.Name = "stop_bits";
            this.stop_bits.Size = new System.Drawing.Size(346, 21);
            this.stop_bits.TabIndex = 67;
            this.stop_bits.Text = "One";
            // 
            // boxParity
            // 
            this.boxParity.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.boxParity.FormattingEnabled = true;
            this.boxParity.Items.AddRange(new object[] {
            "None",
            "Odd",
            "Even",
            "Mark",
            "Space"});
            this.boxParity.Location = new System.Drawing.Point(90, 75);
            this.boxParity.Name = "boxParity";
            this.boxParity.Size = new System.Drawing.Size(346, 21);
            this.boxParity.TabIndex = 68;
            this.boxParity.Text = "None";
            // 
            // baud_rate
            // 
            this.baud_rate.DisplayMember = "vcxzv";
            this.baud_rate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.baud_rate.FormattingEnabled = true;
            this.baud_rate.Items.AddRange(new object[] {
            "1200",
            "2400",
            "4800",
            "9600",
            "14400",
            "19200",
            "28800",
            "31250",
            "38400",
            "57600",
            "115200"});
            this.baud_rate.Location = new System.Drawing.Point(92, 19);
            this.baud_rate.Name = "baud_rate";
            this.baud_rate.Size = new System.Drawing.Size(346, 21);
            this.baud_rate.TabIndex = 69;
            this.baud_rate.Text = "9600";
            // 
            // MenuSerial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(448, 208);
            this.ControlBox = false;
            this.Controls.Add(this.baud_rate);
            this.Controls.Add(this.boxParity);
            this.Controls.Add(this.stop_bits);
            this.Controls.Add(this.button_cancelar);
            this.Controls.Add(this.port_name);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_data_bits);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label_baud_rate);
            this.Controls.Add(this.salvar_serial);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(450, 210);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(450, 210);
            this.Name = "MenuSerial";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cmd_MINIMIZAR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmd_FECHAR)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox cmd_MINIMIZAR;
        private System.Windows.Forms.PictureBox cmd_FECHAR;
        private System.Windows.Forms.Button salvar_serial;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label_baud_rate;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_data_bits;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox port_name;
        private System.Windows.Forms.Button button_cancelar;
        private System.Windows.Forms.ComboBox stop_bits;
        private System.Windows.Forms.ComboBox boxParity;
        private System.Windows.Forms.ComboBox baud_rate;
    }
}