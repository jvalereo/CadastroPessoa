using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Globalization;
using CadastroPessoaOOP.Classe.Dados;

namespace CadastroPessoaOOP
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            //Treinamento, Programação Orientação ao Objeto
            //Inserindo dados, string, int, double
            //Programa, basico, cadastro de pessoas
            //Jonas Valereo - Técnico em Informática

            //declarando, validando as textbox, combBox, mask, usando if

            //validar textBoxNome
            if (textBoxNome.Text == "")
            {
                MessageBox.Show("Digite seu nome", "Preencha o campo!",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);

                textBoxNome.BackColor = Color.Aqua;
                textBoxNome.Focus();

                return;
            }

            //valida textBoxSobrenome
            if (textBoxSobrenome.Text == "")
            {
                MessageBox.Show("Digite seu sobrenome", "Preencha o campo!",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);

                textBoxSobrenome.BackColor = Color.Aqua;
                textBoxSobrenome.Focus();

                return;
            }

            //validar textBoIdade
            if (textBoxIdade.Text == "")
            {
                MessageBox.Show("Digite sua idade", "Prencha o campo!",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);

                textBoxIdade.BackColor = Color.Aqua;
                textBoxIdade.Focus();

                return;
            }

            //validar textBoxEndereco
            if (textBoxEndereco.Text == "")
            {
                MessageBox.Show("Digite o endereço", "Preencha o campo!",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);

                textBoxEndereco.BackColor = Color.Aqua;
                textBoxEndereco.Focus();

                return;
            }

            //validar maskCelular
            if (maskedTextBoxCelular.Text.Trim().Length != 14)
            {
                MessageBox.Show("Digite seu celular", "Preencha o campo!",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);

                maskedTextBoxCelular.BackColor = Color.Aqua;
                maskedTextBoxCelular.Focus();

                return;
            }

            //validar combBoxEstado
            if (comboBoxEstado.Text == "")
            {
                MessageBox.Show("Digite seu estado", "Preencha o campo!",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);

                comboBoxEstado.BackColor = Color.Aqua;
                comboBoxEstado.Focus();

                return;
            }

            //validar combBoxPais
            if (comboBoxPais.Text == "")
            {
                MessageBox.Show("Digite seu pais", "Preenchar o campo!",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);

                comboBoxPais.BackColor = Color.Aqua;
                comboBoxPais.Focus();

                return;
            }

            //fim da validação das textBox

            /*declarando o codigo entrada de dado nas textBox, mask,
          declarando variaveis auxiliares*/
            string nome = textBoxNome.Text;
            string sobrenome = textBoxSobrenome.Text;
            int idade = int.Parse(textBoxIdade.Text);
            string endereco = textBoxEndereco.Text;
            string celular = maskedTextBoxCelular.Text;
            string estado = comboBoxEstado.Text;
            string pais = comboBoxPais.Text;

            //declarando o objeto c, da classe dados
            Dados c = new Dados(nome, sobrenome, idade, endereco, celular, estado, pais);

            /*declarando, imprimir saida de dados messageBox, chamando o objeto m,
           chamando o método toString da classe dados*/
            MessageBox.Show(c.ToString(), "Messagem");

            //declarando, limpar textbox, combBox, apos envio dos dados
            textBoxNome.Clear();
            textBoxSobrenome.Clear();
            textBoxIdade.Clear();
            textBoxEndereco.Clear();
            maskedTextBoxCelular.Clear();
            comboBoxEstado.Text = " ";
            comboBoxPais.Text = " ";
            textBoxNome.BackColor = Color.White;
            textBoxSobrenome.BackColor = Color.White;
            textBoxIdade.BackColor = Color.White;
            textBoxEndereco.BackColor = Color.White;
            maskedTextBoxCelular.BackColor = Color.White;
            comboBoxEstado.BackColor = Color.White;
            comboBoxPais.BackColor = Color.White;
            textBoxNome.Focus();

            //fim do codigo buttom enviar
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            //declarando limpando as textBox, e combBox 
            textBoxNome.Clear();
            textBoxSobrenome.Clear();
            textBoxIdade.Clear();
            textBoxEndereco.Clear();
            maskedTextBoxCelular.Clear();
            comboBoxEstado.Text = " ";
            comboBoxPais.Text = " ";
            textBoxNome.BackColor = Color.White;
            textBoxSobrenome.BackColor = Color.White;
            textBoxIdade.BackColor = Color.White;
            textBoxEndereco.BackColor = Color.White;
            maskedTextBoxCelular.BackColor = Color.White;
            comboBoxEstado.BackColor = Color.White;
            comboBoxPais.BackColor = Color.White;
            textBoxNome.Focus();

            //fim do codigo buttom cancelar
        }
        private void btnFechar_Click(object sender, EventArgs e)
        {
            //declarando fecha programa
            Close();

            //fim do codigo buttom fechar
        }

        //validar evento, somente texto na textboxNome
        private void textBoxNome_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
                {

                e.Handled = true;

                MessageBox.Show("Somente texto!!!", "Messagem ", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

            //fim do codigo buttom evento nome
        }

        //validar evento, somente texto na textboxSobrenome
        private void textBoxSobrenome_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {

                e.Handled = true;

                MessageBox.Show("Somente texto!!!", "Messagem ", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

            //fim do codigo buttom evento sobrenome
        }

        //validar evento, somente texto na textboxIdade
        private void textBoxIdade_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {

                e.Handled = true;

                MessageBox.Show("Somente número!!!", "Messagem ", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

            //fim do codigo buttom evento idade
        }
    }


        //fim do programa
}
