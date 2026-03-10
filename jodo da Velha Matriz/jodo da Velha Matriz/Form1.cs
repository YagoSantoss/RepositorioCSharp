using System;
using System.Windows.Forms;

namespace jodo_da_Velha_Matriz
{
    public partial class Form1 : Form
    {
        bool vezDoX;
        int jogadas;
        bool jogoEncerrado;

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            if (jogoEncerrado)
                return;

            Button btn = (Button)sender;

            // impede clicar duas vezes
            if (btn.BackgroundImage != null)
                return;

            // coloca imagem e define jogador
            if (vezDoX)
            {
                btn.BackgroundImage = Properties.Resources.java;
                btn.Tag = "Java";
            }
            else
            {
                btn.BackgroundImage = Properties.Resources.csharp;
                btn.Tag = "C#";
            }

            btn.BackgroundImageLayout = ImageLayout.Stretch;

            jogadas++;

            if (verificarVencedor())
            {
                lblStatus.Text = $"Jogador {(vezDoX ? "Java" : "C#")} venceu!";
                jogoEncerrado = true;
            }
            else if (jogadas == 9)
            {
                lblStatus.Text = "Empate!";
                jogoEncerrado = true;
            }
            else
            {
                vezDoX = !vezDoX;
                lblStatus.Text = $"Vez do jogador {(vezDoX ? "Java" : "C#")}";
            }
        }

        private bool verificarVencedor()
        {
            string[,] matriz = new string[3, 3]
            {
                { btn1.Tag?.ToString() ?? "", btn2.Tag?.ToString() ?? "", btn3.Tag?.ToString() ?? "" },
                { btn4.Tag?.ToString() ?? "", btn5.Tag?.ToString() ?? "", btn6.Tag?.ToString() ?? "" },
                { btn7.Tag?.ToString() ?? "", btn8.Tag?.ToString() ?? "", btn9.Tag?.ToString() ?? "" }
            };

            for (int i = 0; i < 3; i++)
            {
                // linhas
                if (matriz[i, 0] != "" && matriz[i, 0] == matriz[i, 1] && matriz[i, 1] == matriz[i, 2])
                    return true;

                // colunas
                if (matriz[0, i] != "" && matriz[0, i] == matriz[1, i] && matriz[1, i] == matriz[2, i])
                    return true;
            }

            // diagonais
            if (matriz[0, 0] != "" && matriz[0, 0] == matriz[1, 1] && matriz[1, 1] == matriz[2, 2])
                return true;

            if (matriz[0, 2] != "" && matriz[0, 2] == matriz[1, 1] && matriz[1, 1] == matriz[2, 0])
                return true;

            return false;
        }

        private void btnResetar_Click(object sender, EventArgs e)
        {
            foreach (Control c in Controls)
            {
                if (c is Button btn && btn.Name != "btnResetar")
                {
                    btn.BackgroundImage = null;
                    btn.Tag = null;
                }
            }

            vezDoX = false;
            jogadas = 0;
            jogoEncerrado = false;
            lblStatus.Text = "Vez do jogador C#";
        }
    }
}