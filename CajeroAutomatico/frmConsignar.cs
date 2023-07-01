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
    public partial class frmConsignar : Form
    {
        public frmConsignar()
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
        private void frmConsignar_Load(object sender, EventArgs e)
        {

        }

        private void frmConsignar_MouseMove(object sender, MouseEventArgs e)
        {
            MoverVentana(sender, e);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Form inicio
            = new frmPrincipal();
            inicio.Show();
            this.Close();
        }
    }
}
