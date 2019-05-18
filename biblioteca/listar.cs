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
    public partial class listar : Form

    {
        private MySqlConnection objCnx = new MySqlConnection();

        //toda vez que tiver "new" é um construtor, Liberar os comando do mysql, ficando amazenado no objCmd//
        private MySqlCommand objCmd = new MySqlCommand();
        public listar()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dglistar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void listar_Load(object sender, EventArgs e)
        {

            try
            {
                objCnx.ConnectionString = "Server=localhost;port=3306;DataBase=biblioteca;User=root;pwd=";
                //abrir o banco de dados//
                objCnx.Open();

            }
            /* catch (System.Data.OleDb.OleDbException ex)
             {
                 if (ex.ErrorCode == 1062)
                     MessageBox.Show(text: "Erro no banco !!" + "ERRO!");
             }
             */
            catch (Exception erro)
            {
                MessageBox.Show("Erro no banco !!" + erro.Message, "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            try
            {
                //da para não ficvar colocando o comando toda hora//
                MySqlDataAdapter mostra = new MySqlDataAdapter("Select nome_aluno,nomeLivro,email from cadastroAluno", objCnx);
                //objeto de conexaaõ

                //selecionar o que voce quer chamar do banco 

                //Data set constroi uma tabela virtual "ds" é minha variavel 
                DataSet ds = new DataSet();
                //da execute minha variavel 
                mostra.Fill(ds, "alunos");

                //array de informação mostra no dg
                dglistar.DataSource = ds.Tables["alunos"];


            }
            catch (Exception erro)
            {
                MessageBox.Show("Dados não encontrados!" + erro.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
