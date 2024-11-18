using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fibonacci
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente sair?", "Sair", MessageBoxButtons.YesNo) == DialogResult.Yes)
                Close();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int start = 0; 
            int proximo_numero = 1; 
            int soma;
            lsbResultado.Items.Clear();

            for (int i = 2; i <= 30; i++)
            {
                soma = start + proximo_numero;
                lsbResultado.Items.Add(soma);

                start = proximo_numero;
                proximo_numero = soma;
            }
        }
    }
}
