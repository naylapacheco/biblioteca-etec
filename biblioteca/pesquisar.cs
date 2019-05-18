using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace biblioteca
{
    public partial class pesquisar : Form
    {
        private MySqlConnection objCnx = new MySqlConnection();
        private MySqlCommand objCmd = new MySqlCommand();
        private MySqlDataReader objL;
        public pesquisar()
        {
            InitializeComponent();
        }

        private void btnbuscador_Click(object sender, EventArgs e)
        {
            try
            {
                //da para não ficvar colocando o comando toda hora//
                MySqlDataAdapter da = new MySqlDataAdapter("Select*from cadastroAluno where nome_aluno like '" + txtBusca.Text + "%'", objCnx);
                //selecionar o que voce quer chamar do banco 

                //Data set constroi uma tabela virtual "ds" é minha variavel 
                DataSet ds = new DataSet();
                //da execute minha variavel 
                da.Fill(ds, "alunos");

                //array de informação mostra no dg
                dgClientes.DataSource = ds.Tables["alunoss"];


            }
            catch (Exception erro)
            {
                MessageBox.Show("Dados não encontrados!" + erro.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void pesquisar_Load(object sender, EventArgs e)
        {
            try
            {
                objCnx.ConnectionString = "Server=localhost;port=3306;DataBase=biblioteca;User=root;pwd=";
                //abrir o banco de dados//
                objCnx.Open();

            }
           
            catch (Exception erro)
            {
                MessageBox.Show("Erro no banco !!" + erro.Message, "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
