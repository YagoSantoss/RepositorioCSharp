using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace teladeLogin
{
    public partial class frmTelaDeLogin : Form
    {
        string emailCorreto = "yago@gmail.com";
        string senhaCorreta = "yago123";
        int numeroTentativas = 0;
        const int MAX_TENTATIVAS = 3;

        public frmTelaDeLogin()
        {
            InitializeComponent();
        }

        private void panelOpacidade_Paint(object sender, PaintEventArgs e)
        {
        }

        private void frmTelaDeLogin_Load(object sender, EventArgs e)
        {
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            string emailDigitado = txtEmail.Text;
            string senhaDigitada = txtSenha.Text;

            while (numeroTentativas < MAX_TENTATIVAS)
            {
                numeroTentativas++;

                if (senhaDigitada == senhaCorreta)
                {
                    txtMensagem.Text = "Login bem-sucedido!";
                    txtMensagem.ForeColor = Color.Green;  // ← verde

                    txtEmail.Enabled = false;
                    txtSenha.Enabled = false;
                    btnEnviar.Enabled = false;
                    return;
                }
                else
                {
                    if (numeroTentativas >= MAX_TENTATIVAS)
                    {
                        txtMensagem.Text = "Tentativas finalizadas porque você errou todas";
                        txtMensagem.ForeColor = Color.Red;  // ← vermelho

                        txtEmail.Enabled = false;
                        txtSenha.Enabled = false;
                        btnEnviar.Enabled = false;
                    }
                    else
                    {
                        int tentativasRestantes = MAX_TENTATIVAS - numeroTentativas;
                        txtMensagem.Text = $"Senha incorreta,! Você tem {tentativasRestantes} tentativa(s) restante(s).";
                        txtMensagem.ForeColor = Color.Red;  // ← laranja

                        txtSenha.Clear();
                        txtSenha.Focus();
                    }

                    return;
                }
            }
            }
        

        private void txtMensagem_TextChanged(object sender, EventArgs e)
        {
        }
    }
}