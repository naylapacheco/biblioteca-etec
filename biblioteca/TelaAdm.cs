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
    public partial class TelaAdm : Form
    {
        private MySqlConnection objCnx = new MySqlConnection();


        private MySqlCommand objCmd = new MySqlCommand();

        private MySqlDataReader objL;

        public TelaAdm()
        {
            InitializeComponent();
        }

        private void TelaAdm_Load(object sender, EventArgs e)
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
            String strSql = "Select*from CadastroAdm where login_adm='" + txtlogin.Text + "' and senha_adm ='" + txtsenha.Text + "'";

            objCmd.Connection = objCnx;


            objCmd.CommandText = strSql;

            //objL ira ler a linha e xecutar o comando de leitura que é executaReader// 
            objL = objCmd.ExecuteReader();

            //se ele não encontro ele vai me dar amensagem de erro//
            if (!objL.HasRows)
            {
                MessageBox.Show("Login e seha incorretos!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Visible = false;
                this.Hide();
                TelaAdm tela1 = new TelaAdm();
                tela1.ShowDialog();

            }
            else
            {


                MessageBox.Show("Login e seha corretos!", "Logado no sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Visible = false;
                this.Hide();
                TelaSplash tela1 = new TelaSplash();
                tela1.ShowDialog();

            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
