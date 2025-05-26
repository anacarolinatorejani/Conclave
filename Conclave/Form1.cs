using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Conclave
{
    public partial class Conclave : Form
    {
        string[][] dados;
        
        public Conclave()
        {
            InitializeComponent();
            dados = new string[300][]; 
        }

        public void ReceberDados(string[][] dados)
        {
            this.dados = dados;
        }

        private void btGerenciar_Click(object sender, EventArgs e)
        {
            FrmGerenciar f = new FrmGerenciar(this, dados);
            f.Show();
            //this.Hide();
        }

        private void btResultado_Click(object sender, EventArgs e)
        {

        }

        private void btVotar_Click(object sender, EventArgs e)
        {
            FrmVotar f = new FrmVotar(this, dados);
            f.ShowDialog();
        }
    }
}
