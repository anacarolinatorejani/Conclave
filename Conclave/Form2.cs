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
    public partial class FrmGerenciar : Form
    {
        string[][] dados;
        Conclave anterior;
        public FrmGerenciar(Conclave anterior, string[][] dados)
        {
            InitializeComponent();
            this.anterior = anterior;
            this.dados = dados;
            Atualizar();
        }

        int Length(string[][] v)
        {
            int q = 0;
            for (int i = 0; i < v.Length; i++)
            {
                if (v[i] != null)
                    q++;    
            }
            return q;
        }

        int Buscar(string nome)
        {
            int indice;
            for (indice = 0; indice < Length(dados) && dados[indice][0] != nome; indice++) ;
            if (indice < Length(dados))
                return indice;
            return -1;
        }

        private void FrmGerenciar_FormClosing(object sender, FormClosingEventArgs e)
        {
            anterior.ReceberDados(dados);
            anterior.Show();
        }

        void Atualizar()
        {
            dgvCardeais.Rows.Clear();
            for (int i = 0;i < Length(dados); i++)
            {
                DataGridViewRow linha = new DataGridViewRow();
                linha.CreateCells(dgvCardeais);
                linha.Cells[0].Value = dados[i][0];
                dgvCardeais.Rows.Add(linha);
            }
        }

        private void btAdicionar_Click(object sender, EventArgs e)
        {
            if (Length(dados) == dados.Length)
            {
                MessageBox.Show("Lista cheia!");
            }

            string nome = txtNome.Text.Trim();

            if (String.IsNullOrEmpty(nome))
            {
                MessageBox.Show("Insira um nome válido!");
                return;
            }

            if (Funcoes.Buscar(nome, dados) > -1)
            {
                MessageBox.Show($"{nome} já cadastrado");
                return;
            }
            dados[Funcoes.Length(dados)] = new string[]{nome, "0"};

            Atualizar();
            txtNome.Text = "";
        }

        private void btRemover_Click(object sender, EventArgs e)
        {
            if (dgvCardeais.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione um cardeal para remover");
                return;
            }

            int rowIndex = dgvCardeais.SelectedRows[0].Index;
            string nome = dgvCardeais.Rows[rowIndex].Cells[0].Value.ToString();

            DialogResult confirm = MessageBox.Show($"Deseja remover o cardeal {nome}?", "Confirmar Remoção", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirm == DialogResult.Yes)
            {
                int indice = Funcoes.Buscar(nome, dados);
                if (indice != -1)
                {
                    // Remanejar elementos para frente
                    for (int i = indice; i < Funcoes.Length(dados) - 1; i++)
                    {
                        dados[i] = dados[i + 1];
                    }

                    dados[Funcoes.Length(dados) - 1] = null; // Limpa último
                    Atualizar();
                }
            }
        }
    }
}

