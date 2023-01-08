using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CadastroPessoaOOP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void btnAcessar_Click(object sender, EventArgs e)
        {
            //Treinamento, Programação Orientação ao Objeto
            //Inserindo dados, double
            //Programa, basico, cadastro de pessoas
            //Jonas Valereo - Técnico em Informática 

            //declarando chamando o form2, fechando o form1 

            this.Visible = false;
            Form2 c = new Form2();
            c.ShowDialog();
            this.Visible = false;
        }

        //fim do programa
    }
}
