using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControleAcesso2019
{
    partial class Sobre : Form
    {
        public Sobre()
        {
            InitializeComponent();
            SobreInfo();
        }

        private void SobreInfo()
        {
            label_nome_programa.Text = "Security Genuis(Provisório)";
            label_programador.Text = "Caio Júnior Leal Cândido";
            label_versao.Text = "v 1.0.0";
            text_descricao.Text = "Desenvolvido no ano de 2019 com o intuito de aplicação na Laminação PBT.\n " +
                                  "E-mail: caio18junior@gmail.com\n Np:39091090";
        }

        private void okButton_Click(object sender, EventArgs e)
        {

        }
    } 
}

