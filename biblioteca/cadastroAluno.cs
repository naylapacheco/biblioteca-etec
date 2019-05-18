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
    public partial class cadastroAluno : Form
    {
        //comando OBRIGATORIO! liberar a conexão com o banco atraves do objCnx//
        private MySqlConnection objCnx = new MySqlConnection();

        //toda vez que tiver "new" é um construtor, Liberar os comando do mysql, ficando amazenado no objCmd//
        private MySqlCommand objCmd = new MySqlCommand();
        public cadastroAluno()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //variaverl para guardar o inser into//
                String strSql;

                strSql = "Insert Into cadastroAluno(nome_aluno,curso,periodo,semestre,nomeLivro,telefoneCel,email)Values(";
                strSql += "'" + nomeAluno.Text + "',";
                strSql += "'" + comboBox1.Text + "',";
                strSql += "'" + comboBox2.Text + "',";
                strSql += "'" + comboBox3.Text + "',";
                strSql += "'" + txtlivro.Text + "',";
                strSql += "'" + telefoneAluno.Text + "',";               
                strSql += "'" + email.Text + "')";

                //pedir permissaõ para conectar e executar os comandos//
                objCmd.Connection = objCnx;

                //verificar/liberar a conexão com o banco e qual comando quero executar//
                //Insert -> sempre utilizar CommandText//
                objCmd.CommandText = strSql;

                //executar o comado do insert//
                objCmd.ExecuteNonQuery();

                MessageBox.Show("Cadastro realizado", "cadastro com sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                nomeAluno.Clear();
                telefoneAluno.Clear();               
                email.Clear();
                nomeAluno.Focus();
                this.Visible = false;
                this.Hide();
                menu tela = new menu();
                tela.ShowDialog();

            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao cadastrar" + erro.Message, "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cadastroAluno_Load(object sender, EventArgs e)
        {
            try
            {
                objCnx.ConnectionString = "Server=localhost;port=3306;DataBase=biblioteca;User=root;pwd=";

                objCnx.Open();

            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao cadastrar" + erro.Message, "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
