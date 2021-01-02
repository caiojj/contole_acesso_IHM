namespace ControleAcesso2019
{
    partial class adicionarAdmin
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.text_Usuario = new System.Windows.Forms.TextBox();
            this.cmd_login = new System.Windows.Forms.Button();
            this.cmd_fechar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.text_senha = new System.Windows.Forms.TextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Silver;
            this.panel2.Location = new System.Drawing.Point(11, 33);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(221, 1);
            this.panel2.TabIndex = 79;
            // 
            // text_Usuario
            // 
            this.text_Usuario.BackColor = System.Drawing.Color.White;
            this.text_Usuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.text_Usuario.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_Usuario.ForeColor = System.Drawing.Color.DarkGray;
            this.text_Usuario.Location = new System.Drawing.Point(11, 16);
            this.text_Usuario.Margin = new System.Windows.Forms.Padding(3, 3, 3, 5);
            this.text_Usuario.MaxLength = 20;
            this.text_Usuario.Name = "text_Usuario";
            this.text_Usuario.Size = new System.Drawing.Size(221, 18);
            this.text_Usuario.TabIndex = 73;
            this.text_Usuario.TabStop = false;
            this.text_Usuario.Text = "Usuário";
            this.text_Usuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.text_Usuario.MouseClick += new System.Windows.Forms.MouseEventHandler(this.text_Usuario_MouseClick);
            // 
            // cmd_login
            // 
            this.cmd_login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(94)))), ((int)(((byte)(186)))));
            this.cmd_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmd_login.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmd_login.ForeColor = System.Drawing.Color.Silver;
            this.cmd_login.Location = new System.Drawing.Point(8, 99);
            this.cmd_login.Name = "cmd_login";
            this.cmd_login.Size = new System.Drawing.Size(81, 26);
            this.cmd_login.TabIndex = 75;
            this.cmd_login.Text = "Adicionar";
            this.cmd_login.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.cmd_login.UseVisualStyleBackColor = false;
            this.cmd_login.Click += new System.EventHandler(this.cmd_login_Click);
            // 
            // cmd_fechar
            // 
            this.cmd_fechar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(94)))), ((int)(((byte)(186)))));
            this.cmd_fechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmd_fechar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmd_fechar.ForeColor = System.Drawing.Color.Silver;
            this.cmd_fechar.Location = new System.Drawing.Point(154, 99);
            this.cmd_fechar.Name = "cmd_fechar";
            this.cmd_fechar.Size = new System.Drawing.Size(81, 26);
            this.cmd_fechar.TabIndex = 76;
            this.cmd_fechar.Text = "Fechar";
            this.cmd_fechar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.cmd_fechar.UseVisualStyleBackColor = false;
            this.cmd_fechar.Click += new System.EventHandler(this.cmd_fechar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Location = new System.Drawing.Point(10, 59);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(221, 1);
            this.panel1.TabIndex = 78;
            // 
            // text_senha
            // 
            this.text_senha.BackColor = System.Drawing.Color.White;
            this.text_senha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.text_senha.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_senha.ForeColor = System.Drawing.Color.DarkGray;
            this.text_senha.Location = new System.Drawing.Point(10, 42);
            this.text_senha.Margin = new System.Windows.Forms.Padding(3, 3, 3, 5);
            this.text_senha.MaxLength = 10;
            this.text_senha.Name = "text_senha";
            this.text_senha.Size = new System.Drawing.Size(221, 18);
            this.text_senha.TabIndex = 74;
            this.text_senha.TabStop = false;
            this.text_senha.Text = "Digite a Senha";
            this.text_senha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.text_senha.MouseClick += new System.Windows.Forms.MouseEventHandler(this.text_senha_MouseClick);
            this.text_senha.TextChanged += new System.EventHandler(this.text_senha_TextChanged);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(94)))), ((int)(((byte)(186)))));
            this.panel6.Location = new System.Drawing.Point(-1, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(245, 10);
            this.panel6.TabIndex = 77;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Silver;
            this.panel3.Location = new System.Drawing.Point(11, 86);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(221, 1);
            this.panel3.TabIndex = 81;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.DarkGray;
            this.textBox1.Location = new System.Drawing.Point(11, 69);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 3, 3, 5);
            this.textBox1.MaxLength = 10;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(221, 18);
            this.textBox1.TabIndex = 80;
            this.textBox1.TabStop = false;
            this.textBox1.Text = "Digite a Senha";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBox1_MouseClick);
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // adicionarAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(243, 132);
            this.ControlBox = false;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.text_Usuario);
            this.Controls.Add(this.cmd_login);
            this.Controls.Add(this.cmd_fechar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.text_senha);
            this.Controls.Add(this.panel6);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximumSize = new System.Drawing.Size(243, 132);
            this.MinimumSize = new System.Drawing.Size(243, 132);
            this.Name = "adicionarAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox text_Usuario;
        private System.Windows.Forms.Button cmd_login;
        private System.Windows.Forms.Button cmd_fechar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox text_senha;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox textBox1;
    }
}