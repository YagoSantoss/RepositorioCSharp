using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calcularidade
{
    public partial class frmCalcularIdade : Form
    {
        public frmCalcularIdade()
        {
            InitializeComponent();
        }

        private void txtAnoAtual_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;

                int anoNascimento, anoAtual, idade;

                if(int.TryParse(txtAnoNasc.Text, out anoNascimento) && int.TryParse(txtAnoAtual.Text, out anoAtual))
                {
                    idade = anoAtual - anoNascimento;
                    lblIdade.Text = idade.ToString();
                }
                else
                {
                    MessageBox.Show("Digite numeros validos"); 
                }
            }
        }
    }
}
