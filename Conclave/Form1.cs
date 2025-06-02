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
            DialogResult confirm = MessageBox.Show("Deseja encerrar a votação?", "Encerrar Votação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm == DialogResult.No) return;

            int totalVotos = 0;
            for (int i = 0; i < Funcoes.Length(dados); i++)
            {
                totalVotos += int.Parse(dados[i][1]);
            }

            if (totalVotos == 0)
            {
                MessageBox.Show("Nenhum voto registrado");
                return;
            }

            int doisTercos = (int)Math.Ceiling((2.0 / 3.0) * totalVotos);
            string eleito = null;

            for (int i = 0; i < Funcoes.Length(dados); i++)
            {
                int votos = int.Parse(dados[i][1]);
                if (votos >= doisTercos)
                {
                    eleito = dados[i][0];
                    break;
                }
            }

            if (eleito == null)
            {
                MessageBox.Show("Não houve vitorioso.");
                // Zerar votos
                for (int i = 0; i < Funcoes.Length(dados); i++)
                {
                    dados[i][1] = "0";
                }
                return;
            }

            DialogResult aceite = MessageBox.Show($"{eleito} foi eleito. Você aceita a eleição canônica à Sumo Pontífice?", "Eleição", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (aceite == DialogResult.Yes)
            {
                MessageBox.Show("HABEMUS PAPAM!", "Resultado Final");
                dados = new string[300][];
            }
            else
            {
                for (int i = 0; i < Funcoes.Length(dados); i++)
                {
                    dados[i][1] = "0";
                }
            }

        }

        private void btVotar_Click(object sender, EventArgs e)
        {
            FrmVotar f = new FrmVotar(this, dados);
            f.ShowDialog();
        }
    }
}
