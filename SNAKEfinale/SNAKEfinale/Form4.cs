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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            punteggiofinale.Text = Settings.segnalino.ToString();
        }

        private void ricomincia_Click(object sender, EventArgs e)
        {
            Form2 gioco = new Form2();
            gioco.Show();
            this.Close();
        }

        private void esci_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void home_Click(object sender, EventArgs e)
        {
            Form1 home = new Form1();
            home.Show();
            this.Close();
        }

        private void punteggiofinale_Click(object sender, EventArgs e)
        {
           
        }
    }
}
