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
    public partial class cadastroLivros : Form
    {


        private MySqlConnection objCnx = new MySqlConnection();

        private MySqlCommand objCmd = new MySqlCommand();
        public cadastroLivros()
        {
            InitializeComponent();
        }

        private void cadastroLivros_Load(object sender, EventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                String strSql;

                strSql = "Insert Into cadastrolivro(nomeLivro,nomeAutor,editora,generoLivro,qntdLivros)Values(";
                strSql += "'" + txtnomeLivro.Text + "',";
                strSql += "'" + txtAutor.Text + "',";
                strSql += "'" + txtnomeEditora.Text + "',";
                strSql += "'" + comboGenero.Text + "',";
                strSql += "'" + numericUpDown1.Text + "')";
               

                //pedir permissaõ para conectar e executar os comandos//
                objCmd.Connection = objCnx;

                //verificar/liberar a conexão com o banco e qual comando quero executar//
                //Insert -> sempre utilizar CommandText//
                objCmd.CommandText = strSql;

                //executar o comado do insert//
                objCmd.ExecuteNonQuery();

                MessageBox.Show("Cadastro realizado", "cadastro com sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtnomeLivro.Clear();
                txtAutor.Clear();
                txtnomeEditora.Clear();
                txtnomeLivro.Focus();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao cadastrar" + erro.Message, "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
