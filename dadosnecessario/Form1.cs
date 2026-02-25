using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dadosnecessario
{
    public partial class frmFormularioSimples : Form
    {
        public frmFormularioSimples()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            int numeroCadastro;
            string nomeUsuario;
            DateTime dataNascimento;
            string cidade;
            bool generoF;
            bool generoM;
            bool generoNB;

            //validação de campos obrigatorios

            if (string.IsNullOrWhiteSpace(txtNumeroCadastrado.Text))
                    {
                MessageBox.Show("Por favor, preencha o número de cadastro.");
                return;

            }

            if (string.IsNullOrWhiteSpace(txtNomeCompleto.Text))
            {
                MessageBox.Show("Por favor, preencha o nome completo.");
                return;

            }
            if (comboBoxCidade.SelectedItem  == null)
            {

                MessageBox.Show("Por favor, selecione a cidade");
                return;
            }

            if(!rbFeminino.Checked && !rbMasculino.Checked && !rbNaoBinario.Checked)
            {
                MessageBox.Show("Por favor, selecione o genero. ");
                return;
            }

            //Agora, caso todos os campos estejam preenchidos, a validação prossegue
            numeroCadastro = Convert.ToInt32(txtNumeroCadastrado.Text);
            nomeUsuario = txtNomeCompleto.Text;
            dataNascimento = dateTimePicker1.Value;
            cidade = comboBoxCidade.Text;
            generoF = rbFeminino.Checked;
            generoM = rbMasculino.Checked;
            generoNB = rbNaoBinario.Checked;

            //formatar a data para exibir apenas a dada sem a hora

            string dataFormatada = dataNascimento.ToString("dd/MM/yyyy");

            // seleção de genero

            string generoSelecionado = "Não Informado";

            if (generoF)
                generoSelecionado = "Feminino";
            else if (generoM)
                generoSelecionado = "Masculino";
            else
                generoSelecionado = "Não binario";

            MessageBox.Show("Numero cadastrado: " + numeroCadastro);
            MessageBox.Show("Nome: " + nomeUsuario);
            MessageBox.Show("Data de Nascimento: " + dataFormatada);
            MessageBox.Show("Cidade: " + cidade);
            MessageBox.Show("Genero: " +  generoSelecionado);
            


        }

        private void txtNumeroCadastrado_Leave(object sender, EventArgs e)
        {
            txtNumeroCadastrado.Clear();
        }

        private void txtNomeCompleto_Leave(object sender, EventArgs e)
        {
            txtNomeCompleto.Clear();
        }
    }
}

