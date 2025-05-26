using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Conclave
{
    public partial class FrmVotar : Form
    {
        Conclave anterior;
        String[][] cardeais;
        public FrmVotar(Conclave anterior, string[][] cardeais)
        {
            InitializeComponent();
            this.anterior = anterior;
            this.cardeais = cardeais;
            Carregar();
        }

        void Carregar() 
        { 
            foreach (string[] dados in cardeais)
                if(dados != null)
                    lbxCardeais.Items.Add(dados[0]);
        }

        private void btVotar_Click(object sender, EventArgs e)
        {
            if(lbxCardeais.SelectedItems.Count != 1)
            {
                MessageBox.Show("Selecione apenas um nome!");
                return;
            }

            string nome = lbxCardeais.SelectedItem.ToString();
            int indice = Funcoes.Buscar(nome, cardeais);

            int votos = int.Parse(cardeais[indice][1]);
            votos++;
            cardeais[indice][1] = votos.ToString();

            anterior.ReceberDados(cardeais);
            this.Close();
        }
    }
}
