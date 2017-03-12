using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CorreiosWS ws = new CorreiosWS();

            try
            {
                maskCep.Enabled = false;
                btnBuscar.Enabled = false;
                ws.ConsultaCEP(maskCep.Text);
                MessageBox.Show(string.Format(@"Endereço: {0}
                       Complemento 1: {1}
                       Complemento 2: {2}
                       Bairro: {3}
                       Cidade: {4}
                       Estado: {5}",
                      ws.endERP.end,
                      ws.endERP.complemento,
                      ws.endERP.complemento2,
                      ws.endERP.bairro,
                      ws.endERP.cidade,
                      ws.endERP.uf));

                maskCep.Clear();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
            finally
            {
                maskCep.Enabled = true;
                btnBuscar.Enabled = true;
                maskCep.Select();
            }
        }

        private void maskCep_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                maskCep.Enabled = false;
                btnBuscar.Enabled = false;
                button1_Click(sender, e);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            maskCep.Select();
        }
    }
}
