using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControleAcesso2019
{

    public partial class Verificador : Form
    {
        public static bool verifica_Froms_Aberta { set; get; }
        public static bool  verifica_Valor_Tag {set; get;}
        public Verificador()
        {
            InitializeComponent();
            verifica_Froms_Aberta = true;
        }

        private void cmd_cancelar_Click(object sender, EventArgs e)
        {

            Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            if ( frmMenu.id_TagRFID != null)
            {
                verifica_Valor_Tag = true;
                Close();
            }

        }

        private void cmd_cancelar_KeyDown(object sender, KeyEventArgs e)
        {
            if ((Keys) e.KeyValue == Keys.Escape)
            {
                Close();
            }
        }

        private void Verificador_FormClosed(object sender, FormClosedEventArgs e)
        {
            verifica_Froms_Aberta = false;
        }
    }
}
