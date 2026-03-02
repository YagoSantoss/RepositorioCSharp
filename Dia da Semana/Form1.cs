using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dia_da_Semana
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEnviar_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                var numero = Convert.ToInt16(txtResposta.Text);
                lblDia.Text = GetDiaSemana (numero);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha: " + ex.Message);

            }

        }

        private string GetDiaSemana (int numero)
        {
            var result  = "";

            switch (numero)
            {
                case 1:
                    result = "Domingo";
                    break;
                case 2:
                    result = "Segunda-Feira";
                    break;
                case 3:
                    result = "Terça-Feira";
                    break;
                case 4:
                    result = "Quarta_feira";
                    break;
                case 5:
                    result = "Quinta-Feira";
                    break;
                case 6:
                    result = "Sexta-Feira";
                    break;
                case 7:
                    result = "Sabado";
                    break;

                default:
                    result = "Inválido";
                    break;


            }
            return result;
        }

        private void txtResposta_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                
                try
                {
                    var numero = Convert.ToInt16(txtResposta.Text);
                    lblDia.Text = GetDiaSemana(numero);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Falha: " + ex.Message);

                }
            }
        }
    }
}
