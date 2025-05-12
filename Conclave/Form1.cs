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

        private void button1_Click(object sender, EventArgs e)
        {
            FrmGerenciar f = new FrmGerenciar(this, dados);
            f.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
