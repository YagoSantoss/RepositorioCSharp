using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Verificação_de_Estoque
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEnviar_MouseClick(object sender, MouseEventArgs e)
        {
            var quantidade = Convert.ToInt32(txtResposta.Text);

            if (quantidade < 5)
            {
                MessageBox.Show(" Alerta: Baixo estoque. Por favor, reabasteça este produto");
            }
            else
            {
                MessageBox.Show("Estoque Suficiente!");

            }
        }
    }
}
