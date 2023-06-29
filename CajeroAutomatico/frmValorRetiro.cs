using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CajeroAutomatico
{
    public partial class frmValorRetiro : Form
    {
        public frmValorRetiro()
        {
            InitializeComponent();
        }

        private int posX = 0;
        private int posY = 0;

        private void MoverVentana(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            {
                posX = e.X;
                posY = e.Y;
            }
            else
            {
                Left += (e.X - posX);
                Top += (e.Y - posY);
            }
        }

        private void frmValorRetiro_MouseMove(object sender, MouseEventArgs e)
        {
            MoverVentana(sender, e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int saldo = Int32.Parse(txtSaldo.Text);
            frmRetirar frmRetirar = new frmRetirar();
            frmRetirar.retirarSaldo(saldo);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Form inicio
            = new Form1();
            inicio.Show();
            this.Close();
        }
    }
}
