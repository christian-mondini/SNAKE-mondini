using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SNAKEfinale
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void esci_Click(object sender, EventArgs e)
        {
            Application.Exit();//serve a chiudere il gioco
        }

        private void gioca_Click(object sender, EventArgs e)
        {
            controllonome();
        }

        private void controllonome()
        {
            if(nomegiocatore.Text=="")
            {
                MessageBox.Show("devi inserire un nome");
            }
            else
            {

                Program.globalString = nomegiocatore.Text;
                Form2 gioco = new Form2();
                gioco.Show();
                this.Hide();
            }

        }
    }
}
