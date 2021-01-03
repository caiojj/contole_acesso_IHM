using System;
using System.IO.Ports;
using System.Windows.Forms;

namespace ControleAcesso2019
{
    public partial class MenuSerial : Form
    {
        public static string baud { get; set; }
        public static string data { get; set; }
        public static string parity { get; set; }
        public static string stop { get; set; }
        public static string port_com { get; set; }

        public MenuSerial()
        {
            InitializeComponent();
            AtualizacaoListaCOM();
        }


        private void salvar_serial_Click(object sender, EventArgs e)
        {
            baud = baud_rate.Text.ToString();
            data = textBox_data_bits.ToString();
            parity = boxParity.Text;
            stop = stop_bits.Text.ToString();
            port_com = port_name.Text.ToString();
        }

        private void button_cancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AtualizacaoListaCOM()  // Atualiza portas COM 
        {
            // se a quantidade mudar
            if (port_name.Items.Count == SerialPort.GetPortNames().Length)
            {
                return;

            }


            //limpa combobox
            port_name.Items.Clear();
            try
            {
                // adiciona todas as COM disponiveis na lista
                foreach (string s in SerialPort.GetPortNames())
                {
                    port_name.Items.Add(s);
                }

                port_name.SelectedIndex = 0;

            }
            catch
            {
                port_name.Text = "";
                MessageBox.Show("Favor Conectar o Arduino a Porta COM ", "Nenhuma Porta COM Encontrada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
