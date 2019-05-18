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
    public partial class TelaSplash : Form
    {
        public TelaSplash()
        {
            InitializeComponent();
        }

        private void TelaSplash_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (barrinha.Value < 100)
            {

                barrinha.Value = barrinha.Value + 2;

            }
            else
            {

                timer1.Enabled = false;
                this.Visible = false;
                this.Close();
                menu m = new menu();
                m.ShowDialog();
            }
            if ((barrinha.Value >= 1) && (barrinha.Value <= 20))
            {
                label1.Text = "Carregando Informações...";
                label2.Text = barrinha.Value + "%";



            }
            if ((barrinha.Value >= 21) && (barrinha.Value <= 40))
            {
                label1.Text = "Carregando Formularios...";
                label2.Text = barrinha.Value + "%";



            }
            if ((barrinha.Value >= 41) && (barrinha.Value <= 60))
            {
                label1.Text = "Carregando Ferramentas...";
                label2.Text = barrinha.Value + "%";



            }
            if ((barrinha.Value >= 61) && (barrinha.Value <= 70))
            {
                label1.Text = "Sistema quase pronto aguarde...";
                label2.Text = barrinha.Value + "%";



            }
            if ((barrinha.Value >= 81) && (barrinha.Value <= 100))
            {
                label1.Text = "Sistema pronto.";
                label2.Text = barrinha.Value + "%";



            }
        }
    }
}
