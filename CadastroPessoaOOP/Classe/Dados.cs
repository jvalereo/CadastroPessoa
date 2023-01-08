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

namespace CadastroPessoaOOP.Classe.Dados
{
    class Dados
    {
        //Treinamento, Programação Orientação ao Objeto
        //Inserindo dados, string, int, double
        //Programa, basico, cadastro de pessoas
        //Jonas Valereo - Técnico em Informática 

        /*declarando os attributos, campos e variaveis da classe dado
         , tipo, private*/

        private string _nome;
        private string _sobrenome;
        private int _idade;
        private string _endereco;
        private string _celular;
        private string _estado;
        private string _pais;
     
        
        //declarando o construtor da classe dados
        public Dados(string nome, string sobrenome, int idade, string endereco, string celular,
            string estado, string pais)
        {
            _nome = nome;
            _sobrenome = sobrenome;
            _idade = idade;
            _endereco = endereco;
            _celular = celular;
            _estado = estado;
            _pais = pais;
        }

        //declarando propriedade, get e set da class dados

        //propriedade get e set Nome
        public string Nome
        {
            get { return _nome; }

            set { _nome = value; }
        }
            
        //propriedade get e set Sobrenome
        public string Sobrenome
        {
            get { return _sobrenome; }
            set { _sobrenome = value; }
        }

        //propriedade get e set Idade
        public int Idade
        {
            get { return _idade; }
            set { _idade = value; }
        }

        //propriedade get e set Endereco
        public string Endereco
        {
            get { return _endereco; }
            set { _endereco = value; }
        }

        //propriedade get e set Celular
        public string Celular
        {
            get { return _celular; }
            set { _celular = value; }
        }

        //propriedade get e set Estado
        public string Estado
        {
            get { return _estado; }
            set { _estado = value; }
        }

        //propriedade get e set Pais
        public string Pais
        {
            get { return _pais; }
            set { _pais = value; }
        }

        //declarando o metodo Cadastro da classe dados
        public string Cadastro()
        {

            StringBuilder s = new StringBuilder();

            s.AppendLine("Nome: " + Nome);
            s.AppendLine("Sobrenome: " + Sobrenome);
            s.AppendLine("Idade: " + Idade.ToString() + " anos");
            s.AppendLine("Endereço: " + Endereco);
            s.AppendLine("Celular: " + Celular);
            s.AppendLine("Estado: " + Estado);
            s.AppendLine("Pais: " + Pais);


            return s.ToString();
        }

        //declarando modificador da class dados, tipo string
        public override string ToString()

        {

            return Cadastro().ToString();
        }
        
        //fim da class dados
    }
}
