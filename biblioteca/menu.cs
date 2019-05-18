using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace biblioteca
{
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }

        private void menu_Load(object sender, EventArgs e)
        {

        }

        private void cadastroDeAlunosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cadastroAluno frm = new cadastroAluno();
            frm.MdiParent = this;
            //estou chamando de pai para filho
            frm.Show();
        }

        private void listarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listar f= new listar();
            f.MdiParent = this;
            //estou chamando de pai para filho
            f.Show();
        }

        private void pesquisaDeAlunosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pesquisar f = new pesquisar();
            f.MdiParent = this;
            //estou chamando de pai para filho
            f.Show();
        }

        private void cadastrarLivrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cadastroLivros f = new cadastroLivros();
            f.MdiParent = this;
            //estou chamando de pai para filho
            f.Show();

        }
    }
}
